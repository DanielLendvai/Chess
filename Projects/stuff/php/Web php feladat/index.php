<!DOCTYPE HTML>
<html>
<head>
<link href="style.css" rel="stylesheet" />
<title>Regisztrációs oldal</title>
</head>
<body>
<div id="container">
<h1>Regisztráció</h1>	
	<form action="registration.php" method="POST">
		Név: <input type="text" name="nev" required /><br>
		Email: <input type="email" name="email" required /><br>
		Telefonszám: <input type="text" name="tel" /><br>
		Jelszó: <input type="password" name="jelszo" /><br>
		Jelszó újra: <input type="password" name="jelszo2" /><br>
		<input type="submit" value="Regisztráció" />
	</form>

<?php
	if(isset($_GET['err']) && $_GET['err']=="jelszo") 
		{
				echo "<h2>Nem egyezik a két jelszó!</h2>";
		}
	else if(isset($_GET['reg']) && $_GET['reg']=="ok") 
		{
				echo "<h2>Sikeres regisztráció!</h2>";
		}
	else if(isset($_GET['reg']) && $_GET['reg']=="err") 
		{
				echo "<h2>Sikertelen regisztráció, egyéb hiba.</h2>";
		}	
?>

</div>
</body>
</html>