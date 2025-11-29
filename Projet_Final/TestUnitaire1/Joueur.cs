using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire1
{
    internal class Joueur
    {
        private string nom;
        private int score;
        private List<string> mot;

        public Joueur(string nom)
        {
            this.nom = nom;
            this.score = 0;
            this.mot = new List<string>();
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public List<string> Mot
        {
            get { return mot; }
            set { mot = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        /// <summary>
        /// La fonction ajoute un mot à la liste de mot du joueur concerné
        /// </summary>
        /// <param name="ch">La chaine de caractère à ajouter</param>
        public void Add_Mot(string ch)
        {
            this.mot.Add(ch);
        }

        /// <summary>
        /// Liste les caractéristiques du joueurs.
        /// </summary>
        /// <returns>Une chaîne de caractères qui contient le nom, score, et la liste de mot du joueur concerné</returns>
        public string toString()
        {
            string ch = "";
            for (int i = 0; i < this.mot.Count; i++)
            {
                ch += $"{this.mot[i]} ";
            }
            return $"Joueur\nNom : {this.nom}\nScore : {this.score}\nMot : {ch}";
        }

        /// <summary>
        /// Réinitialise le score du joueur pour le recalculer en fonction de la longueur des mots de la liste.
        /// </summary>
        public void Update_Score()
        {
            this.score = 0;
            for(int i = 0; i < this.mot.Count; i++)
            {
                this.score += this.mot[i].Length; //1 lettre => 1 point
            }
        }

        /// <summary>
        /// Vérifie si un mot est bien dans la liste de mot du joueur concerné
        /// </summary>
        /// <param name="mot">la chaine de caractère à tester</param>
        /// <returns>un booléen qui indique si OUI ou NON, mot est présent dans la liste.</returns>
        public bool ContientTab(string mot)
        {
            for(int i = 0; i < this.mot.Count; i++)
            {
                if (this.mot[i] == mot)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
