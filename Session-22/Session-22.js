let reverseBtn = document.querySelector("#reverseBtn");
let inputReverse = document.querySelector("#inputReverse");
let resultReverse = document.querySelector("#outputReverse");

reverseBtn.addEventListener("click", reverseStr);
function reverseStr(){
    resultReverse.textContent = reverseString(inputReverse.value);
}

function reverseString(str){
    return str.split("").reverse().join("");
}

let palindromeBtn = document.querySelector("#palindromeBtn");
let inputPalindrome = document.querySelector("#inputpalindrome");
let resultPalindrome = document.querySelector("#outputpalindrome");


palindromeBtn.addEventListener("click", ispalindrome);

function ispalindrome(){
    let str = inputPalindrome.value;
    let reversedStr = reverseString(str);
    if (str === reversedStr)
        resultPalindrome.textContent = "True";
    else
        resultPalindrome.textContent = "False";
}

