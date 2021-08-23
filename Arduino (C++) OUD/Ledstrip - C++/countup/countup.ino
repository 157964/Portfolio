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

int k = 177;
void loop() {
  int j = NUM_LEDS;
  
  for ( int i = 0; i <= j; i++) {
    int q = i - 10;
    int x = k - 1;
    int brightness = k / 2;

    if(k <= 1) {
      k = 177;
    }
    
    if(i < k) {
      leds[i] = CRGB::White;
    }
    
    if(q >= 1 && q < k) {
      leds[q] = CRGB::DarkBlue;
      leds[q] %= 60;
    }
    
    
    if(i == x) {
      leds[i] = CRGB::Purple;
      k -= 10;
    }

    FastLED.setBrightness(brightness);
    
    //shows the "progress"
    FastLED.show();
  }
  
  FastLED.show();
}
