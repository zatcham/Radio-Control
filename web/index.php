<style>
  .hide { position:absolute; top:-1px; left:-1px; width:1px; height:1px; }
</style>



<html>

<head>

<iframe name="stationFrame" class="hide"></iframe>
<iframe name="volFrame" class="hide"></iframe>
<meta http-equiv="Content-Language" content="en-gb">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252">
<title>Remote radio control applet</title>
</head>

<body>

<h3 align="center">Remote radio control applet</h3>
<table border="1" width="100%" id="table1">

	<tr>
		<td width="25%">
		<p align="center">Player control</td>
		<td width="25%">
		<p align="center">Volume control</td>
		<td width="50%">
		<p align="center">Station select</td>
	</tr>
	<tr>
		<td align="center" width="25%">
			<form action="/SetPlayback.php" method="GET">
		</form>
			<button align="center" id="playbackbtn" name="Play/Pause" onclick="playback()"> Play</button>
		</td>
		
		<td align="center" width="25%">
		<form action="/SetVolume.php" method="GET" target="volFrame">
			<p align="center">
			<input type="submit" value="Set Volume">
			<select size="1" name="volumedrop" id="volumedrop">
			<option value="0">0</option>
			<option value="10">10</option>
			<option value="20">20</option>
			<option value="30">30</option>
			<option value="40">40</option>
			<option value="50">50</option>
			<option value="60">60</option>
			<option value="70">70</option>
			<option value="80">80</option>
			<option value="90">90</option>
			<option value="100">100</option>
			</select>
			<!-- <input type="checkbox" name="mute" value="Mute">Mute</p> -->
		</form>
			<input align="center" type="checkbox" id="mutebox" name="Mute" onchange="mute()"/> Mute
		</td>
		
		<td align="center" width="50%">
			<form action="/SetStation.php" method="GET" name="station" target="stationFrame">
			<p align="center">
			<input type="submit" value="Tune">
			<?php
				$filename = 'comms\stations.rxc';
				$incrament = "0";
				$eachlines = file($filename, FILE_IGNORE_NEW_LINES);//create an array
				echo '<select name="stationbox" id="stationbox">';
				foreach($eachlines as $lines)
				{
					$incrament = ($incrament + "1");
					echo "<option value={$incrament}>{$lines}</option>";
				}
				echo '</select>';
			?>
		</form></td>
	</tr>
	
</table>

<!--	Mistake below works lol		-->
<style type="text/css">
#volStatus {display:inline-block;

#playStatus 
{display:inline-block;} 
</style>

<table border="1" width="25%" id="table2">
<tr>
	<td width="25%"> 
	<p align="center">Status</td>
</tr>

	<tr>
		<td align="left" width="25%">
		
		<div id="volStatus">
			<p>Current Volume:<span id="txtCurrentVol"></span></p>
			<p>Current Station:<span id="txtStation"></span></p>
			<p>Playback Status:<span id="txtPlayback"></span></p>
			<p>Muted:<span id="txtMute"></span></p>
		</div>
		
		<div align="center" id="playStatus">
        <button align="center" onclick="refreshAll()">Refresh All</button> 
		</div>
		
	</tr>
</table>



</body>

<script>	
var playback_current = "s";
function getVolume() 
{
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) 
			{
				//document.getElementById("txtCurrentVol").innerHTML = this.responseText;
				var r1 = parseFloat(this.responseText);
				var r2 = Math.ceil(r1 / 10) * 10;
				document.getElementById('volumedrop').value = r2;
				document.getElementById("txtCurrentVol").innerHTML = r2;
				// rounds volume
            }
		}
        xmlhttp.open("GET", "getvolume.php", true);
        xmlhttp.send();
}
function run(name, data) 
{
	var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("GET", "functions.php?name=" + name + "?data=" + data, true);
    xmlhttp.send(null);
}
function mute()
{
  if (document.getElementById('mutebox').checked === true) 
  {
      var xmlhttp = new XMLHttpRequest();
      xmlhttp.open("GET", "SetVolume.php?mute=true", true);
      xmlhttp.send(null);
  }
  
    if (document.getElementById('mutebox').checked === false) 
	{
       var xmlhttp = new XMLHttpRequest();
    	xmlhttp.open("GET", "SetVolume.php?mute=false", true);
    	xmlhttp.send(null);
    }
}
function playback()
{
	// inverse
	// current true means playing, false is pause
	if (playback_current === "play") 
	{
		document.getElementById("playbackbtn").innerHTML = "Pause";
		playback_current = "pause";
		var xmlhttp = new XMLHttpRequest();
    	xmlhttp.open("GET", "SetPlayBack.php?data=false", true);
    	xmlhttp.send(null);

	} else if (playback_current === "pause")
	{
		document.getElementById("playbackbtn").innerHTML = "Play";
		var xmlhttp = new XMLHttpRequest();
    	xmlhttp.open("GET", "SetPlayBack.php?data=true", true);
    	xmlhttp.send(null);
		playback_current = "play";
	} else if (playback_current === "s")
	{
		var xmlhttp = new XMLHttpRequest();
    	xmlhttp.open("GET", "SetPlayBack.php?data=true", true);
    	xmlhttp.send(null);
		playback_current = "play";
	}
}
function getPlayback()
{
	var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) 
			{
				if (this.responseText === "true")
				{
					document.getElementById("playbackbtn").innerHTML = "Pause";
					document.getElementById("txtPlayback").innerHTML = "Playing";
					playback_current = "pause";
				} else if (this.responseText === "false")
				{
					document.getElementById("playbackbtn").innerHTML = "Play";
					document.getElementById("txtPlayback").innerHTML = "Paused";
					playback_current = "play";
				}
            }
		}
        xmlhttp.open("GET", "getplayback.php", true);
        xmlhttp.send();
	
}
function getStation() 
{
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) 
			{
				document.getElementById("txtStation").innerHTML = this.responseText;
				//document.getElementsByName('stationbox')[100].options[100].innerHTML = this.responseText;
            }
		}
        xmlhttp.open("GET", "GetStation.php", true);
        xmlhttp.send();
}

function getMuted() 
{
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) 
			{
				document.getElementById("txtMute").innerHTML = this.responseText;
				if (this.responseText === "True")
				{
					document.getElementById("mutebox").checked = true;
				} else if (this.responseText === "False")
				{
					document.getElementById("mutebox").checked = false;
				}
            }
		}
        xmlhttp.open("GET", "GetMuted.php", true);
        xmlhttp.send();
}

function refreshAll()
{
	getVolume();
	getPlayback();
	getStation();
	getMuted();
}

function selectElement(id, valueToSelect) {    
    let element = document.getElementById(id);
    element.value = valueToSelect;
}

window.onload = function() {
  refreshAll();
};

var refreshTimer = window.setInterval(refreshAll, 5000);

</script>



</html>

