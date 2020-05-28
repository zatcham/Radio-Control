<?php
$vol = ($_GET['volume']);
$mute = ($_GET['mute']);

if(!empty($_GET['volume'])){
	$volfile = fopen("comms/volume.txc", "w") or die("Unable to open file!");
	fwrite($volfile, $volume);
	fclose($volfile);
	echo "VOL OK \r\n {$vol}";
}

if (!empty($_GET['mute'])){
	$mutefile = fopen("comms/mute.txc", "w") or die("Unable to open file!");
	fwrite($mutefile, $mute);
	fclose($mutefile);
	echo "MUTE OK \r\n {$mute}";
}
?>