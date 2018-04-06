# Howto run

## On your computer
* Have a working .NET core 2.0 environment on your computer
* Clone this repo
* Install deps
 `dotnet restore`
* Compile the project using
 `dotnet publish -r linux-arm`
* Copy publish folder to your pi
 `scp -r bin/Debug/netcoreapp2.0/linux-arm/publish/ rpi@whatever:~/`

## On the Pi
* Install dependencies for dotnet runtime on the Pi (Rasbian Strech presumed)
 `sudo apt install curl libunwind8 gettext apt-transport-https`
* `cd ~/publish`
* `sudo chmod a+x blinkLED`
* `sudo ./blinkLED` Your led should now blink.
