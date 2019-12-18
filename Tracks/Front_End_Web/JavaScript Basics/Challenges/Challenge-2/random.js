
// My Answer
// var randomNum = prompt('Enter a number.');
// parseInt(randomNum);
// var newNum = Math.floor(Math.random() * randomNum);
// alert('Your random number between 1 and ' + randomNum + ' is ' + newNum );


var input1 = prompt('Please type a starting number');
var bottomNumber = parseInt(input1);
var input = prompt('Please type a number');
var topNumber = parseInt(input);
var randomNumber = Math.floor(Math.random() * (topNumber - bottomNumber + 1)) + bottomNumber;
var message = '<p>' + randomNumber + ' is a number between '+ bottomNumber + ' and ' + topNumber + '.</p>';
document.write(message);