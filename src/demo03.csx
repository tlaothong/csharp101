Console.WriteLine("Please enter a score:");
var scoreText = Console.ReadLine();
var score = int.Parse(scoreText);
string grade;

if (score > 80) {
	grade = "A";
} else if (score > 70) {
	grade = "B";
} else if (score > 60) {
	grade = "C";
} else {
	grade = "F";
}

Console.WriteLine("grade: {0}", grade);