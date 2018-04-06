using System;
using Bifrost.Devices.Gpio;
using Bifrost.Devices.Gpio.Abstractions;
using Bifrost.Devices.Gpio.Core;

namespace blinkLED
{
    class Program {
        class Blinker {
            private IGpioController gpioController;
            private int ledPin;

            public Blinker(int pin) {
                gpioController = GpioController.Instance;
                ledPin = pin;
            }

            public void runBlink() {
                var pin = gpioController.OpenPin(ledPin);
                pin.SetDriveMode(GpioPinDriveMode.Output);

                while (true) {
                    pin.Write(GpioPinValue.High); // LED ON
                    System.Threading.Thread.Sleep(2000);

                    pin.Write(GpioPinValue.Low); // LED OFF
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }

        static void Main(string[] args) {
            Blinker b = new Blinker(26);
            b.runBlink();
        }
    }
}
