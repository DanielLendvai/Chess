<?php
$nev = $_POST['nev'];
$jelszo = $_POST['jelszo'];
$jelszo_hash = sha1($jelszo);

$Con = new mysqli("localhost", "root", "", "ve");
			
	if($Con->connect_error)
		die("Hiba az adatbázishoz csatlakozás közben");
			
$Con->set_charset("utf8");

$sql = "SELECT nev
		FROM felhasznalok
		WHERE 
			nev LIKE '$nev'
			AND
			jelszo LIKE '$jelszo_hash'
			AND
			statusz = 2;";
$result = $Con->query($sql);
if($result->num_rows == 0) 
{
		header("Location: admin.php?err=login");
}
else 
{
		session_start();
		$_SESSION['user'] = $nev;
		header("Location: admin.php");
}


?>