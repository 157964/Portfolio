<?php


include_once "list/boten.php";
$maxship = $Cmax;

for($i = 1; $i <= $maxship; $i++) {
    $entry = "boot$i";
    $css = '';
    $picture = 'images/' . $boten[$entry]['pic'];

    if ($i % 2 == 0) {
      $css = 'Ceven';
    }
    else {
        $css = 'Cuneven';
    }
    ?>

    <div id=' <?php echo $entry ?>' class="inflex <?php echo $css ?>" onclick="clicky(<?php echo $boten[$entry]['c']?>)">
        <div class="shared Iitem">
            <h2> <?php echo $boten[$entry]['naam']; ?> </h2>
            <p>Roepnummer: <?php echo $boten[$entry]['roepnummer'] ?></p>
            <p>Max lading in zeecontainers: <?php echo $boten[$entry]['TEU'] ?> TEU</p>
            <p>Algemene afmetingen: <br> <?php echo $boten[$entry]['lengte']?> m lang, <?php echo $boten[$entry]['breedte']?> m breed, diepgang: <?php echo $boten[$entry]['diepgang']?> m</p>
        </div>
        <div class="shared">
            <img src="<?php echo $picture ?>" alt="boot <?php echo $boten[$entry]['naam']?> foto" class="pictures">
        </div>
    </div>

    <?php
}
?>