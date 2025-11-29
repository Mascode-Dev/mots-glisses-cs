static bool TrouverMotRec(char[,] tableau, string mot, int x, int y, int index)
{
    if (index == mot.Length)
        return true;

    if (x < 0 || x >= tableau.GetLength(0) || y < 0 || y >= tableau.GetLength(1))
        return false;

    if (tableau[x, y] == mot[index])
    {
        char tmp = tableau[x, y];
        tableau[x, y] = '*'; // Marquer la case comme utilisée

        // Vérifier dans toutes les directions sauf vers le bas
        bool trouve = TrouverMotRec(tableau, mot, x - 1, y, index + 1) ||
                      TrouverMotRec(tableau, mot, x, y - 1, index + 1) ||
                      TrouverMotRec(tableau, mot, x, y + 1, index + 1) ||
                      TrouverMotRec(tableau, mot, x - 1, y - 1, index++) ||
                      TrouverMotRec(tableau, mot, x - 1, y + 1, index++);
        if (trouve == false)
        {
            tableau[x, y] = tmp;
        }
        return trouve;
    }
    return false;
}

char[,] tab = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'h', 'i', 'j' } };
Console.WriteLine(TrouverMotRec(tab, "eba", 1, 1, 0));