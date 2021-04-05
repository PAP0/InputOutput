bool lightOne = false;
bool lightTwo = false;
bool lightThree = false;

// the setup routine runs once when you press reset:
  const int LED_ONE = 5; // choose the pin for each of the LEDs
  const int LED_TWO = 6;
  const int LED_THREE = 7;
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  // make the pushbutton's pin an input:
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
}

// the loop routine runs over and over again forever:
void loop() {
  // print out the state of the button:
  if(Serial.available())
  {
    char c = Serial.read();
    if (c)
    {
      if(c == 'A')
      {
        lightOne = true;
      }
      else if(c == 'B')
      {
        lightTwo = true;
      }
      else if(c == 'C')
      {
        lightThree = true;
      }
      c = NULL;
    }
  }
  if(lightOne)
  {
    digitalWrite(LED_ONE, LOW);
    Serial.println("One");
  }
  else if(lightTwo)
  {
    digitalWrite(LED_TWO, LOW);
    Serial.println("Two");
  }
  else if(lightThree)
  {
    digitalWrite(LED_THREE, LOW);
    Serial.println("Three");
  }

  delay(100);        // delay in between reads for stability
}
