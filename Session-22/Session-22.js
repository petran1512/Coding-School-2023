let reverseBtn = document.querySelector("#reverseBtn");
let inputReverse = document.querySelector("#inputReverse");
let resultReverse = document.querySelector("#outputReverse");

reverseBtn.addEventListener("click", reverseString(inputReverse.Value));


function reverseString(str){
    resultReverse.textContent = str.split("").reverse().join("");
}