int numberOfVowels = 0, numberOfConsonants = 0;

Console.WriteLine("Informe um nome");
string? completeName = Console.ReadLine();

completeName = completeName?.ToUpper();
completeName = completeName?.Replace(" ", "");

for (var i = 0; i < completeName?.Length; i++)
{
    if ((completeName[i] == 'A') ||
        (completeName[i] == 'E') ||
        (completeName[i] == 'I') ||
        (completeName[i] == 'O') ||
        (completeName[i] == 'U'))
        numberOfVowels++;
    else
        numberOfConsonants++;
}

Console.WriteLine($"O nome digitado tem: {numberOfVowels} vogais");
Console.WriteLine($"O nome digitado tem: {numberOfConsonants} consoantes");
Console.WriteLine($"O nome digitado tem: {numberOfVowels + numberOfConsonants} letras");