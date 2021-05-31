function clicky(click) {
    sessionStorage.setItem("button", click);
    window.location.assign("calculator.php");
}

function transition() {
    var choice = sessionStorage.getItem("button");
    document.getElementById("Fboat").value = choice;
    calc();
}

function calc() {
    // define boat
    var boat = document.getElementById('Fboat').value;

    //define picture
    var pic0 = "pic" + boat;
    var pic1 = "images/" + document.getElementById(pic0).innerHTML;
    document.getElementById('boatpic').src = pic1;

    //calc
    var DWT = "DWT" + boat;

    var Bweight = document.getElementById("Famount").value;
    var Bextra = document.getElementById("Fextra").value;

    var deadweight = document.getElementById(DWT).innerHTML;
    deadweight = parseInt(deadweight);

    var seizoen = document.getElementById("Fseason").value;

    if(seizoen == "Z") {
        deadweight = deadweight * 0.8;
    }
    else if(seizoen == "W") {
        deadweight = deadweight * 1.2;
    }
    else if(seizoen == "L") {
        deadweight = deadweight * 0.9;
    }
    else if(seizoen == "H") {
        deadweight = deadweight * 1;
    }

    var water = document.getElementById("Fwater").value;

    if(water == "salt") {
        deadweight = deadweight * 1.1;
    }

    deadweight = deadweight - Bweight - Bextra;

    var end = null;

    if(deadweight <= 0) {
        end = "Uw schip is overladen";
    }
    else {
        end = deadweight + " ton";
    }

    document.getElementById("Result").innerHTML = end;
}

function makeaccount() {
    document.getElementById('form-action').action = "db/newacc.db.php";
    document.getElementById('loginname').innerHTML = "Maak nieuw account:";
    document.getElementById('fonkybutton').value = "Login";
    document.getElementById('fonkybutton').onclick = login;
    document.getElementById('vewyspoopy').style.display = '';
    
}

document.getElementById('vewyspoopy').style.display = 'none';

function login() {
    location.reload();
}