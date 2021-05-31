<div id="menu">
    <div id="menhead">
        <div id="name">

            <?php if($_SESSION['ID'] != NULL) {
                $thing = $_SESSION['ID'];

                echo "<p>welkom $thing</p> ";
            }
            else {          ?>

            <p>Bestevaer</p>

            <?php  }        ?>

        </div>
    </div>
    <div id="menlower">

        <button class="menitem" onclick="window.location.href='botenlijst.php'">
            <p>Botenlijst</p>
        </button>

        <?php
        if($_SESSION['worker'] != NULL) {
            $thing1 = $_SESSION['worker'] OR NULL;
            if($_SESSION['worker'] == 1)
            {   ?>

            <button class="menitem" onclick="window.location.href='calculator.php'">
                <p>Calculator</p>
            </button>

    <?php   }
        }
        if($_SESSION['ID'] != NULL) { 
            ?>
            <button class="menitem" onclick="window.location.href='index.php'">
            <p>Logout</p>
            </button>

            <?php
        }
        else {
            ?>

        <button class="menitem" onclick="window.location.href='login.php'">
            <p>Login</p>
        </button>

       <?php } ?>
    </div>
</div>