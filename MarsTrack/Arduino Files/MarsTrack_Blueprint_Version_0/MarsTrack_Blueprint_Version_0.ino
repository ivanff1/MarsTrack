#include <DallasTemperature.h>
#include <OneWire.h>
#include <DHT.h>

#define dsTempSensorPin 2
#define DHTPIN 4     // what pin we're connected to
#define DHTTYPE DHT22 
#define trigerPin 7
#define echoPin 8
#define moistureSensorPin A0

DHT dhtSensor(DHTPIN,DHTTYPE);
OneWire oneWireTempSensor(dsTempSensorPin);
DallasTemperature tempSensor(&oneWireTempSensor);

long duration;
double distance;
float dhtTemperature;
float dsSensorTemperature;
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
  tempSensor.begin();
}
void loop() {
  commandStr = Serial.readString();
  // put your main code here, to run repeatedly:
  if(commandStr.equals("TEMPD"))
  {
     Temperature();
     
     delay(8);
  }
  else if(commandStr.equals("HUMID"))
  {
      Humidity();
      delay(8);
  }
  else if(commandStr.equals("SOILM"))
  {
      SoilMoisture();
      delay(8);
  }   
  else if(commandStr.equals("RANGEF"))
  {
    Rangefinder;
    delay(5);
  }
  else 
  {
  }

}

void Rangefinder(){
 digitalWrite(trigerPin, HIGH);
 delayMicroseconds(10);
 digitalWrite(trigerPin, LOW);

 duration = pulseIn(echoPin, HIGH);

 distance = duration * 0.034/2;

 Serial.println(distance);
}
void SoilMoisture()
{
  long moistureSensorIncomingValue = analogRead(moistureSensorPin);
  moistureSensorIncomingValue =  map(moistureSensorIncomingValue ,650,350,0,100);
  Serial.println(moistureSensorIncomingValue);
}
void DsTemperatureS()
{
  tempSensor.requestTemperatures();
  dsSensorTemperature = tempSensor.getTempCByIndex(0);
}
void DhtSensorTemp()
{
  dhtTemperature = dhtSensor.readTemperature();
}
void Temperature()
{ 
    DhtSensorTemp();
    DsTemperatureS();
  
    temperature = (dsSensorTemperature+dhtTemperature)/2;
    Serial.println(temperature);
}

void Humidity()
{
    hum = dhtSensor.readHumidity();
    Serial.println(hum);
}
