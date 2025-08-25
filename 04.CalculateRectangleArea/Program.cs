

//Write a program that:
//•	Reads two integer numbers from the console: width and length
//•	Create a method which returns rectangle area with given width and length
//Hint: Rectangle area can be calculated when you multiply width and length of the rectangle. 
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int area =PrintRectangleArea(width, length);
Console.WriteLine(area);

static int PrintRectangleArea(int width, int length)
{
    return width * length;
}