<!DOCTYPE html>
<html lang="nl">
<head>
    
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link defer rel="stylesheet" href="style.css">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Merriweather&display=swap" rel="stylesheet">
    <title>Google news</title>

</head>
<body>

    <div id="top" class="overlay">
        <h1>News</h1>
        <p>This project is powered by <a href="https://newsapi.org/">Google News Api</a></p>
    </div>

    <div class="artikel">
    <!-- google news api -->
    <?php include "getnews.php"; ?>
    </div>

</body>
</html>