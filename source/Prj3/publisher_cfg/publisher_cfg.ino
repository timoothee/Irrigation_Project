#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <DFRobot_DHT11.h>
DFRobot_DHT11 DHT;

// WiFi
const char *ssid = "iPhone X";
const char *password = "012345678";

// Define Area
#define DHTTYPE DHT11   // DHT 11
#define DHTPIN 16  

int soil_moisture_pin = A0;
String temp, hum, soil, retVal, retVal1;
char retval_buf[20];

// MQTT Broker
const char *mqtt_broker = "broker.emqx.io";
const char *publish_topic = "/ES2-IOT/test/viotimoteimihaivalva/";
const char *mqtt_username = "emqx";
const char *mqtt_password = "public";
const int mqtt_port = 1883;
String client_id = "esp8266-client-es2-iot-test-1-publisher";

WiFiClient wifiClient;
PubSubClient mqttClient(wifiClient);
String v;

void setup() {
  // Set software serial baud to 115200;
  Serial.begin(9600);
  // connecting to a WiFi network
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
      delay(500);
      Serial.println("Connecting to WiFi..");
  }
  Serial.println("Connected to the WiFi network");
  //connecting to a mqtt broker
  mqttClient.setServer(mqtt_broker, mqtt_port);
  while (!mqttClient.connected()) {
      Serial.printf("The mqttClient %s connects to the public mqtt broker\n", client_id.c_str());
      
      if (mqttClient.connect(client_id.c_str(), mqtt_username, mqtt_password)) {
          Serial.println("Public emqx mqtt broker connected");
      } else {
          Serial.print("failed with state ");
          Serial.print(mqttClient.state());
          delay(2000);
      }
  }
  // subscribe to topic
}

void sensor_readings(){
  float sensor_value  = analogRead(soil_moisture_pin);
  int sensor_value_final=map(sensor_value, 0,1013, 0, 100);
  Serial.print("Sensor Value: ");
  Serial.println(sensor_value_final);

  DHT.read(DHTPIN);
  Serial.print("temp:");
  Serial.print(DHT.temperature);
  Serial.print("  humi:");
  Serial.println(DHT.humidity);

  temp = DHT.temperature;
  hum = DHT.humidity;
  soil = sensor_value_final;
  retVal = temp +'_' + hum + '-' + soil;
  retVal1 = retVal.toCharArray(retval_buf, retVal.length());
  delay(2000);
  Serial.print(retVal);
}

void loop() {
mqttClient.loop();
mqttClient.publish(publish_topic, retVal1);
delay(500);
mqttClient.publish(publish_topic,"off");
delay(500);
sensor_readings();
}
