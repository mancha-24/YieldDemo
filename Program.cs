// See https://aka.ms/new-console-template for more information
var lines = GetFileLines();

int i = 0;

foreach (var line in lines)
{
    if(i >= 5)
    {
        break;
    }

    i++;
    Console.WriteLine(line);
}
Console.WriteLine("hola");

static IEnumerable<string> GetFileLines()
{
    string baseDir = $"{Directory.GetCurrentDirectory()}/archivo.txt";
    using var stream = new FileStream(baseDir, FileMode.Open, FileAccess.Read);
    using var reader = new StreamReader(stream);

    string? line = string.Empty;
    do
    {
        line = reader.ReadLine();
        if(line != null)
        {
            yield return line;
        }
    }
    while(line != null);
    yield break;
}