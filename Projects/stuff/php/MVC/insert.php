<?php

session_start();
require_once "dolgozo.php";

if(!$manager->loggedIn())
{
    header("location: login.php");
    exit;
}

$email_err = $nev_err = $jelszo_err = $beosztas_err = $insert_err = "";

if($_SERVER["REQUEST_METHOD"] == "POST")
{
    if(!isset($_POST["ok"]))
    {
        header("location: index.php");
        exit();
    }
    
    $dolgozo = new Dolgozo();
    $dolgozo->fonok = $manager->userid();
    
    if(empty(trim($_POST["email"])))
        $email_err = "Adja meg az email címét!";
    else
        $dolgozo->email = trim($_POST["email"]);
    
    if(empty(trim($_POST["nev"])))
        $nev_err = "Adja meg a dolgozó nevét!";
    else
        $dolgozo->nev = trim($_POST["nev"]);

    if(empty(trim($_POST["jelszo"])))
        $jelszo_err = "Adja meg a dolgozó jelszavát!";
    else
        $dolgozo->jelszo = trim($_POST["jelszo"]);

    if(empty(trim($_POST["beosztas"])))
        $beosztas_err = "Adja meg a dolgozó beosztását!";
    else
        $dolgozo->beosztas = trim($_POST["beosztas"]);

    if(empty($email_err) && empty($nev_err) && empty($jelszo_err) && empty($beosztas_err))
    {
        $manager->felvitel($dolgozo);
        header("location: index.php");
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Új dolgozó felvitele</title>
        <style>
            body { 
            font: 14px sans-serif; 
            display:flex;
            padding-left: 20px;
            }
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
            h2 {
                padding-left: 5px;
            }
        </style>
    </head>
<body>
    <div class="wrapper">
        <h2>Új dolgozó felvitele</h2>
<?php 
if(!empty($insert_err))
    echo '<div class="alert alert-danger">' . $insert_err . '</div>';
?>      
        <fieldset style="display:inline-block">
            <legend>Kérem, töltse ki a bejelentkezési adatokat.</legend>
        <div class="frm">
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <table>
                <tr>
                <td class="lbl"><label for="email">Email</label></td>
                <td><input type="email" id="email" name="email" class="form-control" <?php echo (!empty($email_err)) ? 'is-invalid' : ''; ?>"></td>
                <span class="invalid-feedback"><?php echo $email_err; ?></span>
                </tr>
            </table>    
            <table>
                <tr>
                <td class="lbl"><label for="text">Név</label></td>
                <td><input type="text" id="text" name="nev" class="form-control <?php echo (!empty($nev_err)) ? 'is-invalid' : ''; ?>"></td>
                <span class="invalid-feedback"><?php echo $nev_err; ?></span>
                </tr>
            </table>
            <table>
                <tr>
                <td class="lbl"><label for="password">Jelszó</label></td>
                <td><input type="password" id="password" name="jelszo" class="form-control <?php echo (!empty($jelszo_err)) ? 'is-invalid' : ''; ?>"></td>
                <span class="invalid-feedback"><?php echo $jelszo_err; ?></span>
                </tr>
            </table>
            <table>
                <tr>
                <td class="lbl"><label for="beosztas">Beosztás</label></td>
                <td><input type="text" id="beosztas" name="beosztas" class="form-control <?php echo (!empty($beosztas_err)) ? 'is-invalid' : ''; ?>"></td>
                <span class="invalid-feedback"><?php echo $beosztas_err; ?></span>
                </tr>
            </table>    
            <div class="form-group" style="padding:5px">
                <input type="submit" name="ok" class="btn btn-primary" value="Felvesz">
                <input type="submit" name="cancel" class="btn btn-secondary" value="Mégse">
            </div>
        </form>         
    </div>
        </fieldset>
    </div>
   </body>
</html>
