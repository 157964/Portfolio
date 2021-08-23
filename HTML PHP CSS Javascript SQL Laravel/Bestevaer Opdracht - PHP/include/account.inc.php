    <div id="form">
        <form id="form-action" action="db/login.db.php" method="post">

            <div class="blockcalc">
                <div class="input_thing">
                    <label for="" id="loginname">Login:</label>
                    <label id="Result" for=""></label>
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <input type="text" name="Gnaam" placeholder="gebruikersnaam">
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <input type="password" name="w8w00rd" placeholder="wachtwoord">
                </div>
            </div>

            <div class="blockcalc" id="vewyspoopy">
                <div id="radiodiv">
                    <div class="radio">
                        <input type="radio" name="radio" value="1">
                        <label>Medewerker</label>
                    </div>

                    <div class="radio">
                        <input type="radio" name="radio" value="0">
                        <label>Gast</label>
                    </div>
                </div>
            </div>

            <div class="blockcalc">
                <div class="input_thing">
                    <input  type="submit" value="submit">
                </div>
            </div>
        </form>
        <div class="blockcalc">
                <div class="input_thing">
                    <input id="fonkybutton" type="button" value="maak account" onclick="makeaccount()">
                </div>
        </div>
    </div>

<div class="formpic">
        <img class="picinform" id="boatpic" src="images/tempimg.jpg" alt="pic">
</div>