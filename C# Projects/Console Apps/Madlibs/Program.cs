//sentences
string sentenceDisplay = "It was ___(FOOD)___ day at school, and ___(NAME)___ was super ___(ADJECTIVE)___ for lunch. But when they went outside to eat, a ___(NOUN)___ stole her ___(FOOD)___! ___(NAME)___ chased the ___(NOUN)___ all over school. They ___(VERB1)___, ___(VERB2)___, and ___(VERB3)___ through the playground. Then they tripped on a ___(NOUN)___ and the ___(NOUN)___ escaped! Luckily, ___(NAME)___'s friends were willing to share their ___(FOOD)___ with her.";

//stored info
string? playerName;

//fill ins
string? food, name, adjective, bird, verb1, verb2, verb3, noun;

Console.WriteLine("\nWelcome to DylanDev's Madlib game!\nPlease enter your name:");
playerName = Console.ReadLine();
Console.WriteLine($"\nWonderful! Hello {playerName}!\nNow that we got introductions out of the way, lets begin with the game!\n\nInstructions:\nWe will present you with a sentence. You can read through the sentence and then when you are ready you will start answering the questions that appear under the sentence. Good luck!");

Console.WriteLine($"\nSentence:\n{sentenceDisplay}");

Console.WriteLine("\nEnter a type of food:");
food = Console.ReadLine();

Console.WriteLine("\nEnter a name:");
name = Console.ReadLine();

Console.WriteLine("\nEnter an adjective:");
adjective = Console.ReadLine();

Console.WriteLine("\nEnter a type of bird:");
bird = Console.ReadLine();

Console.WriteLine("\nEnter a verb in the past tense:");
verb1 = Console.ReadLine();

Console.WriteLine("\nEnter a different verb in the past tense:");
verb2 = Console.ReadLine();

Console.WriteLine("\nEnter one last verb in the past tense:");
verb3 = Console.ReadLine();

Console.WriteLine("\nEnter a noun:");
noun = Console.ReadLine();

Console.WriteLine("\nWithout further adieu, here is your story:");

Console.WriteLine($"\nIt was {food} day at school, and {name} was super {adjective} for lunch. But when they went outside to eat, a {bird} stole her {food}! {name} chased the {bird} all over school. They {verb1}, {verb2}, {verb3} through the playground. Then they tripped on a {noun} and the {bird} escaped! Luckily, {name}'s friends were willing to share their {food} with her.");