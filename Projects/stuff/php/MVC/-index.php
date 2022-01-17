<?php

session_start();

require_once 'dolgozo.php';
$dolgozok = $manager->dolgozok(isset($_SESSION["id"]) ? $_SESSION['id'] : -1);

?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
        <style>
            body {
                display: flex;
                text-align: center;
                align-items: center;
                flex-direction: column;
            }
            table{
                width: 100%;
                text-align:left;
            }
            td {
            padding-right:100px;
            }
            #container {
                font-size: 25px;
                position: absolute;
                top: 50%;
                left: 50%;
                margin-right: -50%;
                transform: translate(-50%, -50%);
            }
            span {
                font-weight: bold; 
                font-size: 30px;
                text-shadow: 2px 2px 8px #6E6563;
            }
            .nav {
                padding-top: 8%;
            }
        </style>
        <title></title>
    </head>
    <body>
        <div class="nav">
<?php
if($manager->loggedIn())
{
?>
        <span><?php echo $_SESSION["name"] ?></span>
        <a href="logout.php" class="btn btn-danger ml-3">Kijelentkezés</a>
        <a href="insert.php" class="btn btn-warning ml-3">Felvitel</a>
<?php    
}
else
{
?>
        <a href="login.php" class="btn btn-danger ml-3" style="margin-top:10%">Bejelentkezés</a>
<?php    
}
?>
        </div>
        
        <div id="container">
        <table>
            <thead><tr><th>Email</th><th>Név</th><th>Beosztás</th></tr></thead>
            <tbody>
<?php
foreach($dolgozok as $d)
{
?>
                <tr>
                    <td style="padding-left: <?php echo $d->szint * 50?>px;">
<?php
    if(!empty($d->kep))
    {
?>
                        <a href="<?php echo $d->kep;?>" target="_blank"><image src="<?php echo $d->kep?>" width="30px" height="30px"/></a>
<?php
    }
    echo $d->email
?>
                    </td>
                    <td><?php echo $d->nev ?></td>
                    <td><?php echo $d->beosztas ?></td>
<?php
    if($d->torolheto)
    {
?>
                    <td><a href="edit.php?id=<?php echo $d->azonosito?>"><img src="images/edit.png"  title="Szerkesztés"/></a>
                    <a href="delete.php?id=<?php echo $d->azonosito?>"><img src="images/delete.png" title="Törlés" /></a></td>
<?php        
    }
?>
                </tr>
<?php        
}
?>
            </tbody>
        </table>
      </div>
    </body>
</html>
