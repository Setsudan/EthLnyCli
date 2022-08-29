using System.Diagnostics;

Console.WriteLine("Irashaimaseeeeee");
static string? GetInput()
{
    return Console.ReadLine();
}

string input = GetInput();

if (input == null)
{
    Console.WriteLine("Invalid input");
    return;
}
foreach (var word in input.Split(' '))
{
    switch (word)
    {
        case "react":
            Console.WriteLine("What will be the name of your app ? ");
            string appName = Console.ReadLine();
            Process.Start("CMD.exe", "/K npx create-react-app " + appName);
            break;
        case "vue":
            Console.WriteLine("What will be the name of your app ? ");
            Process.Start("CMD.exe", "/K npm init vue@latest");
            break;
        case "vite":
            Process.Start("CMD.exe", "/K npm create vite@latest");
            break;
        case "angular":
            Process.Start("CMD.exe", "/K ng new");
            break;
        case "_":
            Console.WriteLine("Invalid input");
            return;
    }



}

