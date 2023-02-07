//First Exersice

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


// Second Exersice
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


// Third Exersice




// Fourth Exersice
let multiplyBtn = document.querySelector("#multiplyBtn");
let inputmultiplya = document.querySelector("#inputa");
let inputmultiplyb = document.querySelector("#inputb");
let resultmultiply = document.querySelector("#outputmultiply");


multiplyBtn.addEventListener("click", multiply);

function multiply(a, b) {
    if (a == Number & b == Number) {
        result = a * b;
        return resultmultiply.result;
    }
    else {
        string("Please enter only numbers.");
    }
}



// Fifth Exersice

let incrementBtn = document.querySelector("#incrementBtn");
let inputincrement = document.querySelector("#inputincrement");
let resultincrement = document.querySelector("#outputincrement");

incrementBtn.addEventListener("click", incrementString);

function incrementString(str) {
    const body = str.slice(0, -1);
    const lastDigit = str.slice(-1).match(/[0-9]/);
    return lastDigit === null
      ? str + "1"
      : lastDigit != 9
      ? body + (+lastDigit + 1)
      : incrementString(body) + "0";
  }