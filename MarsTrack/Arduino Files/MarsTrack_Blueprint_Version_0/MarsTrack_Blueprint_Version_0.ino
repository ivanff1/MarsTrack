#include <DHT.h>;
#define DHTPIN 4     // what pin we're connected to
#define DHTTYPE DHT22 
#define trigerPin 7
#define echoPin 8
#define moistureSensorPin A0
DHT dhtSensor(DHTPIN,DHTTYPE);

long duration;
double distance;
float temperature;
float hum;
String commandStr = "";

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(trigerPin, OUTPUT);
  pinMode(echoPin, INPUT);
  pinMode(moistureSensorPin, INPUT);
  dhtSensor.begin();
}
void loop() {
  commandStr = Serial.readString();
  // put your main code here, to run repeatedly:
  if(commandStr.equals("TEMPD"))
  {
     Temperature();
  }
  else if(commandStr.equals("HUMID"))
  {
      Humidity();
  }
  else if(commandStr.equals("SOILM"))
  {
      SoilMoisture();
  }   
}

void Rangefinder(){
 digitalWrite(trigerPin, HIGH);
 delayMicroseconds(10);
 digitalWrite(trigerPin, LOW);

 duration = pulseIn(echoPin, HIGH);

 distance = duration * 0.034/2;

 Serial.print("Distance is>>> ");
 Serial.print(distance);
 Serial.println(" CM");
}

void SoilMoisture()
{
  long moistureSensorIncomingValue = analogRead(moistureSensorPin);
  moistureSensorIncomingValue =  map(moistureSensorIncomingValue ,650,350,0,100);
  Serial.print("Mositure Is>>> ");
  Serial.println(moistureSensorIncomingValue);
}

void Temperature()
{ 
    temperature = dhtSensor.readTemperature();
    Serial.print("Temperature is>>> ");
    Serial.println(temperature);
}

void Humidity()
{
    hum = dhtSensor.readHumidity();
    Serial.print("Humidity Is>>> ");
    Serial.println(hum);
}
