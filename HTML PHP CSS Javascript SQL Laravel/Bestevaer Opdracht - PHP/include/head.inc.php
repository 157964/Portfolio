<!DOCTYPE html>
<html lang="en">
<head>
    <?php session_start(); ?>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php echo $documentName ?></title>
    <link rel="stylesheet" href="stylesheet/style.css">
    <link rel="icon" href="images/webicon.png" sizes="32x32" type="image/png">
    <script defer type="text/javascript" src="java/java.js"></script>
</head>
<body <?php if($documentName == "Bestevaer - calculator") { ?>
    onload="transition()"
<?php } ?>>
<?php include_once "menu.inc.php"; ?>