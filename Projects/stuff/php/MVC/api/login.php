<?php

session_start();
require_once '../dolgozo.php'; 

if(!$manager->loggedIn())
{	
	$args = json_decode(file_get_contents('php://input'), true);
	$manager->login($args->uid, $args->pwd);
}
echo json_encode($manager->dolgozo($manager->userid()));
