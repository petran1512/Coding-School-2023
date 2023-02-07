//First Exersice

let reverseBtn = document.querySelector("#reverseBtn");
let inputreverse = document.querySelector("#inputreverse");
let resultreverse = document.querySelector("#outputreverse");

reverseBtn.addEventListener("click", reverseStr);
function reverseStr(){
    resultreverse.textContent = reverseString(inputreverse.value);
}

function reverseString(str){
    return str.split("").reverse().join("");
}

// Second Exersice
let palindromeBtn = document.querySelector("#palindromeBtn");
let inputpalindrome = document.querySelector("#inputpalindrome");
let resultpalindrome = document.querySelector("#outputpalindrome");


palindromeBtn.addEventListener("click", ispalindrome);

function ispalindrome(){
    let str = inputpalindrome.value;
    let reversedStr = reverseString(str);
    if (str === reversedStr)
        resultpalindrome.textContent = "True";
    else
        resultpalindrome.textContent = "False";
}

// Third Exersice
function addCustomer(){
    const table = document.getElementById("tvlPosts");
    
    const newCustomer = {
        Name: document.querySelector("#customer-name").value,
        Surname: document.querySelector("#customer-surname").value,
        Age: document.querySelector("#customer-age").value,
        Gender: document.querySelector("#customer-gender").value,
    }
}


// Fourth Exersice
let multiplyBtn = document.querySelector("#multiplyBtn");
let a = document.querySelector("#inputa");
let b = document.querySelector("#inputb");
let resultmultiply = document.querySelector("#outputmultiply");


multiplyBtn.addEventListener("click", multiply);

function multiply(a, b) {
    if (a == Number & b == Number) {
        document.getElementById("outputmultiply").value = a*b;
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