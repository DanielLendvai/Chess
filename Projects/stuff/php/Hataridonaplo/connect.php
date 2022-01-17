<?php

$db = new mysqli("localhost", "root", "", "hataridonaplo");
if(!$db)
    die("ERROR: Could not connect. " . mysqli_connect_error());

if($db->connect_errno)
    die("Failed to connect to MySQL:" . $db->connect_error);

?>
