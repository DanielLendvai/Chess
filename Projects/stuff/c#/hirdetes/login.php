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
    $userid = $_POST["userid"];
    $rset = $db->query("SELECT id, name, password, admin FROM users WHERE userid = '$userid'");
    $row = mysqli_fetch_assoc($rset);
    if($row && md5($_POST['password']) == $row['password'])
    {
        $_SESSION["id"] = $row['id'];
        $_SESSION["user"] = $userid;
        $_SESSION["name"] = $row["name"];
        $_SESSION["admin"] = $row['admin'];
        header("location: index.php");
        return;
    }
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

    <form method="post">
        <div class="form-group">
            <label>Azonosító</label>
            <input name="userid">
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
