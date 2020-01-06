// alert("Hello from Treehouse");
// document.write("<h1>Welcome to JavaScript Basics</h1>");
// var visitorName = prompt("What is your name");
// var message = "Hello " + visitorName;
// message += "! Thanks for comeing to this place of business.";
// console.log(visitorName);
// document.write(message.toUpperCase());

// var secondsPerMin = 60;
// var minsPerHour = 60;
// var hoursPerDay = 24;
// var daysPerWeek = 7;
// var weeksPerYear = 52;
// var secondsPerDay = secondsPerMin * minsPerHour * hoursPerDay;
// document.write('<p>There are ' + secondsPerDay + ' seconds in a day</p>');

// var HTMLBadges = prompt("How mnay HTML badges do you have?");
// var CSSBadges = prompt('How many CSS badges do you have?');
// var totalBadges = parseInt(HTMLBadges) + parseInt(CSSBadges);
// alert('Wow! you have ' + totalBadges + ' badges!');

// document.write(Math.round(2.2));
// Math.floor(Math.random() * 6) + 1;

// var dieRoll = Math.floor(Math.random() * 6) + 1;
// alert('You rolled a ' + dieRoll);

//Quiz
// var answer = prompt('What programming language is the name of a gem?');
// if (answer.toUpperCase() === "RUBY") {
//     document.write("<p>That's right!</p>");
// } else {
//     document.write("<p>Sorry, that's wrong.</p>")
// }

/*
The Random Number Guessing Game
Generates a number between 1 and 6 
and gives a player two attemps to 
gues the number. 
*/

// assume the player didn't guess correctly
 var correctGuess = false;

 // generate random number from 1 to 6
 var randomNumber = Math.floor(Math.random() * 6 ) + 1;
 var guess = prompt('I am thinking of a number between 1 and 6. What is i?');

/* test to see if player
1. correct
2. guessed too high
3. guessed too low
*/

//  if (parseInt(guess) === randomNumber) {
//      correctGuess = true;
//  } else if ( parseInt(guess) < randomNumber ) {
//     var guessMore = prompt('Try again. The number I am thining of is more than ' + guess);
//         if (parseInt(guessMore) === randomNumber) {
//             correctGuess = true;
//         }
//  } else if (parseInt(guess) > randomNumber ) {
//     var guessLess = prompt('Try again. The number I am thinking of is less than ' + guess);
//     if (parseInt(guessLess) === randomNumber) {
//         correctGuess = true;
//     }
//  }


// // test if player is correct and output response
//  if (correctGuess) {
//      document.write('<p>You guessed the number!</P>');
//  } else {
//      document.write('<p>Sorry. the number was ' + randomNumber + '</p>');
//  }

// if (false) {
//     document.write('The condition is true');
// } else {
//     document.write('The condition is false');
// }




