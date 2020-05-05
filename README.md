# Radio-Control

This program, written in VB.NET, allows for control of radio playback via a local GUI and a remote web page.

It uses the Vlc.DotNet libraries to handle playback, MaterialSkin for the GUI, and Newtonsoft.Json for reading of the JSON configuration file.

## How to use:

The program is very simple to use.

1. Set the radio stations in the JSON file, an example is provided. The file must be located in the same directory as the executable and be named 'RadioSettings.json'

JSON Example:
`[
	{
	id: "1",
	name: "Radio Station 1",
	url: "https://station_url"
	},
	{
	id: "2",
	name: "Radio Station 2",
	url: "http://station_url"
 }
]`


2. Ensure you have a working audio output device (the program uses the default device for playback), and a working internet connection

3. Run the Program

## Updates

The program includes a program written by myself, known as UpdateMagic. Occasionally, when updates are available, the program will prompt you to download an update. When checking for updates, the program sends a very limited amount of telemetry info back to our Update server, e.g. OS Version, current program version and the amount of times the program has run

UpdateMagic relies on a VBScript in the same directory as the executable called 'UpdateHelper.vbs'
