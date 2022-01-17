<?php

session_start();

require_once '../dolgozo.php';
$dolgozok = $manager->dolgozok(isset($_SESSION["id"]) ? $_SESSION['id'] : -1);
echo json_encode($dolgozok);

?>
