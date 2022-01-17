<!DOCTYPE html>
<?php
    session_start();
    require_once 'connect.php'; 
    
    if(isset($_GET["logout"]))
    {
        $_SESSION = array();
        session_destroy();
    }
    
    if(isset($_GET["delete"]))
    {
        $id = $_GET["delete"];
        mysqli_query($db, "DELETE FROM hirdetes WHERE id = $id");
    }

    if(!isset($_SESSION["user"]))
    {
        header("location: login.php");
        return;
    }

    $id = $_SESSION["id"];
    $admin = isset($_SESSION["admin"]) && $_SESSION["admin"] == 1;

    if(isset($_GET["licit"]))
    {
        $hirdetes = $_GET["id"];
        $licit = $_GET["licit"];
        mysqli_query($db, "INSERT INTO licitek (hirdetes, datum, licit, user) VALUES ( $hirdetes, current_timestamp, $licit, $id)");
    }
    
    if(isset($_POST["szoveg"]))
    {
        $szoveg = $_POST["szoveg"];
        mysqli_query($db, "INSERT INTO hirdetes (szoveg, userid) VALUES ('$szoveg', '$id')");
    }
    
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style></style>
    </head>
    <body>
        <a href="index.php?logout">Kijelentkezés</a>
        <form style="margin: 10px;" method="post">
                <label>Hirdetés</label>
                <input name="szoveg">
                <input type="submit" name="ok" class="btn btn-primary" value="Meghírdet">
            </form>
            
            <table border="1">
                <thead><th>Szöveg</th><th>Hirdető</th><th>Licit</th></thead>
                <tbody>
<?php
// A sorok leválogatása
$rset = $db->query(
"SELECT h.id, MIN(h.szoveg) AS szoveg, MIN(h.userid) AS userid, MIN(u.name) AS name, MAX(l.licit) AS licit" .
"	FROM hirdetes AS h" .
"         JOIN users as u ON u.id = h.userid" .
"         LEFT OUTER JOIN licitek AS l ON l.hirdetes = h.id" .
"	GROUP BY h.id" .
"    ORDER BY h.id, licit"
);
if($rset)
    while($row = mysqli_fetch_assoc($rset))
    {
        // beszúrás a táblázatba
?>
                <tr>
                    <td><?php echo $row["szoveg"]?></td>
                    <td><?php echo $row["name"]?></td>
                    <td><?php echo $row["licit"]?><button style="margin-left: 5px;" onclick="myFunction(<?php echo $row['id']?>, <?php echo $row['licit']?>)">Licit</button></td>
<?php                    
        if($admin)
        {
?>        
                    <td><a href="index.php?delete=<?php echo $row["id"]?>">Törlés</a></td>
<?php                    
        }
?>        
                </tr>
<?php        
    }
    // a lekérdezés adatainak felszabadítása
    $rset->free_result();
?>
                </tbody>
            </table>
        </div>
<script>
function myFunction(id, licit) {
  var licit2 = parseFloat(prompt("Adja meg a licitet!", licit));
  if(!isNaN(licit2) && (!licit || licit2 > licit)) {
    window.location.href = "index.php?id=" + id + "&licit=" + licit2;
  }
}
</script>        
    </body>
</html>
