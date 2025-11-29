static void Defilement(char[,] matrice)
{
    for (int j = 0; j < matrice.GetLength(1); j++)
    {
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            if (matrice[i, j] == '*')
            {
                if (i == 0)
                {
                    matrice[i, j] = '-';
                }
                else
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        matrice[k + 1, j] = matrice[k, j];
                    }
                    matrice[0, j] = '-';
                }
            }
        }
    }
}

char[,] mat = { { 'a', '*', 'c' }, { '*', 'e', '*' }, { 'h', '*', 'j' } };
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("Défilement \n\n\n");
Defilement(mat);
for(int i = 0; i < mat.GetLength(0); i++)
{
    for(int j = 0; j< mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j]+" ");
    }
    Console.WriteLine();
}
