#include <ESP8266WiFi.h>
#include <PubSubClient.h>

// WiFi
const char *ssid = "OMiLAB";
const char *password = "digifofulbs";

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
  pinMode(16,OUTPUT);
  Serial.begin(115200);
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

void subscribe_callback(char *topic, byte *payload, unsigned int length) {
  Serial.print("Message arrived in topic: ");
  Serial.println(topic);
  Serial.print("Message:");
  for (int i = 0; i < length; i++) {
      Serial.print((char) payload[i]);
      v+=(char)payload[i];
  }
  Serial.println();
  Serial.println("-----------------------");
}

void loop() {
mqttClient.loop();
mqttClient.publish(publish_topic,"on");
delay(500);
mqttClient.publish(publish_topic,"off");
delay(500);
}
