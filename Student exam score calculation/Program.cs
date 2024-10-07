
/*
Sophia:  90, 86, 87, 98, 100, 94, 90
Andrew:  92, 89, 81, 96, 90, 89
Emma:  90, 85, 87, 98, 68, 89, 89, 89
Logan:  90, 95, 87, 88, 96, 96
*/
class Program
{
    public static void Main()
    {
        Dictionary<string, List<int>> studentScores = new() {
            {"Sophia", new List<int>{ 90, 86, 87, 98, 100, 94, 90 }},
            {"Nicolas", new List<int>{ 92, 89, 81, 96, 90, 89 }},
            {"Zahirah", new List<int>{ 90, 85, 87, 98, 68, 89, 89, 89 }},
            {"Jeong", new List<int>{  90, 95, 87, 88, 96, 96 }}
        };

        Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit\n");

        foreach (var studentScore in studentScores)
        {
            Student student = new(studentScore.Key, studentScore.Value, 5);
            student.PrintGrade();
        }
    }
    // private readonly string[] grades = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };
    // private static readonly int[] gradesThreshold = { 100, 97, 96, 93, 92, 90, 89, 87, 86, 83, 67, 63, 60 };
    // public static void Main()
    // {
    //     Program program = new();
    //     int score = 99;
    //     string grade = program.GetGrade(score);
    //     Console.WriteLine($"{score} {grade}");
    // }

    // public string GetGrade(int score)
    // {
    //     for (int i = 0; i < gradesThreshold.Length; i++)
    //     {
    //         if (score >= gradesThreshold[i])
    //         {
    //             return grades[i];
    //         }
    //     }

    //     return "F";
    // }
}

