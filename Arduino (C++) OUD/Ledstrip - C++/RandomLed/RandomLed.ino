#include <FastLED.h>

// How many leds in your strip?
#define NUM_LEDS 178

// For led chips like WS2812, which have a data line, ground, and power, you just
// need to define DATA_PIN.

#define DATA_PIN 3

// Define the array of leds
CRGB leds[NUM_LEDS];

void setup() { 
    FastLED.addLeds<WS2812B, DATA_PIN, GRB>(leds, NUM_LEDS);
}

void loop() {

  for(int i = 0; i <= NUM_LEDS; i++) {
    int RED = random(255);
    int GREEN = random(255);
    int BLUE = random(255);

    leds[i] = CRGB(RED, GREEN, BLUE);
    FastLED.show();
  }

}
