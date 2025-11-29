static char[,] GenererMat(char[] tab, int ligne, int colonne) //Génère une matrice selon un tab[] de char sorti d'une autre fonction
{
    char[,] tableau = new char[ligne, colonne];
    Random r = new Random();
    for (int i = 0; i < ligne; i++)
    {
        for (int j = 0; j < colonne; j++)
        {
            int nb = r.Next(tab.Length);
            if (tab[nb] == '\0')
            {
                j--;
            }
            else
            {
                tableau[i, j] = tab[nb];
                tab[nb] = '\0';
            }
        }
    }
    return tableau;
}
char[] tab = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[,] mat = GenererMat(tab, 3, 3); //générer une matrice de taille 3,3 avec les éléments de tab mis de façon aléatoire.
Console.WriteLine("Première matrice aléatoire !");
for(int i = 0; i< mat.GetLength(0); i++)
{
    for(int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j]+" ");
    }
    Console.WriteLine();
}
char[,] mat2 = GenererMat(tab, 3, 3); //générer une matrice de taille 3,3 avec les éléments de tab mis de façon aléatoire.
Console.WriteLine("Deuxième matrice aléatoire !");
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat2[i, j] + " ");
    }
    Console.WriteLine();
}