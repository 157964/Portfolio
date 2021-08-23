<div id="form">
        <form action="">

            <div class="blockcalc">
                <div class="input_thing"> 
                    <select name="Fboat" id="Fboat" onchange="calc()">
                        <option value="0">Kies een boot:</option>
                        <?php 
                        $maxship = $Cmax;
                        for($i = 1; $i <= $maxship; $i++) {
                            $entry = "boot$i";
                            ?>
                            <option value='<?php echo $boten[$entry]['c'] ?>'><?php echo $boten[$entry]['naam'] ?></option>;
                            <?php
                        }  
                            ?>
                    </select>
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <input type="number" name="Famount" id="Famount" placeholder="Begin inhoud in tonnen:" onchange="calc()">
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <input type="number" name="Fextra" id="Fextra" placeholder="Extra lading:" onchange="calc()"> 
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <select name="Fseason" id="Fseason" onchange="calc()">
                        <option value="nothing">Seizoen:</option>
                        <option value="L">Lente</option>
                        <option value="Z">Zomer</option>
                        <option value="H">Herfst</option>
                        <option value="W">Winter</option>
                    </select>
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <select name="Fwater" id="Fwater" onchange="calc()">
                        <option value="">Water:</option>
                        <option value="Salt">Zout</option>
                        <option value="Sweet">Zoet</option>
                        <option value="Both">Zout & Zoet</option>
                    </select>
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing" onchange="calc()">
                    <label for="">Resultaat:</label>
                    <label id="Result" for=""></label>
                </div>
            </div>

        </form>
</div>

    <div class="formpic">
        <img class="picinform" id="boatpic" src="images/tempimg.jpg" alt="pic">
    </div>