// All the used functions on all pages:

function galgje() {
    var woord = document.getElementById('woord').value;

    if(woord != "") {
        sessionStorage.setItem('solution', woord);
        window.location.replace('raad-woord.php');
    }
    else {
        alert("vul een woord in");
    }
    
}

function check() {
    var check = sessionStorage.getItem('solution');
    if (check == null) {
        alert("vul een woord in");
        window.location.replace('index.php');
    }
}

function think() {
    var thinking = document.getElementById('guess').value;
    thinking = thinking.toUpperCase();

   if(spoopyarray.includes(thinking)) {

       var location = spoopyarray.indexOf(thinking);
       sneaky[location] = thinking;
       var x = location;
       
       for(x; x <= Wlength; x++) {
            if (spoopyarray[x] == thinking) {
                sneaky[x] = thinking;
            }
       }
   }
   else {
       countdown -= 1;
       countup += 1;
       document.getElementById('ouch').innerHTML = countdown + "lives left";
       var picture = "img/" + countup + ".png"
       document.getElementById('pic').src = picture;
   }

   document.getElementById('Hmm').innerHTML = sneaky.join(" ");

   if (arraysEqual(sneaky, spoopyarray)) {
        winstate(1);
   }
    else if (countdown <= 0) {
        winstate(2);
   }
}

function arraysEqual(a1,a2) {
    return JSON.stringify(a1)==JSON.stringify(a2);
}

function playagain() {
    window.location.replace('index.php');
}

function winstate(WoL) {
    sessionStorage.removeItem('solution');
    document.getElementById('button').onclick = playagain;       
    document.getElementById('guess').remove();
    document.getElementById('pic').remove();

    if(WoL == 1) {
        document.getElementById('Hmm').innerHTML = solutionword;
        document.getElementById("ouch").innerHTML = "Congratz you got the word!";
        document.getElementById('button').value = "play again?";
    }
    else if (WoL == 0) {
        document.getElementById("Hmm").innerHTML = "";
        document.getElementById("ouch").innerHTML = "Oh well, you failed";
        document.getElementById('button').value = "play again?";
    }
}