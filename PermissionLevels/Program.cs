string permission = "Admin|Manager";
int level = 10;

Console.WriteLine("Enter user level");
string input = Console.ReadLine().ToLower();

if (input == null) Console.WriteLine("Enter a permission level and try again. (Admin | Manager)");
else {
    if (input.Equals("manager", StringComparison.CurrentCultureIgnoreCase) && permission.Contains(input, StringComparison.CurrentCultureIgnoreCase) && level < 20) Console.WriteLine("You do not have sufficient privileges.");
    
    else if (input.Equals("manager", StringComparison.CurrentCultureIgnoreCase) && permission.Contains(input, StringComparison.CurrentCultureIgnoreCase) && level >= 20) Console.WriteLine("Contact an Admin for access.");

    else if (input.Equals("admin", StringComparison.CurrentCultureIgnoreCase) && permission.Contains(input, StringComparison.CurrentCultureIgnoreCase) && level <= 55) Console.WriteLine("Welcome, Admin User");
    
    else if (input.Equals("admin", StringComparison.CurrentCultureIgnoreCase) && permission.Contains(input, StringComparison.CurrentCultureIgnoreCase) && level > 55) Console.WriteLine("Welcome, Super Admin User");

    else Console.WriteLine("You do not have sufficient privileges.");
}