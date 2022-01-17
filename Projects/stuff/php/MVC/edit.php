<?php

session_start();
require_once "dolgozo.php";

if(!$manager->loggedIn())
{
    header("location: login.php");
    exit;
}

$email_err = $nev_err = $jelszo_err = $beosztas_err = $kep_err = $oneletrajz_err = $edit_err = "";
$dolgozo = null;

if($_SERVER["REQUEST_METHOD"] == "POST")
{
    if(!isset($_POST["ok"]))
    {
        header("location: index.php");
        exit();
    }
    $dolgozo = new Dolgozo();
    $dolgozo->azonosito = trim($_POST["id"]);
    $dolgozo->jelszo = trim($_POST["jelszo"]);

    if(empty(trim($_POST["email"])))
        $email_err = "Adja meg az email címét!";
    else
        $dolgozo->email = trim($_POST["email"]);
    
    if(empty(trim($_POST["nev"])))
        $nev_err = "Adja meg a dolgozó nevét!";
    else
        $dolgozo->nev = trim($_POST["nev"]);

    if(empty(trim($_POST["beosztas"])))
        $beosztas_err = "Adja meg a dolgozó beosztását!";
    else
        $dolgozo->beosztas = trim($_POST["beosztas"]);

    $kepfn = $_FILES['kep']['name'];
    if(!empty($kepfn))
    {
        $ext = pathinfo($kepfn, PATHINFO_EXTENSION);
        $dolgozo->kep = "./images/" . $dolgozo->azonosito . "." . $ext;
        move_uploaded_file($_FILES['kep']['tmp_name'], $dolgozo->kep);
    }

    $oneletrajzfn = $_FILES['oneletrajz']['name'];
    if(!empty($oneletrajzfn))
    {
        $ext = pathinfo($oneletrajzfn, PATHINFO_EXTENSION);
        $dolgozo->oneletrajz = "./oneletrajzok/" . $dolgozo->azonosito . "." . $ext;
        move_uploaded_file($_FILES['oneletrajz']['tmp_name'], $dolgozo->oneletrajz);
    }

    if(empty($email_err) && empty($nev_err) && empty($beosztas_err))
    {
        $manager->modositas($dolgozo);
        header("location: index.php");
    }
}
else
    $dolgozo = $manager->dolgozo(trim($_GET["id"]));
?>

<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title>Dolgozó módosítása</title>
        <style>
            body{ font: 14px sans-serif; }
            .wrapper{ width: 360px; padding-left: 5px; }
            .form-control {
                width: 100%;
            }
            .frm {
                display: inline-block;
                margin-left: 0;
            }
            .lbl {  
                text-align: center;
                width: 60px;
                white-space: nowrap;
            }
        </style>
    </head>
<body>
    <div class="wrapper">
        <h2>Dolgozó módosítása</h2>
<?php 
if(!empty($edit_err))
    echo '<div class="alert alert-danger">' . $edit_err . '</div>';
?>
        
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" enctype="multipart/form-data">
            <fieldset>
                <legend>Kérem, töltse ki az adatokat.</legend>
            <table>
            <tr>
                    <td class="lbl"><label>Email</label></td>
                    <td><input type="email" name="email" class="form-control <?php echo (!empty($email_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $dolgozo->email?>" ></td>
                    <span class="invalid-feedback"><?php echo $email_err; ?></span>
            </tr>   
            <tr>
                <td class="lbl"><label>Név</label></td>
                <td><input type="text" name="nev" class="form-control <?php echo (!empty($nev_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $dolgozo->nev?>"></td>
                <span class="invalid-feedback"><?php echo $nev_err; ?></span>
            </tr>   
            <tr>
                <td class="lbl"><label>Jelszó</label></td>
                <td><input type="password" name="jelszo" class="form-control <?php echo (!empty($jelszo_err)) ? 'is-invalid' : ''; ?>"></td>
                <span class="invalid-feedback"><?php echo $jelszo_err; ?></span>
            </tr>
            <tr>
                <td class="lbl"><label>Beosztás</label></td>
                <td><input type="text" name="beosztas" class="form-control <?php echo (!empty($beosztas_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $dolgozo->beosztas?>" ></td>
                <span class="invalid-feedback"><?php echo $beosztas_err; ?></span>
            </tr>
            <tr>
                <td class="lbl"><label>Kép</label></td>
                <td>
<?php
                if(!empty($dolgozo->kep))
                {
?>
                    <a href="<?php echo $dolgozo->kep;?>" target="_blank"><img src="<?php echo $dolgozo->kep;?>" width="30px" height="30px" /></a>
<?php
                }
?>
                    <input type="file" name="kep" value="<?php echo $dolgozo->kep?>" >
                </td>
                <span class="invalid-feedback"><?php echo $kep_err; ?></span>
            </tr>
            <tr>
                <td class="lbl"><label>Önéletrajz</label></td>
                <td>
                    <input type="file" name="oneletrajz" value="<?php echo $dolgozo->oneletrajz?>" >
<?php
                if(!empty($dolgozo->oneletrajz))
                {
?>
                <a href="<?php echo $dolgozo->oneletrajz;?>" target="_blank">Letöltés</a>
<?php
                }
?>
                </td>
                <span class="invalid-feedback"><?php echo $oneletrajz_err; ?></span>
            </tr>
            <tr>
                <td><input type="hidden" name="id" value="<?php echo $dolgozo->azonosito; ?>" /><input type="submit" name="ok" class="btn btn-primary" value="Módosít"></td>
                <td><input type="submit" name="cancel" class="btn btn-secondary" value="Mégse"></td>
            </tr>
            </table>
            </fieldset>
        </form>
                
    </div>

   </body>
</html>
