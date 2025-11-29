static void toFile(string file, char[,] mat)
{
    string s = "";
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1) - 1; j++)
        {
            s += mat[i, j] + ",";
        }
        s += mat[i, mat.GetLength(1) - 1];
        s += "\n";
    }
    try
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(s);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
}

//TEST
char[,] mat = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'h', 'i', 'j' } };
toFile("fichierTest.txt",mat);
Console.WriteLine("aller voir dans le fichier NET06");