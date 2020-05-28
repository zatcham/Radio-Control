<?php
$myfile = fopen("comms/mute.rxc", "r") or die("Unable to open file!");
echo fgets($myfile);
fclose($myfile);
?>