using System;
using System.Text.RegularExpressions;

// 3 - start (I) Identificar uma URL válida
Regex rgUrl = new Regex(@"(https:\/\/|http:\/\/)(\w|.)*(.net|.com|.edu)(\/(\w|.)*)*");
String[] urlList = { "https://imed.mrooms.net/course/view.php", "http://www.google.com.br", "https://test.wrong/test" };

foreach (String url in urlList)
{
    Console.WriteLine("{0} {1} a valid url.", url, rgUrl.IsMatch(url) ? "is" : "is not");
}
// 3 - end (I) Identificar uma URL válida

// 3 - start (II) Identificar tags HTML
Regex rgHtml = new Regex(@"<(?<tag>\w+)>(\w|.*)*</(\k<tag>)>");
String[] htmlList = { "<a>test test test</b>" ,"<html>test test test</html>", "<test>test test test</text>" };

foreach (String html in htmlList)
{
    Console.WriteLine("{0} {1} a valid html.", html, rgHtml.IsMatch(html) ? "is" : "is not");
}
// 3 - end (II) Identificar tags HTML

// 3 - start (III) evitar palavras duplicadas em uma frase
Regex equalWords = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
String text = "The the quick brown fox  fox jumps over the lazy dog dog.";

MatchCollection matches = equalWords.Matches(text);

foreach (Match match in matches)
{
    GroupCollection groups = match.Groups;
    Console.WriteLine("Duplicated word: {0}", groups[0]);
}
// 3 - end (III) evitar palavras duplicadas em uma frase

// 4 - start (I) validacao de numero de telefone
Regex rgPhone = new Regex(@"\(([0-9]){2}\) ([0-9]){5}-([0-9]){4}");
String[] phoneList = { "(54) 99999-9999", "(4) 9999-9999", "(123) 99999-9999" };

foreach (String phone in phoneList)
{
    Console.WriteLine("{0} {1} a valid phone number.", phone, rgPhone.IsMatch(phone) ? "is" : "is not");
}
// 4 - end (I) validacao de numero de telefone

// 4 - start (II) validacao de placa de carro
Regex rgLicensePlate = new Regex(@"[A-Z]{3}[0-9][A-Z][0-9]{2}");
String[] licensePlateList = { "DWR6457", "BRR2E19", "rqc8g65" };

foreach (String licensePlate in licensePlateList)
{
    Console.WriteLine("{0} {1} a valid license plate.", licensePlate, rgLicensePlate.IsMatch(licensePlate) ? "is" : "is not");
}
// 4 - end (II) validacao de placa de carro