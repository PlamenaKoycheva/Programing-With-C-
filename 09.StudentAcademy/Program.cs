//Create a program that keeps the information about students and their grades. 
//You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade.
//Check if the student already exists and if not, add him. Keep track of all grades for each student.
//When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
//Print the students and their average grade in the following format:
//"{name} –> {averageGrade}"
//Format the average grade to the 2nd decimal place.

using System.Xml.Linq;


int n = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string studentName = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!studentGrades.ContainsKey(studentName))
    {
        studentGrades[studentName] = new List<double>();
    }

    studentGrades[studentName].Add(grade);
}

foreach (var student in studentGrades)
{
    double average = student.Value.Average();
    if (average >= 4.50)
    {
        Console.WriteLine($"{student.Key} -> {average:F2}");
    }
}