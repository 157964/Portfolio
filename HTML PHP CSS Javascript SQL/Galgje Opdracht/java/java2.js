// All global variables:

var solutionword = sessionStorage.getItem('solution');
var Wlength = solutionword.length;

var spoopy = solutionword.toUpperCase();

var sneaky = [];
var tricky = solutionword;

spoopy = spoopy.replace(/ /g, '');

var spoopyarray = [];

var countdown = 5;
var countup = 1;
var ded = 0;

// Setup "raad woord":

for(var j = 0; j <= (spoopy.length - 1); j++) {
    var temp = spoopy[j];
    spoopyarray[j] = temp;
    if (spoopyarray[j] == null) {
        spoopyarray.splice(j);
    }
}


for(var i = 0; i <= (Wlength - 1); i++) {
    sneaky[i] = '_ ';
}

while (sneaky.length != spoopyarray.length) {
    sneaky.pop();
}

while (spoopyarray.length != sneaky.length) {
    spoopyarray.pop();
}

document.getElementById('Hmm').innerHTML = sneaky.join("");