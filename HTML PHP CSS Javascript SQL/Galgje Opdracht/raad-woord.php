<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="stylesheet/style.css">
    <script defer type="text/javascript" src="java/java.js"></script>
    <script defer type="text/javascript" src="java/java2.js"></script>
    <title>raad woord</title>
</head>
<body onload="check()">
    <div id="center">
        <div>
            <div id="galgje">
                <h2>Hangman</h2>
                <div id="woord">
                    <label for="" id="Hmm"></label>
                    <label for="" id="ouch">5 lives left</label>
                </div>
                <div>
                    <input type="text" name="guess" id="guess" maxlength="1">
                    <input type="button" value="check" onclick="think()" id="button">
                </div>
            </div>
        </div>
        <div>
            <img src="img/1.png" alt="" width="100" height="100" id="pic">
        </div>
    </div>
</body>
</html>