<?php
$myfile = fopen("comms/volume.rxc", "r") or die("Unable to open file!");
echo fgets($myfile);
fclose($myfile);
?>