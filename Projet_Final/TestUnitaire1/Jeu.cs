using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestUnitaire1
{
    internal class Jeu
    {
        private Plateau plateau;
        private Joueur j1;
        private Joueur j2;
        private int tempsParTour;
        private int tempsTotalDeJeu;


        public Jeu(int tempTour, int tempTot)
        {

            //Modifier le temps par tour et le temps total de jeu dans le constructeur
            this.j1 = new Joueur(null);
            this.j2 = new Joueur(null);
            this.tempsParTour =tempTour;
            this.tempsTotalDeJeu = tempTot;
            this.plateau = new Plateau(null);
        }

        /// <summary>
        /// La méthode vérifie si la matrice est vide
        /// </summary>
        /// <returns>La méthode renvoie un boolean, TRUE si la matrice est vide, FALSE dans le cas écheant.</returns>
        public bool EstVide()
        {
            for(int i = 0; i<this.plateau.Matrice.GetLength(0); i++)
            {
                for(int j = 0; j < this.plateau.Matrice.GetLength(1); j++) {
                    if (this.plateau.Matrice[i, j] != '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// Ceci correspond au scenario de jeu d'un joueur
        /// </summary>
        /// <param name="j">Le paramètre j est un objet de la classe joueur</param>
        /// <returns>Ceci renvoie un entier qui correspondera à </returns>
        public int JouerTour(Joueur j)
        {
            Stopwatch chronometre = new Stopwatch();
            Console.Clear();
            Console.WriteLine($"{j.Nom}, c'est à votre tour. Vous avez {this.tempsParTour} secondes.");

            // Ici, vous pouvez mettre la logique du tour du joueur, par exemple, la saisie d'une action.
            chronometre.Start();
            Plateau.toString(this.plateau.Matrice); //Affichage
            Console.WriteLine($"\nVous avez {j.Score} points.");
            Console.WriteLine("\nChoisissez un mot.");
            string mot=null;
            while (true)
            {
                while (!Console.KeyAvailable && chronometre.Elapsed.Seconds < this.tempsParTour)
                {
                    // Attend un court instant pour ne pas surcharger le processeur
                    Thread.Sleep(50);
                }
                int time = chronometre.Elapsed.Seconds;
                chronometre.Stop();

                // Vérifie si l'utilisateur a entré quelque chose
                if (Console.KeyAvailable)
                {
                    // Lit l'entrée de l'utilisateur

                    mot = Console.ReadLine().ToUpper();
                    Console.WriteLine("Vous avez entré : " + mot);
                }
                else
                {
                    Console.WriteLine("Temps écoulé. Aucune entrée utilisateur détectée.");
                    return time;
                }
                
                if (Dictionnaire.RechercheDichotomique(Dictionnaire.AccessDico(), mot)== true && j.ContientTab(mot) == false && this.plateau.TrouverMot(mot, j) == true)
                //Mot dans le dictionnaire + mot dans le plateau + n'a pas déjà été dit
                {

                    Plateau.Defilement(this.plateau.Matrice);
                    chronometre.Stop();
                    chronometre.Reset();
                    return time; //Interruption de la méthode
                }

                //Cas échéhant ->

                Console.WriteLine("\nLe mot n'est pas dans le dictionnaire ou déjà dit. Choisissez un mot correct.");
                chronometre.Start();
            }


            chronometre.Stop();
            chronometre.Reset();
        }

        public void Game()
        {
            // ETAPE 1 : GENERATION DU PLATO
            Console.WriteLine("Entrez la dimension du plateau (10 max)");
            int dim = Convert.ToInt32(Console.ReadLine());
            while (dim > 10 || dim <= 2)
            {
                Console.WriteLine("Entrez la dimension du plateau (2 min | 10 max)");
                dim = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Génération à partir du txt présent dans bin/debug/Net6.0 | OUI - NON");
            string mode_generation = Console.ReadLine();
            while(mode_generation != "OUI" && mode_generation != "NON")
            {
                Console.WriteLine("Génération à partir du txt présent dans bin/debug/Net6.0 | OUI - NON");
                mode_generation = Console.ReadLine();
            }

            if (mode_generation == "OUI") //A partir d'un file
            {
                //Plateau.toRead -> char[,]
                this.plateau.Matrice = Plateau.toRead("tableau1.txt");
                
            }
            else //Aléatoirement
            {
                this.plateau.Matrice = new Plateau(dim, dim).Matrice;
            }
            //char[,] plateau = plato.Matrice;

            //ETAPE 2 : DEFINITION DES JOUEURS & INITIALISATION DES TIMERS
            Console.WriteLine("Entrez le pseudo du Joueur 1");
            string j1 = Console.ReadLine();

            Console.WriteLine("Entrez le pseudo du Joueur 2");
            string j2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Création des profils des joueurs : {j1} et {j2}");
            Joueur joueur1 = new Joueur(j1);
            Joueur joueur2 = new Joueur(j2);

            int tempsEcoule = 0;

            //ETAPE 3 : SCENIARIO
            while (this.EstVide() || tempsEcoule < this.tempsTotalDeJeu)
            {
                // Tour du Joueur 1
                int time = JouerTour(joueur1);
                tempsEcoule += time;
                Thread.Sleep(1500);

                //Tour du joueur 2
                time = JouerTour(joueur2);
                tempsEcoule += time;
                Thread.Sleep(1500);
            }
            string gagnant;
            int max = Math.Max(joueur1.Score, joueur2.Score);
            if (max==joueur1.Score)
            {
                gagnant = joueur1.Nom;
            }
            else
            {
                gagnant = joueur2.Nom;
            }

            //---------------------------------------------//
            ascii.toAscii("GG WP");
            Console.WriteLine();
            Console.WriteLine();
            ascii.toAscii(gagnant);
            ascii.toAscii($"{joueur1.Score} : {joueur2.Score}");

        }
    }
}
