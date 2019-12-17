// alert("Hello from Treehouse");
// document.write("<h1>Welcome to JavaScript Basics</h1>");
// var visitorName = prompt("What is your name");
// var message = "Hello " + visitorName;
// message += "! Thanks for comeing to this place of business.";
// console.log(visitorName);
// document.write(message.toUpperCase());

var secondsPerMin = 60;
var minsPerHour = 60;
var hoursPerDay = 24;
var daysPerWeek = 7;
var weeksPerYear = 52;
var secondsPerDay = secondsPerMin * minsPerHour * hoursPerDay;
document.write('<p>There are ' + secondsPerDay + ' seconds in a day</p>');

var HTMLBadges = prompt("How mnay HTML badges do you have?");
var CSSBadges = prompt('How many CSS badges do you have?');
var totalBadges = parseInt(HTMLBadges) + parseInt(CSSBadges);
alert('Wow! you have ' + totalBadges + ' badges!');
