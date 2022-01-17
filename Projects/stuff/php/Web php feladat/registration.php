<?php
//registration.php
$nev = $_POST['nev'];
$email = $_POST['email'];
$tel = $_POST['tel'];
$jelszo = $_POST['jelszo'];
$jelszo2 = $_POST['jelszo2'];

		
		if( $jelszo != $jelszo2) 
		{
			header("Location: index.php?err=jelszo");
		}	
		else
		{
			$jelszo_hash = sha1($jelszo);
			
			$Con = new mysqli("localhost", "root", "", "ve");
			
			if($Con->connect_error)
				die("Hiba az adatbázishoz csatlakozás közben");
			
			$Con->set_charset("utf8");
		
			$sql = "INSERT INTO felhasznalok(nev, email, telefon, jelszo)
					VALUES('$nev', '$email', '$tel', '$jelszo_hash');";
					
			$result = $Con->query($sql);
		
			if($result)
				header("Location: index.php?reg=ok");				
			else
				header("Location: index.php?reg=err");
		}

?>