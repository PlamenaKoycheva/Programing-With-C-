//Write a program that:
//•	Reads an integer number from the console
//•	If the number is in range [1…7] print:
//o	"Monday" for number 1
//o	"Tuesday" for number 2
//o	"Wednesday" for number 3
//o	"Thursday" for number 4
//o	"Friday" for number 5
//o	"Saturday" for number 6
//o	"Sunday" for number 7
//•	If the number is out of the given range print "Invalid day!"

int day = int.Parse(Console.ReadLine());
string[] daysOfWeek = new string[] 
{ 
    "Monday",
    "Tuesday" ,
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
if (day < 1 || day >7)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(daysOfWeek[day - 1]);
}
   
