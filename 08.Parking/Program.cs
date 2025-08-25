//SoftUni just got a new parking lot.It's so fancy, it even has online parking validation. Except the online service doesn't work.
//It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?
//Write a program, which validates a parking place for an online service.Users can register to park and unregister to leave.
//The program receives 2 commands:	
//•	"register {username} {licensePlateNumber}":
//o The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username,
//the system should print:
//"ERROR: already registered with plate number {licensePlateNumber}"
//o If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
// "{username} registered {licensePlateNumber} successfully"
//•	"unregister {username}":
//o If the user is not present in the database, the system should print:
//"ERROR: user {username} not found"
//o If the aforementioned check passes successfully, the system should print:
//"{username} unregistered successfully"
//After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
//•	"{username} => {licensePlateNumber}"

using System.Diagnostics;

int registrationCount = int.Parse(Console.ReadLine());

Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

for (int i = 0; i < registrationCount; i++)
{
    string[] commandParts = Console.ReadLine().Split();
    string command = commandParts[0];
    string username = commandParts[1];

    if (command == "register")
    {
        string licensePlateNumber = commandParts[2];

        if (registeredUsers.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {registeredUsers[username]}");
        }
        else
        {
            registeredUsers.Add(username, licensePlateNumber);
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
    }
    else if (command == "unregister")
    {
        if (!registeredUsers.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            registeredUsers.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }

    }
}
foreach (var user in registeredUsers)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}