//Creating functions
// function alertRandom() {
//     var randomNumber = Math.floor(Math.random() * 6) + 1;
//     alert(randomNumber)
// }

// alertRandom();

// function getRandomNumber() {
//     var randomNumber = Math.floor(Math.random() * 6) + 1;
//     return randomNumber
// }

// alert( getRandomNumber);
// console.log(getRandomNumber);
// var getRandomNumber;


// Check if Email is Empty
// function isEmailEmpty() {
//     var field = document.getElementById('email');
//     if (field.value === '') {
//         return true;
//     } else {
//         return false;
//     }
// }

// var fieldTest = isEmailEmpty();
// if (fieldTest === true) {
//     alert("Please provide your email address.");
// }



// // Function Expression
// var alertRandom = function () {
//     var randomNumber = Math.floor(Math.random() * 6) + 1;
//     alert(randomNumber)
// };

// alertRandom();

function getRandomNumber(upper) {
    var randomNumber = Math.floor(Math.random() * upper) + 1;
    return randomNumber
}
// console.log(getRandomNumber(10) );
// console.log(getRandomNumber(1000) );
// console.log(getRandomNumber(20) );
// console.log(getRandomNumber(100) );
// console.log(getRandomNumber(50) );

function getArea(width, length, unit )  {
    var area = width * length;
    return area + " " + unit;
}

console.log(getArea(10, 20, 'sq ft'));

