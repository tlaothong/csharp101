Console.WriteLine("Please enter a score:");
var scoreText = Console.ReadLine();
var score = int.Parse(scoreText);
string grade;

if (score > 80) {
	grade = "A";
} if (score > 70) {
	grade = "B";
} if (score > 60) {
	grade = "C";
} else {
	grade = "F";
}

Console.WriteLine("grade: {0}", grade);