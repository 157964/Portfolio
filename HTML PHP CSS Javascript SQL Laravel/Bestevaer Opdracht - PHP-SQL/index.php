<?php

//redir naar botenlijst.php, dit heb ik gedaan omdat hierdoor ik later nog kan aanpassen wat de 1e pagina is van de website
header("location: botenlijst.php");
session_start();
$_SESSION['ID'] = NULL;
$_SESSION['worker'] = NULL;
die();