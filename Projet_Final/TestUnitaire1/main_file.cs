using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace TestUnitaire1
{
    public class TU
    {
        public static void Main(string[] args)
        {
            Jeu jeu = new Jeu(10,60); //Respectivement le temps par tour et le temps total en seconde
            jeu.Game();
        }
    }
}