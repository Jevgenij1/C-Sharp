/*
    currentAssignments: 5
    studentScore: sum of examal score
    Grading scale:
    97 - 100   A+
    93 - 96    A
    90 - 92    A-
    87 - 89    B+
    83 - 86    B
    80 - 82    B-
    77 - 79    C+
    73 - 76    C
    70 - 72    C-
    67 - 69    D+
    63 - 66    D
    60 - 62    D-
    0  - 59    F

*/

class Student(string name, List<int> scores, int assignments)
{
    public string studentName = name;
    private decimal studentScoreSummary = 0;
    private string scoreGrade = "F";
    private readonly List<int> studentScore = scores;
    private readonly int currentAssignments = assignments;
    // private readonly string[] grades = ["A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"];
    // private static readonly int[] gradesThreshold = [100, 97, 96, 93, 92, 90, 89, 87, 86, 83, 82, 80, 79, 77, 76, 73, 72, 70, 69, 67, 66, 63, 62, 60, 59, 0,];

    private static readonly Dictionary<string, List<int>> grades = new() {
        {"A+", new List<int>{97, 100}},
        {"A", new List<int>{93, 96}},
        {"A-", new List<int>{90, 92}},
        {"B+", new List<int>{87, 89}},
        {"B", new List<int>{83, 86}},
        {"B-", new List<int>{80, 82}},
        {"C+", new List<int>{77, 79}},
        {"C", new List<int>{73, 76}},
        {"C-", new List<int>{70, 72}},
        {"D+", new List<int>{67, 69}},
        {"D", new List<int>{63, 66}},
        {"D-", new List<int>{60, 62}},
        {"F-", new List<int>{0, 59}},
    };


    private decimal StudentScoreSummary()
    {
        decimal score = 0;
        int gradedAssignment = 0;
        for (int i = 0; i < studentScore.Count; i++)
        {
            gradedAssignment += 1;
            if (gradedAssignment <= currentAssignments)
            {
                score += studentScore[i];
            }
            else
            {
                score += studentScore[i] / 10;
            }
        }
        return score / currentAssignments;
    }


    private static string ScoreGrading(decimal score)
    {
        foreach (var grade in grades)
        {
            if (score >= grade.Value[0] && score <= grade.Value[1])
            {
                return grade.Key;
            }
        }

        return "F";
    }


    public void PrintGrade()
    {
        studentScoreSummary = StudentScoreSummary();
        scoreGrade = ScoreGrading(studentScoreSummary);
        Console.WriteLine($"{studentName}\t\t{studentScoreSummary}\t\t\t{studentScoreSummary}\t{scoreGrade}");
    }

}