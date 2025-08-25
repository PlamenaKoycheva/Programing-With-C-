//Create a program that keeps information about companies and their employees. 
//You will be receiving a company name and an employee's id, until you receive the "End" command. Add each employee to the given company.
//Keep in mind that a company cannot have two employees with the same id.
//When you finish reading the data, print the company's name and each employee's id in the following format:
//{ companyName}
//-- { id1}
//-- { id2}
//-- { idN}
//Input / Constraints
//•	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
//•	The input always will be valid.

Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
string input = Console.ReadLine();

while (input != "End")
{
    string[] parts = input.Split(" -> ");
    string company = parts[0];
    string employeeId = parts[1];

    if (!companies.ContainsKey(company))
    {
        companies[company] = new List<string>();
    }

    if (!companies[company].Contains(employeeId))
    {
        companies[company].Add(employeeId);
    }
    input = Console.ReadLine();
}

foreach (var company in companies)
{
    Console.WriteLine(company.Key);
    foreach (var employeeId in company.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}