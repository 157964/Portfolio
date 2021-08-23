void setup() {
  // put your setup code here, to run once:
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
 Serial.println("THINGS");
 digitalWrite(LED_BUILTIN, LOW);
 delay(10000);
 Serial.println("2nd TESTline");
 digitalWrite(LED_BUILTIN, HIGH);
 delay(10000);
}
