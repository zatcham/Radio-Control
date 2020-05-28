<?php
    error_reporting(E_ALL);
	
	if( $_GET["volume"] 
	{
    $f = fopen('volume.wcx', 'w+') or die ("Failed");
	$data = ($_GET['volume']);
    fwrite($f, $data);
    echo "VOL OK";
    fclose($f);
	}
	
    if( $_GET["mute"] 
	{
    $f = fopen('mute.wcx', 'w+') or die ("Failed");
	$data = ($_GET['mute']);
    fwrite($f, $data);
    echo "MUTE OK";
    fclose($f);
	}
	
	if( $_GET["station"] 
	{
    $f = fopen('station.wcx', 'w+') or die ("Failed");
	$data = ($_GET['station']);
    fwrite($f, $data);
    echo "ST OK";
    fclose($f);
	}

	if( $_GET["playback"] 
	{
    $f = fopen('playback.wcx', 'w+') or die ("Failed");
	$data = ($_GET['playback']);
    fwrite($f, $data);
    echo "PB OK";
    fclose($f);
	}
?>
