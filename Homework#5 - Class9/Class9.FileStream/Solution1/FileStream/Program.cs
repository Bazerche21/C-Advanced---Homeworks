string appPath = @"..\..\..\";
string folderPath = appPath + @"myFolder\";
string filePath = folderPath + @"names.txt";

Directory.CreateDirectory(folderPath);

Console.WriteLine("Enter names (one per line). Type 'done' when finished:");
using (StreamWriter writer = new StreamWriter(filePath, true))
{
    string name;
    while ((name = Console.ReadLine()) != "done")
    {
        writer.WriteLine(name);
    }
}

FilterNamesByLetter(filePath);
Console.WriteLine("Task completed successfully.");

void FilterNamesByLetter(string filePath)
{
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    foreach (char letter in alphabet)
    {
        string outputFilePath = Path.Combine(@"Files", $"namesStartingWith_{letter}.txt");
        var namesStartingWithLetter = File.ReadLines(filePath)
                                           .Where(name => name.StartsWith(letter.ToString()))
                                           .ToList();

        if (namesStartingWithLetter.Any())
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath, true))
            {
                foreach (var name in namesStartingWithLetter)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}