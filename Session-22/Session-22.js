const reverseBtn = document.querySelector("#reverseBtn");
const inputString =document.quarySelector("#inputReverse");
const result = document.querySelector("#outputReverse");

reverseBtn.addEventListener("click", function() {
    result.textContent = reverseString(inputString.value);
});



function reverseString(str){
    return str.split("").reverse().join("");
}