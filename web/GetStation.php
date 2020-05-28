<?php
$myfile = fopen("comms/station.rxc", "r") or die("Unable to open file!");
echo fgets($myfile);
fclose($myfile);
?>