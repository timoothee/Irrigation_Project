#include <DFRobot_DHT11.h>
DFRobot_DHT11 DHT;

// Define area
#define DHTPIN 16  
#define DHTTYPE DHT11   // DHT 11

int soil_moisture_pin = A0;

void setup() {
  Serial.begin(9600);
  Serial.println(F("DHT Initialization!"));
}

void loop() {
  sensor_readings();
}

int sensor_readings(){
  float sensor_value  = analogRead(soil_moisture_pin);
  int sensor_value_final=map(sensor_value, 0,1013, 0, 100);
  Serial.print("Sensor Value: ");
  Serial.println(sensor_value_final);

  DHT.read(DHTPIN);
  Serial.print("temp:");
  Serial.print(DHT.temperature);
  Serial.print("  humi:");
  Serial.println(DHT.humidity);

  delay(2000);
  return sensor_value, DHT.temperature, DHT.humidity;
}
