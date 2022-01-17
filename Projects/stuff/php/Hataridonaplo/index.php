<!DOCTYPE html>
<?php
    session_start();
    
    if(isset($_POST["logout"]))
    {
        $_SESSION = array();
        session_destroy();
    }
    
    if(!isset($_SESSION["user"]))
    {
        header("location: login.php");
        return;
    }
    
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <style>
    a {
      font: bold 11px Arial;
      text-decoration: none;
      background-color: #EEEEEE;
      color: #333333;
      padding: 6px 10px 6px 10px;
      border-top: 1px solid #CCCCCC;
      border-right: 1px solid #333333;
      border-bottom: 1px solid #333333;
      border-left: 1px solid #CCCCCC;
      }
      input {
          margin-top: 15px;
      }
        </style>
    </head>
    <body>
            <a href="napi.php">Napi</a>
            <a href="heti.php">Heti</a>            
            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <input type="submit" name="logout" value="Kilépés">
            </form>
        <?php
        
        ?>
    </body>
</html>
