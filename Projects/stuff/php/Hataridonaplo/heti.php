<?php
    session_start();
    require_once "connect.php";
    
    if(!isset($_SESSION["user"]))
    {
        header("location: login.php");
        return;
    }
    
// Ha GET a kérés és van benne "delete" mező    
if(isset($_GET["delete"]))
{
    // A "delete" mezőben van a törlendő azonosítója
    $id = $_GET["delete"];
    // Törlés MySql-ben
    if(!mysqli_query($db, "DELETE FROM heti WHERE id=" . $id))
    {
        echo "Error: " . db . "<br>" . mysqli_error($conn);
    }
}

// Ha POST és megnyomták az "ok" nevű gombot
if(isset($_POST["ok"]))
{
    // Beszúrom a POST adatokat
    if(!mysqli_query($db, 
            "INSERT INTO heti (datum, nap, elfoglaltsag) " .
            "VALUES (" .
            "\"" . $_POST['datum'] . "\", " .
            $_POST["nap"] . ", " .
            "\"" . $_POST["elfoglaltsag"] . "\""
            . ")"
    ))
    {
        echo "Error: " . $db . "<br>" . mysqli_error($conn);
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
        <style>
            .container {
                display: inline-block;                
            }
            table {
                margin-right: 5px;
                border: 1px solid grey;
                margin-bottom: 10px;
            }
        </style>
        <title></title>
    </head>
    <body>

       
<!-- Itt indul a táblázat-->
        <table>
            <thead><tr><th>Dátum</th><th>Nap</th><th>Elfoglaltság</th></tr></thead>
            <tbody>
                
<!-- Itt indul a táblázat PHP kiírása-->
<?php
// A sorok leválogatása
$rset = $db->query("SELECT id, datum, nap, elfoglaltsag FROM heti ORDER BY datum, nap");
if($rset)
    while($row = mysqli_fetch_assoc($rset))
    {
        // beszúrás a táblázatba
?>
                <tr>
                    <td><?php echo $row["datum"]?></td>
                    <td><?php echo $row["nap"]?></td>
                    <td><?php echo $row["elfoglaltsag"]?></td>
                    <td><a href="heti.php?delete=<?php echo $row["id"]?>"><img src="images/delete.png" title="Törlés" /></a></td>
                </tr>
<?php        
    }
    // a lekérdezés adatainak felszabadítása
    $rset->free_result();
?>
            </tbody>
        </table>
        
<!-- A form -->
        <div class ="container">
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <div class="form-group">
                <label>Dátum</label>
                <input type="date" name="datum">
            </div>    
            <div class="form-group">
                <label>Nap</label>
                <select name="nap">
                    <option value="1">Hétfő</option>
                    <option value="2">Kedd</option>
                    <option value="3">Szerda</option>
                    <option value="4">Csütörtök</option>
                    <option value="5">Péntek</option>
                    <option value="6">Szombat</option>
                    <option value="7">Vasárnap</option>
                </select>
            </div>    
            <div class="form-group">
                <label>Elfoglaltság</label>
                <input name="elfoglaltsag">
            </div>    
            <div class="form-group">
                <input type="submit" name="ok" class="btn btn-primary" value="Felvisz">
            </div>
            <a href="napi.php">Napi</a>
        </form>
        </div>
        
    </body>
</html>
