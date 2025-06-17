// See https://aka.ms/new-console-template for more information
//Write program to prompt a user to input his/her name and country name
//and then output will be shown as given: Hello <yourname> from country <countryname>

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your country name: ");
string country = Console.ReadLine();

Console.WriteLine($"Hello {name} from country {country}");
