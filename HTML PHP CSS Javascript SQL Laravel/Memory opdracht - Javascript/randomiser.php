<?php

/*
$host = 'localhost';
$dbname = 'memory';
$username = 'root';
$password = '';

$connectStr = 'mysql:host=' . $host . ';dbname=' . $dbname . ';charset=utf8';
$db = new PDO($connectStr, $username, $password);
$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
*/

// 16 cards 8 figures

// all pics
$picarr = array('black_hat.png', 'black_no_hat.png', 'blue_hat.png', 'blue_no_hat.png', 'green_hat.png', 'green_no_hat.png', 'red_hat.png', 'red_no_hat.png');

// get random picture and assign it to random number
$assignArr = array();

// while there are less then 16 values in the array
while(count($assignArr) != 16) {

    // grab random pic from $picarr
    $randPicNumb = rand(0, 7);
    $randPic = $picarr[$randPicNumb];

    //checks if said picture already appears in array
    if(getCount($assignArr, $randPic) < 2) {
        array_push($assignArr, $randPic);
    }
}

// count how many times a value appears in an array
function getCount($arr, $key) {
    $indexes = array_keys($arr, $key); //array(0, 1)
    return count($indexes);
}

$assignArr = json_encode($assignArr);
echo $assignArr;