// Print data

#include <ESP8266WiFi.h>
#include <PubSubClient.h>

// Define area
#define relay 16

// WiFi
const char *ssid = "iPhone X";
const char *password = "012345678";
// MQTT Broker
const char *mqtt_broker = "broker.emqx.io";
const char *subscribe_topic = "/ES2-IOT/test/viotimoteimihaivalva/"; // Topic !!
const char *mqtt_username = "emqx";
const char *mqtt_password = "public";
const int mqtt_port = 1883;
String client_id = "esp8266-client-es2-iot-test-1-timo";

WiFiClient wifiClient;
PubSubClient mqttClient(wifiClient);
String publisher_message;

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
  mqttClient.setCallback(subscribe_callback);
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
  mqttClient.subscribe(subscribe_topic);
}

void loop() {
  mqttClient.loop();
}

void subscribe_callback(char *topic, byte *payload, unsigned int length) {
  int delimiter, delimiter_1, delimiter_2, delimiter_3;
  Serial.print("Message arrived in topic: ");
  Serial.println(topic);
  publisher_message = "";
  for (int i = 0; i < length; i++) {
      //Serial.print((char) payload[i]);
      publisher_message += (char)payload[i];
  }

  delimiter = publisher_message.indexOf("+");
  delimiter_1 = publisher_message.indexOf("_", delimiter + 1);
  delimiter_2 = publisher_message.indexOf("-", delimiter_1 + 1);
  delimiter_3 = publisher_message.indexOf("=", delimiter_2 + 1);

  String temp_var = publisher_message.substring(delimiter + 1, delimiter_1);
  String humydity_var = publisher_message.substring(delimiter_1 + 1, delimiter_2);
  String soil_var = publisher_message.substring(delimiter_2 + 1, delimiter_3);
  
  print_data(temp_var, humydity_var, soil_var);
  Serial.println("-----------------------");
}

void print_data(String temp, String hum, String soil)
{
  Serial.println("Temperature = " + temp + "°C");
  Serial.println("Humidity = " + hum + "%");
  Serial.println("Soil humidity = " + soil + "%");
}
