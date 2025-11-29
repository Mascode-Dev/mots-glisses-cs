using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace TestUnitaire1
{
    internal class InfoLettre
    {
        private char lettre;
        private int maxoccurrences;
        private int poids;

        public char Lettre
        {
            get { return lettre; }
            set { lettre = value; }
        }
        public int MaxOccurrences
        {
            get { return maxoccurrences; }
            set { maxoccurrences = value; }
        }
        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public static List<InfoLettre> LireFichierLettre(string Fichier)
        {
            List<InfoLettre> lettreInfos = new List<InfoLettre>();

            try
            {
                string[] lignes = File.ReadAllLines(Fichier);

                foreach (string ligne in lignes)
                {
                    string[] elements = ligne.Split(',');
                    if (elements.Length == 3)
                    {
                        InfoLettre lettreInfo = new InfoLettre
                        {
                            Lettre = elements[0][0],
                            MaxOccurrences = int.Parse(elements[1]),
                            Poids = int.Parse(elements[2])
                        };
                        lettreInfos.Add(lettreInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture du fichier : " + ex.Message);
            }

            return lettreInfos;
        }
    }
    internal class Plateau
    {
        private char[,] matrice;
        public Plateau(int ligne, int colonne)
        {
            this.matrice = GenererMat(ListC(InfoLettre.LireFichierLettre("Lettre.txt")), ligne, colonne);
        }
        public Plateau(char[,] plateau)
        {
            this.matrice = plateau;
        }

        public char[,] Matrice
        {
            get { return this.matrice; }
            set { this.matrice = value; }
        }
        public static char[] ListC(List<InfoLettre> List)
        {
            int s = 0;
            for (int i = 0; i < List.Count; i++)
            {
                s += List[i].MaxOccurrences;
            }
            char[] tab = new char[s];
            s--;
            for (int i = 0; i < List.Count; i++)
            {
                for (int j = 0; j < List[i].MaxOccurrences; j++)
                {
                    tab[s] = List[i].Lettre;
                    s--;
                }
            }
            return tab;
        }
        public static char[,] GenererMat(char[] tab, int ligne, int colonne)
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
        public static void toString(char[,] plato)
        {
            for (int i = 0; i < plato.GetLength(0); i++)
            {
                for (int j = 0; j < plato.GetLength(1); j++)
                {
                    Console.Write(plato[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void toFile(string file)
        {
            string s = "";
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1) - 1; j++)
                {
                    s += matrice[i, j] + ",";
                }
                s += matrice[i, matrice.GetLength(1) - 1];
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
        public static char[,] toRead(string file)
        {
            try
            {
                string[] tab = File.ReadAllLines(file);
                char[,] plateau = new char[tab.Length - 1, tab.Length - 1];
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    for (int j = 0; j < tab[i].Length; j += 2)
                    {
                        plateau[i, j / 2] = (char)tab[i][j];
                    }
                }
                
                return plateau;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public bool TrouverMot(string mot,Joueur j)
        {
            int lignes = this.matrice.GetLength(0);
            int colonnes = this.matrice.GetLength(1);

            // Parcours de la dernière ligne
            for (int colonne = 0; colonne < colonnes; colonne++)
            {
                if (TrouverMotRec(this.matrice, mot, lignes - 1, colonne, 0))
                {
                    Console.WriteLine("Mot trouvé!");
                    j.Add_Mot(mot);
                    j.Update_Score();
                    return true;
                }
            }

            Console.WriteLine("Mot non trouvé.");
            return false;
        }

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
                              TrouverMotRec(tableau, mot, x - 1, y - 1, index+1) ||
                              TrouverMotRec(tableau, mot, x - 1, y + 1, index+1);
                if (trouve == false)
                {
                    tableau[x, y] = tmp;
                }
                return trouve;
            }

            return false;
        }
        public static void Defilement(char[,] matrice)
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
    }
}
