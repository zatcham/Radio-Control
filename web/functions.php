<?php
    $name = ($_GET['name']);
	$data = ($_GET['data']);
	
	
	
	if ($name = "playCheck")
	{
		playCheck();
	}
	
	function write(name, data)
	{

	}

	function playCheck()
	{
	$myfile = fopen("playback.rxc", "r") or die("Unable to open file!");

	if fread($myfile) = ("Play")
	{
		echo "Play";
	}

	{
	fclose($myfile);
?>