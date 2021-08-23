// All variables
var message = "congratz you did it woohw";
var j = 1;
var ImpArr;
var openOne = 0;
var openTwo = 0;
var tempCardOne = 0;
var tempCardTwo = 0;
var scoreCount = 0;
var timeOutBug1 = 0;
var timeOutBug2 = 0;
var timer = 0;
var n;

// All functions
function turn() {
    // get image and plant the right one in the background
    let choice = this.id; //choice is the id of selected card
    let choiceToCard = choice - 1;

    document.getElementById(choice).style.backgroundImage = "url(assets_amongus/assets/" + ImpArr[choiceToCard] + ")";
    compareCards(ImpArr[choiceToCard], choice);
    if(timer == 0) {
        timeCount;
    }
}

// Fetch randomised data from php
function testthingy() {
    fetch('randomiser.php')
    .then(res => res.json())
    .then(data => publicise(data));
}

// Publicise data from fetch so my whole code can use it
function publicise(pdata) {
    ImpArr = pdata;
}

// temporarly stores cards in tempCardOne and tempCardTwo
function compareCards(selectCard, cards) {
    if (openOne == 0) {
        openOne = selectCard;
        tempCardOne = cards;
        document.getElementById(tempCardOne).removeEventListener('click', turn);
    }
    else if (openTwo == 0 && openOne != 0) {
        openTwo = selectCard;
        tempCardTwo = cards;
        document.getElementById(tempCardTwo).removeEventListener('click', turn);
        rewardCard();
    }
}

// Check if selected cards are equal based on url image
function rewardCard() {
    if (openOne == openTwo) {
        scoreCount++;
        console.log(scoreCount);
        setTimeout(resetTempCardValues(), 10);

        if(scoreCount == 8) {
            var endtime = timeCount();
            var endmessage = message + "you did it in " + endtime + "milisec";
            alert(endmessage);
        }
    }
    else {
        setTimeout(reset, 300);
    }
}

// resets tempCardOne/Two
function resetTempCardValues() {
    tempCardOne = 0;
    tempCardTwo = 0;
    openOne = 0;
    openTwo = 0;
}

function timeCount() {
    if(n != null) {
        let q = new Date();
        let s = q.getTime();

        var TIME = s - d;
        return TIME;
    }
    else {
        let d = new Date();
        n = d.getTime();
    }
}

function startWebsite() {
    testthingy();
    timeCount();
}

function reset() {
    document.getElementById(tempCardOne).style.backgroundImage = "url(background.jpg)";
    document.getElementById(tempCardTwo).style.backgroundImage = "url(background.jpg)";
    document.getElementById(tempCardOne).addEventListener('click', turn);
    document.getElementById(tempCardTwo).addEventListener('click', turn);
    resetTempCardValues();
}

window.onload = startWebsite();

for(var i = 1; i <= 16; i++) {
    if(j == 5) {
        j = 1;
    }

    let playfield = document.getElementById('content');
    let card = document.createElement('div');
    card.className = 'card';
    card.id = i;
    card.addEventListener("click", turn);

    if(i <= 4) {
        card.style.gridColumn = j * 2;
        card.style.gridRow = 2;
    }
    else if (i <= 8) {
        card.style.gridColumn = j * 2;
        card.style.gridRow = 4;
    }
    else if (i <= 12) {
        card.style.gridColumn = j * 2;
        card.style.gridRow = 6;
    }
    else if (i <= 16) {
        card.style.gridColumn = j * 2;
        card.style.gridRow = 8;
    }
    j++;
    playfield.appendChild(card);
}
