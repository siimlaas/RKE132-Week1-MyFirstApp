// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutajal sisestada tema nime
// rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string- sõne
string userName = Console.ReadLine();
// 2 varianti
//userName = Console.ReadLine();

Console.WriteLine("Hello " + userName + "!");
//string interpolation

Console.WriteLine($"Hello, {userName} !");

