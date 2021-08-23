<?php

include_once "db/password.db.php";

$naam = "joeri";
$wachtwoord = "smit";

$sql = "SELECT * FROM users WHERE username=:username AND password=:password";

$params = array(":username" => $naam, "password" => $wachtwoord);

$sth = $db->prepare($sql);
$sth->execute($params);

while($row = $sth->fetch()) {
    $ding1 = $row["username"];
    $pass = $row["password"];
    $worker = $row["Mwerker"];

    session_start();
    $_SESSION['worker'] = $worker;
    $_SESSION['naam'] = $ding1;
}

print_r($sth);