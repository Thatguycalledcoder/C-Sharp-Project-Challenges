// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

// Write the Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    decimal currentExamScore = 0;
    int extraCredit = 0;
    decimal extraCreditPoints = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentOverallGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentOverallGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    string currentStudentLetterGrade = "";

    if (currentOverallGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentOverallGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentOverallGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentOverallGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentOverallGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentOverallGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentOverallGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentOverallGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentOverallGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentOverallGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentOverallGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentOverallGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentExamScore}\t\t{currentOverallGrade}\t{currentStudentLetterGrade}\t {extraCredit} ({extraCreditPoints} pts)");
}

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();