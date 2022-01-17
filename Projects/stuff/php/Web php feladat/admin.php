<?php
	session_start();
?>

<!DOCTYPE HTML>
<html>
<head>
<link href="style.css" rel="stylesheet" />
<title>Admin oldal</title>
</head>
<body>
	<?php
	if(isset($_SESSION['user']) )
	{
	$Con = new mysqli("localhost", "root", "", "ve");		
	if($Con->connect_error)
		die("Hiba az adatbázishoz csatlakozás közben");
			
	$Con->set_charset("utf8");
	$sql = "SELECT * FROM felhasznalok";
	$result = $Con->query($sql);
	$output = "";
	while($row=$result->fetch_assoc())
	{
		$nev = $row['nev'];
		$output .= "<form>";
			$output .= $nev . ": ";
			$output .= "<select name='statusz'>";
				$output .= "<option value='0'>0</option>";
				$output .= "<option value='1'>1</option>";
				$output .= "<option value='2'>2</option>";
			$output .= "<select>";
			$output .= "<input type='hidden' name='nev' value='$nev' />";
			$output .= "<input type='submit' value='Mentés' />";
		$output .= "</form>";
	}
	echo $output;
	}
	else
	{
	?>
<div id="container">
<h1>Belépés</h1>	
	<form action="login.php" method="POST">
		Név: <input type="text" name="nev" required /><br>
		Jelszó: <input type="password" name="jelszo" /><br>
		<input type="submit" value="Belépés" />
	</form>
	<?php
	if(isset($_GET['err']) && $_GET['err']=="login" )
	{
		echo "<h2>Rossz felhasználó név vagy jelszó.<br>Vagy nem megfelelő a jogosultsági szint.</h2>";
	}
	?>
	</div>
	<?php } ?>
</body>
</html>