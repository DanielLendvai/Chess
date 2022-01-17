<?php

// Initialize the session
session_start();
require_once 'connect.php'; 

// Check if the user is already logged in, if yes then redirect him to welcome page
if(isset($_SESSION["user"]))
{
    header("location: index.php");
    exit;
}
 
// Processing form data when form is submitted
if(isset($_POST["ok"]))
{
    /// TODO: login
    
    $_SESSION["user"] = $_POST["email"];
    header("location: index.php");
    return;
}
?>
 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Login</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <style>
        body{ font: 14px sans-serif; }
        .wrapper{ width: 360px; padding: 20px; }
    </style>
</head>
<body>
    <h2>Bejelentkezés</h2>
    <p>Kérem, töltse ki a bejelentkezési adatait.</p>

    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
        <div class="form-group">
            <label>Email</label>
            <input type="email" name="email">
        </div>
        <div class="form-group">
            <label>Jelszó</label>
            <input type="password" name="password">
        </div>
        <div class="form-group">
            <input type="submit" name="ok" class="btn btn-primary" value="Bejelentkezés">
        </div>
    </form>
        
</body>
</html>
