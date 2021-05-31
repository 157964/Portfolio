<?php
session_start();

$naam = $_POST["Gnaam"];
$wachtwoord = $_POST["w8w00rd"];

include_once "password.db.php";

$sql = "SELECT * FROM users WHERE username=:username AND password=:password";

$params = array(":username" => $naam, "password" => $wachtwoord);

$sth = $db->prepare($sql);
$sth->execute($params);

while($row = $sth->fetch()) {
    $ding1 = $row["username"];
    $pass = $row["password"];
    $worker = $row["Mwerker"];

    $_SESSION['worker'] = $worker;
    $_SESSION['ID'] = $ding1;

    echo $ding1 . " " . $pass . " " . $worker;
}

header("location: ../botenlijst.php");