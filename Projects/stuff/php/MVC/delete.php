<?php
    session_start();
    require_once "dolgozo.php";
    
    $delete_err = "";
    if($_SERVER["REQUEST_METHOD"] == "POST")
    {
        if(isset($_POST["yes"]))
            $manager->torles(trim($_POST["id"]));
        header("location: index.php");
        exit();
    }

    $dolgozo = $manager->dolgozo(trim($_GET["id"]));
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Dolgozó törlése</title>
        <style>
            body {
               display: flex;
               flex-direction: column;
               width:fit-content;
               text-align: center;
               font-size: 18px;
            }
            .form-group{
                padding: 2px;
            }
            input {
                width: fit-content;
            }
        </style>
    </head>
    <body>
<?php 
if(!empty($delete_err))
    echo '<div class="alert alert-danger">' . $delete_err . '</div>';
?>
        <fieldset>
            <legend>Dolgozó törlése</legend>
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
        <div class="form-group">
            <p>Biztos benne, hogy törli <b><?php echo $dolgozo->nev; ?></b> nevű munkatársat?</p>
        </div>
        <input type="hidden" name="id" value="<?php echo $dolgozo->azonosito; ?>" />
        <div class="form-group">
            <input type="submit" name="yes" class="btn btn-primary" value="Igen">
            <input type="submit" name="no" class="btn btn-primary" value="Nem">
        </div>
        </form>
        </fieldset>
    </body>
</html>
