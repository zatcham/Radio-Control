<?php
    $name = ($_GET['name']);
	
	if ($name = "getmute")
	{
		getMute();
	} elseif ($name = "getvol")
	{
		getVolume();
	} elseif ($name = "getstation")
	{
		getStation();
	} elseif ($name = "getplayback")
	{
		getPlayback();
	} elseif ($name = "setmute")
	{
		setMute();
	} elseif ($name = "setstation")
	{
		setStation();
	} elseif ($name = "setvol")
	{
		setVolume();
	} elseif ($name = "setplayback")
	{
		setPlayback();
	}

	// start of get functions | recieving from VB
	function getMute()
	{
		$myfile = fopen("comms/mute.rxc", "r") or die("Unable to open file!");
		echo fgets($myfile);
		fclose($myfile);
	}

	function getVolume()
	{
		$myfile = fopen("comms/volume.rxc", "r") or die("Unable to open file!");
		echo fgets($myfile);
		fclose($myfile);
	}

	function getStation()
	{
		$myfile = fopen("comms/station.rxc", "r") or die("Unable to open file!");
		echo fgets($myfile);
		fclose($myfile);
	}

	function getPlayback()
	{
		$myfile = fopen("comms/playback.rxc", "r") or die("Unable to open file!");
		echo fgets($myfile);
		fclose($myfile);
	}

	// start of set functions | sending to VB
	function setPlayback()
	{
		$input = ($_GET['data']);

		if ($input = "True")
		{
			$myfile = fopen("playback.txc", "w");
			$txt = "True";
			fwrite($myfile, $txt);
			fclose($myfile);
			echo "OK";
		} elseif ($input = "False")
		{
			$myfile = fopen("playback.txc", "w");
			$txt = "False";
			fwrite($myfile, $txt);
			fclose($myfile);
			echo "OK";
		}
	}

	function setStation()
	{
		$data = ($_GET['data']);
		$myfile = fopen("comms/station.txc", "w") or die("Unable to open file!");
		fwrite($myfile, $data);
		fclose($myfile);
		echo "STATION OK";
	}

	function setVolume()
	{
		if(!empty($_GET['data'])){
			$volfile = fopen("comms/volume.txc", "w") or die("Unable to open file!");
			fwrite($volfile, $volume);
			fclose($volfile);
			echo "VOL OK \r\n {$vol}";
		}
	}

	function setMute()
	{
		if (!empty($_GET['data'])){
			$mutefile = fopen("comms/mute.txc", "w") or die("Unable to open file!");
			fwrite($mutefile, $mute);
			fclose($mutefile);
			echo "MUTE OK \r\n {$mute}";
		}
	}
?>