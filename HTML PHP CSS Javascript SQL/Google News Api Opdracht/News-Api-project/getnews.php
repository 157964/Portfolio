<?php
$country = 'nl';
$amount = 20;

$url = 'http://newsapi.org/v2/top-headlines?' .
              "country={$country}&" .
              "pageSize={$amount}&" .
              'apiKey=0a186b8720e2431d88ae32804a246c61';
$response = file_get_contents($url);
$newsdata = json_decode($response);

foreach($newsdata->articles as $news) {
    echo    "<div class='tekstdiv'>" .
                '<h2>' . $news->title . '</h2>' .
                '<p>' . $news->description . '<p>' .
                '<p>' . $news->content . '<p>' . 
                '<h5>' . $news->author . '</h5>' .
                "<a href='" . $news->url . "'>" . $news->url . "</a>" . 
            '</div>' .
            "<div class='imagediv'>" .
                "<img class='image' src='{$news->urlToImage}' alt='newspicture'>" .
            '</div>';
}