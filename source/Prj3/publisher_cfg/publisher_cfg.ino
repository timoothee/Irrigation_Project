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
char string_to_be_send[20];

// MQTT Broker
const char *mqtt_broker = "broker.emqx.io";
const char *publish_topic = "/ES2-IOT/test/viotimoteimihaivalva/";
const char *mqtt_username = "emqx";
const char *mqtt_password = "public";
const int mqtt_port = 1883;
String client_id = "esp8266-client-es2-iot-test-1-publisher";

WiFiClient wifiClient;
PubSubClient mqttClient(wifiClient);

void setup() {
  // Set software serial baud to 9600;
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
}

void loop() {
  mqttClient.publish(publish_topic, sensor_readings());
}

char* sensor_readings(){
  String temp, hum, soil, all_data;
  
  float sensor_value  = analogRead(soil_moisture_pin) * 0.1;
  int sensor_value_final = map(sensor_value, 0, 1013, 0, 100);
  soil = sensor_value_final;

  DHT.read(DHTPIN);
  temp = DHT.temperature;
  hum = DHT.humidity;

  /*
  Serial.print("Sensor Value: ");
  Serial.println(sensor_value_final);
  Serial.print("temp:");
  Serial.print(DHT.temperature);
  Serial.print("  humi:");
  Serial.println(DHT.humidity);
  */

  all_data ="+" + temp +'_' + hum + '-' + soil + '=';
  all_data.toCharArray(string_to_be_send, all_data.length() + 1);
  delay(2000);

  return string_to_be_send;
}