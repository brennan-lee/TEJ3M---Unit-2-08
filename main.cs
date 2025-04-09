/*
* Created by: Brennan Lee
* Created on: Apr 2025
* This program gets distance
*/

#include <Servo.h>  // Include the Servo library

// Create a servo object
Servo servoNumber1;

// Define the analog pin for the potentiometer
const int POT_PIN = A0; 

void setup() {
  // Start serial communication
  Serial.begin(9600);

  // Attach the servo to pin 9 and set it to 0°
  servoNumber1.attach(9);
  servoNumber1.write(0);
}

void loop() {
  // Read the potentiometer value (0 to 1023)
  int potValue = analogRead(POT_PIN);
  int angle = potValue / 6;

  // Make sure angle does not exceed 180
  if (angle > 180) {
    angle = 180;
  }

  // Move the servo to the calculated angle
  servoNumber1.write(angle);

  delay(100); // Small delay for stability
}
