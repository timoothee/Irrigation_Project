// Turn on/off relay.

void setup() {
  // Set serial baud to 115200;
  Serial.begin(115200);
  // Connecy relay signal pin to D0(GPIO16)
  pinMode(16, OUTPUT);
}

void loop() {
  digitalWrite(16, HIGH);
  delay(1000);
  digitalWrite(16, LOW);
  delay(1000);
}
