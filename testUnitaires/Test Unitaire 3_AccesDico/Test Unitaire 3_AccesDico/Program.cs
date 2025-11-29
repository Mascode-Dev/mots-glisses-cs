static List<string> AccessDico()
{
    //string path = "C:\\Users\\jgoth\\Documents\\ESILV\\A2\\Projet Test Unitaire\\TestUnitaire1\\Mots_Francais.txt";
    //string currentDirectory = Directory.GetCurrentDirectory();
    //string filePath = Path.Combine(currentDirectory, path);

    string path = "Mots_Francais.txt";
    if (File.Exists(path))
    {
        List<string> wordList = new List<string>(); //Liste de mot vide
        using (StreamReader sr = new StreamReader(path)) //Accède au flux 
        {
            while (!sr.EndOfStream) //Tant que c'est pas fini
            {
                string line = sr.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    string[] words = line.Split(' ');
                    wordList.AddRange(words);
                }
            }

            Console.WriteLine("Words in the list:");
            foreach(string word in wordList)
            {
                Console.WriteLine(word);
            }
        }
        return wordList;
    }
    else
    {
        Console.WriteLine("File not found");
        return null;
    }

}

AccessDico();


