<?php
$input = ($_GET['playback']);

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
?>