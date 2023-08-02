using System.Text.RegularExpressions;

Console.WriteLine("Escriba el texto que desea contar");
string text = Console.ReadLine();

string pattern = @"[0-9]";
var regex = new Regex (pattern);
int n = regex.Matches(text).Count;

Console.WriteLine("La cantidad de numeros que hay en el texto es :" + n );  */
