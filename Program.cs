string path = "test.txt";

string name = "Bob";
int health = 100;
string guild = "ninja";
string? line = "blank";

//find current directory path
string currentDirectory = Environment.CurrentDirectory;
Console.WriteLine(Environment.CurrentDirectory);

//create a folder
Directory.CreateDirectory(currentDirectory + "/streamer");

//path to new text file to be created
path = currentDirectory + "/streamer/" + "saveGame.txt";

Console.WriteLine(path);

writeFile();
writeFile();

readFile();

void readFile()
{
    
    try
    {
        using StreamReader reader = new StreamReader(path);
        line = reader.ReadLine();

    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }

    Console.WriteLine("From file: " + line);
    Console.ReadKey();
}


void writeFile()
{
    try
    {
        using StreamWriter writer = new StreamWriter(path);

        writer.WriteLine(name);
        writer.WriteLine(health);
        //writer.Close();
        writer.Flush();

        //append to text file
        using StreamWriter writer2 = new StreamWriter(path, true);

        writer2.WriteLine(guild);
        writer2.Flush();
        //writer2.Close();

        //overwrite
        using StreamWriter writer3 = new StreamWriter(path);
        writer3.WriteLine("overwritten");
        writer3.Flush();
        //writer3.Close();

    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }
}

Console.ReadKey();