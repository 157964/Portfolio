<div id="sneakycontent">
    <?php 
    include_once "include/list/boten.php";

    for($i = 1; $i <= $Cmax; $i++) {
    $entity = "boot$i";
    ?>

    <div id="<?php echo $entity?>"> 
        <p id="naam<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["naam"]?></p>
        <p id="pic<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["pic"]?></p>
        <p id="roepnummer<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["roepnummer"]?></p>
        <p id="TEU<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["TEU"]?></p>
        <p id="DWT<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["DWT"]?></p>
        <p id="lengte<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["lengte"]?></p>
        <p id="breedte<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["breedte"]?></p>
        <p id="diepgang<?php echo $boten[$entity]["c"] ?>"><?php echo $boten[$entity]["diepgang"]?></p>
        
    </div>


    <?php
    }

    ?>
</div>