function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}
window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}
function showPlayTime() {
    var text = document.getElementById("totalplayed");
    if (text.style.display === "none") {
        text.style.display = "block";
    } else {
        text.style.display = "none";
    } 
}
function showLightLevel() {
    var text = document.getElementById("lightlevel");
    if (text.style.display === "none") {
        text.style.display = "block";
    } else {
        text.style.display = "none";
    }
}
function ShowPinnCap() {
    var text = document.getElementById("pinncap");
    if (text.style.display === "none") {
        text.style.display = "block";
    } else {
        text.style.display = "none";
    }
}