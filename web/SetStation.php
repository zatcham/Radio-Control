<?php
$data = ($_GET['value']);
$myfile = fopen("comms/station.txc", "w") or die("Unable to open file!");
fwrite($myfile, $data);
fclose($myfile);
echo "STATION OK";
?>