// var nouns = prompt("Give me a noun.");
// var verbs = prompt("Give me a verb");
// var adjectives = prompt("Give me an adjective");
// var story = "The " + adjectives + " " + nouns + " " + verbs + " far away!";
// document.write(story); 

// "<h2>There once was a [adjective] programmer who wanted to use JavaScript to [verb] the [noun].</h2>"
var questions = 3;
var questionsLeft = ' [' + questions + ' questions left]';
var adjective = prompt("please type an adjective" + questionsLeft);
questions -= 1;
questionsLeft = ' [' + questions + ' questions left]'; 
var sentence = "<h2>There once was a " + adjective;
var verb = prompt("please type a verb " + questionsLeft);
questions -= 1;
questionsLeft = ' [' + questions + ' questions left]'; 
var noun = prompt("please type a noun" + questionsLeft);
alert("All done. Ready for the message?");
sentence += ' programer who wanted to use JavaScript to ' + verb;
sentence += ' the ' + noun +'.</h2>';
document.write(sentence);