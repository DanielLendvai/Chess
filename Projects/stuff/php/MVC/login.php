<?php

// Initialize the session
session_start();
require_once 'dolgozo.php'; 

// Check if the user is already logged in, if yes then redirect him to welcome page
if($manager->loggedIn())
{
    header("location: index.php");
    exit;
}
 
// Define variables and initialize with empty values
$email = $password = "";
$email_err = $password_err = $login_err = "";
 
// Processing form data when form is submitted
if($_SERVER["REQUEST_METHOD"] == "POST")
{
    if(!isset($_POST["ok"]))
    {
        header("location: index.php");
        exit();
    }
    
    // Check if username is empty
    if(empty(trim($_POST["email"])))
        $email_err = "Adja meg az email címét!";
    else
        $email = trim($_POST["email"]);
    
    // Check if password is empty
    if(empty(trim($_POST["password"])))
        $password_err = "Adja meg a jelszavát!";
    else
        $password = trim($_POST["password"]);
    
    // Validate credentials
    if(empty($email_err) && empty($password_err))
    {
        if($manager->login($email, $password))
            header("location: index.php");
        else
            $login_err = "Érvénytelen email cím, vagy jelszó.";
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
    <div class="wrapper">
        <h2>Bejelentkezés</h2>
        <p>Kérem, töltse ki a bejelentkezési adatait.</p>

<?php 
if(!empty($login_err))
    echo '<div class="alert alert-danger">' . $login_err . '</div>';
?>

        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <div class="form-group">
                <label>Email</label>
                <input type="email" name="email" class="form-control <?php echo (!empty($email_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $email; ?>">
                <span class="invalid-feedback"><?php echo $email_err; ?></span>
            </div>    
            <div class="form-group">
                <label>Jelszó</label>
                <input type="password" name="password" class="form-control <?php echo (!empty($password_err)) ? 'is-invalid' : ''; ?>">
                <span class="invalid-feedback"><?php echo $password_err; ?></span>
            </div>
            <div class="form-group">
                <input type="submit" name="ok" class="btn btn-primary" value="Bejelentkezés">
                <input type="submit" name="cancel" class="btn btn-secondary" value="Mégse">
            </div>
        </form>
    </div>
</body>
</html>