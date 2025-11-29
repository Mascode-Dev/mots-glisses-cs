using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestUnitaire1
{

    internal class Dictionnaire
    {
        
        /// <summary>
        /// Accède au fichier Mots_Francais.txt
        /// </summary>
        /// <returns>Une liste de chaine de caractères contenant tous les mots de Mots_Francais.txt</returns>
        public static List<string> AccessDico()
        {
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
                }
                return wordList;
            }
            else
            {
                Console.WriteLine("File not found");
                return null;
            }
            
        }

        /// <summary>
        /// Affiche le nombre de mot commençant par chaque lettre, avec la langue du dictionnaire.
        /// </summary>
        /// <returns>Une chaine de caractère qui décrit le dictionnaire Mots_Francais.txt</returns>
        public static string toString()
        {
            Dictionary<char, int> wordCountByLetter = new Dictionary<char, int>();
            List<string> dico = AccessDico();
            if(dico != null)
            {
                for(int i = 0; i < dico.Count; i++)
                {
                    char firstLetter = char.ToUpper(dico[i][0]);//Prend la premiere lettre du mot en majuscule
                    if (wordCountByLetter.ContainsKey(firstLetter))//Si le dictionnaire contient déjà la clé premiere lettre
                    {
                        wordCountByLetter[firstLetter]++;
                    }
                    else
                    {
                        wordCountByLetter[firstLetter] = 1;
                    }

                }
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Langue : Français");
                sb.AppendLine("Nombre de mots par lettre:");
                foreach(var entry in wordCountByLetter)
                {
                    sb.AppendLine($"{entry.Key}: {entry.Value}");
                }
                
                return sb.ToString();
            }
            return null;
        }


        /// <summary>
        /// Recherche un element dans un tableau de manière dichotomique.
        /// </summary>
        /// <param name="tableau">C'est une liste de string, c'est la liste sur laquelle la recherche sera appliquée</param>
        /// <param name="elementRecherche">L'élement que l'on recherchera dans la liste, c'est un string</param>
        /// <returns>Un boolean qui a la valeur TRUE si le mot est dans la liste et FALSE dans le cas écheant.</returns>
        public static bool RechercheDichotomique(List<string> tableau, string elementRecherche)
        {
            TriFusion(tableau);
            int gauche = 0;
            int droite = tableau.Count - 1;

            while (gauche <= droite)
            {
                int milieu = (gauche + droite) / 2;
                int comparaison = String.Compare(tableau[milieu], elementRecherche);

                if (comparaison == 0)
                {
                    // L'élément a été trouvé
                    return true;
                }
                else if (comparaison < 0)
                {
                    // L'élément recherché est dans la moitié droite
                    gauche = milieu + 1;
                }
                else
                {
                    // L'élément recherché est dans la moitié gauche
                    droite = milieu - 1;
                }
            }

            // L'élément n'a pas été trouvé
            return false;
        }

        /// <summary>
        /// Créer une liste de taille "taille", cela nous permet de créer une liste avec une taille paramétré en avance.
        /// </summary>
        /// <typeparam name="T">Ce sera notre type de liste, il est personnalisable en fonction des applications. Dans notre cas ce sera des string.</typeparam>
        /// <param name="taille">C'est la taille de </param>
        /// <returns></returns>
        static List<T> CreerListeDeTailleN<T>(int taille)
        {
            List<T> maListe = new List<T>(taille);
            for (int i = 0; i < taille; i++)
            {
                maListe.Add(default(T)); // Utilise la valeur par défaut du type T
            }
            return maListe;
        }

        /// <summary>
        /// Cette méthode trie un tableau de manière récursive avec la méthode fusion
        /// </summary>
        /// <param name="array">C'est une liste de string qui sera trié</param>
        public static void TriFusion(List<string> array) 
        {
            if (array.Count <= 1)
            {
                return;
            }
            int milieu = array.Count / 2;
            List<string> gauche = CreerListeDeTailleN<string>(milieu);// crée un tableau de taille égale à la moitié droite du tableau array[]
            List<string> droite = CreerListeDeTailleN<string>(array.Count - milieu);// crée un tableau de taille égale à la moitié droite du tableau array[]

            for (int i = 0; i < milieu; i++)//Moitié gauche du tab origine dans gauche
            {
                gauche[i] = array[i];
            }
            for (int j = 0; j < array.Count - milieu; j++)
            {
                droite[j] = array[milieu + j];//Moitié droite du tab origine dans droite
            }
            //Tri récursivement gauche et droite
            TriFusion(gauche);
            TriFusion(droite);

            //Fusionne les deux moitiés triés
            Fusionner(array, gauche, droite);
        }

        /// <summary>
        /// La méthode assemble, fusionne deux tableaux
        /// </summary>
        /// <param name="resultat"></param>
        /// <param name="gauche">La moitié gauche du tableau</param>
        /// <param name="droite">La moitié droite du tableau</param>
        static void Fusionner(List<string> resultat, List<string> gauche, List<string> droite)
        {
            //initialisation des variables d'index des tableaux
            int iGauche = 0; 
            int iDroite = 0;
            int iRes = 0;
            //Tant qu'il y en a un des deux qui est non vide
            while (iGauche < gauche.Count && iDroite < droite.Count)//Tri et fusionne les deux tabs en un seul tab
            {
                if (string.Compare(gauche[iGauche], droite[iDroite]) < 0)//Si gauche > droite
                {
                    resultat[iRes] = gauche[iGauche];//on place
                    iGauche++;

                }
                else//si droite > gauche
                {
                    resultat[iRes] = droite[iDroite];//on place
                    iDroite++; 
                }
                iRes++;
            }
            while (iGauche < gauche.Count)// Met le reste des elements de gauche dans resultat
            {
                resultat[iRes] = gauche[iGauche]; 
                iGauche++;
                iRes++;
            }

            while (iDroite < droite.Count)//Met le reste des elements de droite dans resultat
            {
                resultat[iRes] = droite[iDroite];
                iDroite++;
                iRes++;
            }
        }


    }
}