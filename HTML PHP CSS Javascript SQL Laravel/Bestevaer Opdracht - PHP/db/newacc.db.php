<?php

$naam = $_POST["Gnaam"];
$wachtwoord = $_POST["w8w00rd"];
$radio = $_POST["radio"];

include_once "password.db.php";

$sql = "INSERT INTO users (username, password, Mwerker) VALUES (:username, :password, :mwerker)";

$params = array(":username" => $naam, ":password" => $wachtwoord, ":mwerker" => $radio);

$sth = $db->prepare($sql);
$sth->execute($params);

header("location: ../login.php");