using _02.Students;
using System.Collections.Generic;

//Define a class called Student, which will hold the following information about some students: 
//•	first name - string
//•	last name - string
//•	age - int
//•	home town - string
//Input
//Read information about some students, until you receive the "end" command. 
//After that, you will receive a city name.
//Output
//Print the students who are from the given city in the following format: 
//"{firstName} {lastName} is {age} years old."

string command = Console.ReadLine();
List<Student> studentList = new List<Student>();
while (command != "end")
{
    string [] studentInfo = command.Split(" ").ToArray();
    string studentFirstName = studentInfo[0];
    string studentLastName = studentInfo[1];
    int studentAge = int.Parse(studentInfo[2]);
    string studentHomeTown = studentInfo[3];
    Student data = new Student(studentFirstName, studentLastName, studentAge, studentHomeTown);
    studentList.Add(data);

    command = Console.ReadLine();
}


string cityCommand =  Console.ReadLine();
foreach (Student data in studentList)
{
    if (cityCommand == data.HomeTown)
    {
        Console.WriteLine($"{data.FirstName} {data.LastName} is {data.Age} years old.");
    }
}