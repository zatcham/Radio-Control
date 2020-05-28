<?php
$myfile = fopen("comms/playback.rxc", "r") or die("Unable to open file!");
echo fgets($myfile);
fclose($myfile);
?>