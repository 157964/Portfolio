#include <FastLED.h>

#define NUM_LEDS 179
#define DATA_PIN 21

CRGB leds[NUM_LEDS];

void setup() { 
    FastLED.addLeds<WS2812B, DATA_PIN, GRB>(leds, NUM_LEDS);
}

void loop() { 
 
 FastLED.show();
 for (int i = 0; i <= NUM_LEDS; i++) {
  leds[i] = CRGB::Purple;
  FastLED.show();
  delay(1);
}
 for (int i = NUM_LEDS; i >= 0; i--) {
  leds[i] = CRGB::Red;
  FastLED.show();
  delay(1);
}

}
