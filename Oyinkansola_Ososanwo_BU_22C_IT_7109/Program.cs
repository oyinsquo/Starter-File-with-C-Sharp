// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
console.WriteLine("Whats your name?");
response = Console.Readline();
Console.WriteLine($"Enjoy the course, {response}");

OperatingSystem thisOS = Envirinment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);
