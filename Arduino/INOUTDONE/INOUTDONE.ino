  bool lightOn = false;
bool lightTwo = false;
bool lightThree = false;

const int LED_ONE = D5;
const int LED_TWO = D6;
const int LED_THREE = D7;// choose the pin for each of the LEDs
// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  // make the pushbutton's pin an input:
  //pinMode(LED_BUILTIN, OUTPUT);
  pinMode(LED_ONE, OUTPUT);
  pinMode(LED_TWO, OUTPUT);
  pinMode(LED_THREE, OUTPUT);
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
        lightOn = true;
      }
      if(c == 'B')
      {
        lightTwo = true;
      }
      if(c == 'C')
      {
        lightThree = true;
      }
      else if(c == 'F')
      {
        lightOn = false;
      }
      else if(c == 'G')
      {
        lightTwo = false;
      }
      else if(c == 'H')
      {
        lightThree = false;
      }
      c = NULL;
    }
  }
  if(lightOn)
  {
    digitalWrite(LED_ONE, LOW);

  }
  else
  {
    digitalWrite(LED_ONE, HIGH);

  }

  if(lightTwo)
  {
    digitalWrite(LED_TWO, LOW);

  }
  else
  {
    digitalWrite(LED_TWO, HIGH);

  }

  if(lightThree)
  {
    digitalWrite(LED_THREE, LOW);

  }
  else
  {
    digitalWrite(LED_THREE, HIGH);

  }
  delay(100);        // delay in between reads for stability
}
