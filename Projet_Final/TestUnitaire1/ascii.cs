using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire1
{
    internal class ascii
    {
        private string ch;

        public ascii(string ch)
        {
            this.ch = ch;
        }

        public static void toAscii(string ch)
        {

            string[] L2 = new string[42];
            L2[0] = "                \r\n                \r\n   ,---,        \r\n  '  .' \\       \r\n /  ;    '.     \r\n:  :       \\    \r\n:  |   /\\   \\   \r\n|  :  ' ;.   :  \r\n|  |  ;/  \\   \\ \r\n'  :  | \\  \\ ,' \r\n|  |  '  '--'   \r\n|  :  :         \r\n|  | ,'         \r\n`--''           \r\n                \r\n                ";
            L2[1] = "            \r\n            \r\n    ,---,.  \r\n  ,'  .'  \\ \r\n,---.' .' | \r\n|   |  |: | \r\n:   :  :  / \r\n:   |    ;  \r\n|   :     \\ \r\n|   |   . | \r\n'   :  '; | \r\n|   |  | ;  \r\n|   :   /   \r\n|   | ,'    \r\n`----'      \r\n            ";
            L2[2] = "            \r\n            \r\n  ,----..   \r\n /   /   \\  \r\n|   :     : \r\n.   |  ;. / \r\n.   ; /--`  \r\n;   | ;     \r\n|   : |     \r\n.   | '___  \r\n'   ; : .'| \r\n'   | '/  : \r\n|   :    /  \r\n \\   \\ .'   \r\n  `---`     \r\n            ";
            L2[3] = "              \r\n              \r\n    ,---,     \r\n  .'  .' `\\   \r\n,---.'     \\  \r\n|   |  .`\\  | \r\n:   : |  '  | \r\n|   ' '  ;  : \r\n'   | ;  .  | \r\n|   | :  |  ' \r\n'   : | /  ;  \r\n|   | '` ,/   \r\n;   :  .'     \r\n|   ,.'       \r\n'---'         \r\n              ";
            L2[4] = "           \r\n           \r\n    ,---,. \r\n  ,'  .' | \r\n,---.'   | \r\n|   |   .' \r\n:   :  |-, \r\n:   |  ;/| \r\n|   :   .' \r\n|   |  |-, \r\n'   :  ;/| \r\n|   |    \\ \r\n|   :   .' \r\n|   | ,'   \r\n`----'     \r\n           ";
            L2[5] = "           \r\n           \r\n    ,---,. \r\n  ,'  .' | \r\n,---.'   | \r\n|   |   .' \r\n:   :  :   \r\n:   |  |-, \r\n|   :  ;/| \r\n|   |   .' \r\n'   :  '   \r\n|   |  |   \r\n|   :  \\   \r\n|   | ,'   \r\n`----'     \r\n           ";
            L2[6] = "             \r\n             \r\n  ,----..    \r\n /   /   \\   \r\n|   :     :  \r\n.   |  ;. /  \r\n.   ; /--`   \r\n;   | ;  __  \r\n|   : |.' .' \r\n.   | '_.' : \r\n'   ; : \\  | \r\n'   | '/  .' \r\n|   :    /   \r\n \\   \\ .'    \r\n  `---`      \r\n             ";
            L2[7] = "             \r\n        ,--, \r\n      ,--.'| \r\n   ,--,  | : \r\n,---.'|  : ' \r\n|   | : _' | \r\n:   : |.'  | \r\n|   ' '  ; : \r\n'   |  .'. | \r\n|   | :  | ' \r\n'   : |  : ; \r\n|   | '  ,/  \r\n;   : ;--'   \r\n|   ,/       \r\n'---'        \r\n             ";
            L2[8] = "         \r\n         \r\n   ,---, \r\n,`--.' | \r\n|   :  : \r\n:   |  ' \r\n|   :  | \r\n'   '  ; \r\n|   |  | \r\n'   :  ; \r\n|   |  ' \r\n'   :  | \r\n;   |.'  \r\n'---'    \r\n         \r\n         ";
            L2[9] = "                 \r\n         ,---._  \r\n       .-- -.' \\ \r\n       |    |   :\r\n       :    ;   |\r\n       :        |\r\n       |    :   :\r\n       :         \r\n       |    ;   |\r\n   ___ l         \r\n /    /\\    J   :\r\n/  ../  `..-    ,\r\n\\    \\         ; \r\n \\    \\      ,'  \r\n  \"---....--'    \r\n                 ";
            L2[10] = "            \r\n       ,--. \r\n   ,--/  /| \r\n,---,': / ' \r\n:   : '/ /  \r\n|   '   ,   \r\n'   |  /    \r\n|   ;  ;    \r\n:   '   \\   \r\n|   |    '  \r\n'   : |.  \\ \r\n|   | '_\\.' \r\n'   : |     \r\n;   |,'     \r\n'---'       \r\n            ";
            L2[11] = "   ,--,    \r\n,---.'|    \r\n|   | :    \r\n:   : |    \r\n|   ' :    \r\n;   ; '    \r\n'   | |__  \r\n|   | :.'| \r\n'   :    ; \r\n|   |  ./  \r\n;   : ;    \r\n|   ,/     \r\n'---'      \r\n           \r\n           \r\n           ";
            L2[12] = "                 \r\n          ____   \r\n        ,'  , `. \r\n     ,-+-,.' _ | \r\n  ,-+-. ;   , || \r\n ,--.'|'   |  ;| \r\n|   |  ,', |  ': \r\n|   | /  | |  || \r\n'   | :  | :  |, \r\n;   . |  ; |--'  \r\n|   : |  | ,     \r\n|   : '  |/      \r\n;   | |`-'       \r\n|   ;/           \r\n'---'            \r\n                 ";
            L2[13] = "              \r\n         ,--. \r\n       ,--.'| \r\n   ,--,:  : | \r\n,`--.'`|  ' : \r\n|   :  :  | | \r\n:   |   \\ | : \r\n|   : '  '; | \r\n'   ' ;.    ; \r\n|   | | \\   | \r\n'   : |  ; .' \r\n|   | '`--'   \r\n'   : |       \r\n;   |.'       \r\n'---'         \r\n              ";
            L2[14] = "               \r\n    ,----..    \r\n   /   /   \\   \r\n  /   .     :  \r\n .   /   ;.  \\ \r\n.   ;   /  ` ; \r\n;   |  ; \\ ; | \r\n|   :  | ; | ' \r\n.   |  ' ' ' : \r\n'   ;  \\; /  | \r\n \\   \\  ',  /  \r\n  ;   :    /   \r\n   \\   \\ .'    \r\n    `---`      \r\n               \r\n               ";
            L2[15] = "            \r\n,-.----.    \r\n\\    /  \\   \r\n|   :    \\  \r\n|   |  .\\ : \r\n.   :  |: | \r\n|   |   \\ : \r\n|   : .   / \r\n;   | |`-'  \r\n|   | ;     \r\n:   ' |     \r\n:   : :     \r\n|   | :     \r\n`---'.|     \r\n  `---`     \r\n            ";
            L2[16] = "                 \r\n                 \r\n    ,----..      \r\n   /   /   \\     \r\n  /   .     :    \r\n .   /   ;.  \\   \r\n.   ;   /  ` ;   \r\n;   |  ; \\ ; |   \r\n|   :  | ; | '   \r\n.   |  ' ' ' :   \r\n'   ;  \\; /  |   \r\n \\   \\  ',  . \\  \r\n  ;   :      ; | \r\n   \\   \\ .'`--\"  \r\n    `---`        \r\n                 ";
            L2[17] = "            \r\n            \r\n,-.----.    \r\n\\    /  \\   \r\n;   :    \\  \r\n|   | .\\ :  \r\n.   : |: |  \r\n|   |  \\ :  \r\n|   : .  /  \r\n;   | |  \\  \r\n|   | ;\\  \\ \r\n:   ' | \\.' \r\n:   : :-'   \r\n|   |.'     \r\n`---'       \r\n            ";
            L2[18] = "             \r\n             \r\n  .--.--.    \r\n /  /    '.  \r\n|  :  /`. /  \r\n;  |  |--`   \r\n|  :  ;_     \r\n \\  \\    `.  \r\n  `----.   \\ \r\n  __ \\  \\  | \r\n /  /`--'  / \r\n'--'.     /  \r\n  `--'---'   \r\n             \r\n             \r\n             ";
            L2[19] = "        ,----, \r\n      ,/   .`| \r\n    ,`   .'  : \r\n  ;    ;     / \r\n.'___,/    ,'  \r\n|    :     |   \r\n;    |.';  ;   \r\n`----'  |  |   \r\n    '   :  ;   \r\n    |   |  '   \r\n    '   :  |   \r\n    ;   |.'    \r\n    '---'      \r\n               \r\n               \r\n               ";
            L2[20] = "               \r\n               \r\n               \r\n         ,--,  \r\n       ,'_ /|  \r\n  .--. |  | :  \r\n,'_ /| :  . |  \r\n|  ' | |  . .  \r\n|  | ' |  | |  \r\n:  | | :  ' ;  \r\n|  ; ' |  | '  \r\n:  | : ;  ; |  \r\n'  :  `--'   \\ \r\n:  ,      .-./ \r\n `--`----'     \r\n               ";
            L2[21] = "             \r\n             \r\n             \r\n       ,---. \r\n      /__./| \r\n ,---.;  ; | \r\n/___/ \\  | | \r\n\\   ;  \\ ' | \r\n \\   \\  \\: | \r\n  ;   \\  ' . \r\n   \\   \\   ' \r\n    \\   `  ; \r\n     :   \\ | \r\n      '---\"  \r\n             \r\n             ";
            L2[22] = "                 \r\n                 \r\n           .---. \r\n          /. ./| \r\n      .--'.  ' ; \r\n     /__./ \\ : | \r\n .--'.  '   \\' . \r\n/___/ \\ |    ' ' \r\n;   \\  \\;      : \r\n \\   ;  `      | \r\n  .   \\    .\\  ; \r\n   \\   \\   ' \\ | \r\n    :   '  |--\"  \r\n     \\   \\ ;     \r\n      '---\"      \r\n                 ";
            L2[23] = "                \r\n                \r\n ,--,     ,--,  \r\n |'. \\   / .`|  \r\n ; \\ `\\ /' / ;  \r\n `. \\  /  / .'  \r\n  \\  \\/  / ./   \r\n   \\  \\.'  /    \r\n    \\  ;  ;     \r\n   / \\  \\  \\    \r\n  ;  /\\  \\  \\   \r\n./__;  \\  ;  \\  \r\n|   : / \\  \\  ; \r\n;   |/   \\  ' | \r\n`---'     `--`  \r\n                ";
            L2[24] = "              \r\n              \r\n              \r\n        ,---, \r\n       /_ ./| \r\n ,---, |  ' : \r\n/___/ \\.  : | \r\n .  \\  \\ ,' ' \r\n  \\  ;  `  ,' \r\n   \\  \\    '  \r\n    '  \\   |  \r\n     \\  ;  ;  \r\n      :  \\  \\ \r\n       \\  ' ; \r\n        `--`  \r\n              ";
            L2[25] = "                \r\n         ,----, \r\n       .'   .`| \r\n    .'   .'   ; \r\n  ,---, '    .' \r\n  |   :     ./  \r\n  ;   | .'  /   \r\n  `---' /  ;    \r\n    /  ;  /     \r\n   ;  /  /--,   \r\n  /  /  / .`|   \r\n./__;       :   \r\n|   :     .'    \r\n;   |  .'       \r\n`---'           \r\n                ";
            L2[26] = "        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        \r\n        ";
            L2[27] = "   ,---,  \r\n,`--.' |  \r\n|   :  :  \r\n'   '  ;  \r\n|   |  |  \r\n'   :  ;  \r\n|   |  '  \r\n'   :  |  \r\n;   |  ;  \r\n`---'. |  \r\n `--..`;  \r\n.--,_     \r\n|    |`.  \r\n`-- -`, ; \r\n  '---`\"  \r\n          ";
            L2[28] = "  _.--,-```-.    \r\n /    /      '.  \r\n/  ../         ; \r\n\\  ``\\  .``-    '\r\n \\ ___\\/    \\   :\r\n       \\    :   |\r\n       |    ;  . \r\n      ;   ;   :  \r\n     /   :   :   \r\n     `---'.  |   \r\n      `--..`;    \r\n    .--,_        \r\n    |    |`.     \r\n    `-- -`, ;    \r\n      '---`\"     \r\n                 ";
            L2[29] = "       \r\n ___   \r\n/  .\\  \r\n\\  ; | \r\n `--\"  \r\n       \r\n       \r\n       \r\n       \r\n       \r\n ___   \r\n/  .\\  \r\n\\  ; | \r\n `--\"  \r\n       \r\n       ";
            L2[30] = "                \r\n  .--,-``-.     \r\n /   /     '.   \r\n/ ../        ;  \r\n\\ ``\\  .`-    ' \r\n \\___\\/   \\   : \r\n      \\   :   | \r\n       |  |   ; \r\n       .  `   . \r\n  ___ /   :   | \r\n /   /\\   /   : \r\n/ ,,/  ',-    . \r\n\\ ''\\        ;  \r\n \\   \\     .'   \r\n  `--`-,,-'     \r\n                ";
            L2[31] = "                \r\n    .-''-,--.   \r\n  .`     \\   \\  \r\n ;        \\.. \\ \r\n`    -'.  /'' / \r\n:   /   \\/___/  \r\n|   :   /       \r\n;   |  |        \r\n.   '  .        \r\n|   :   \\ ___   \r\n:   \\   /\\   \\  \r\n.    -,`  \\,, \\ \r\n ;        /`` / \r\n  `.     /   /  \r\n    `-,,-'--'   \r\n                ";
            L2[32] = "               \r\n               \r\n    ,----..    \r\n   /   /   \\   \r\n  /   .     :  \r\n .   /   ;.  \\ \r\n.   ;   /  ` ; \r\n;   |  ; \\ ; | \r\n|   :  | ; | ' \r\n.   |  ' ' ' : \r\n'   ;  \\; /  | \r\n \\   \\  ',  /  \r\n  ;   :    /   \r\n   \\   \\ .'    \r\n    `---`      \r\n               ";
            L2[33] = "           \r\n           \r\n     ,---, \r\n  ,`--.' | \r\n /    /  : \r\n:    |.' ' \r\n`----':  | \r\n   '   ' ; \r\n   |   | | \r\n   '   : ; \r\n   |   | ' \r\n   '   : | \r\n   ;   |.' \r\n   '---'   \r\n           \r\n           ";
            L2[34] = "               \r\n               \r\n      ,----,   \r\n    .'   .' \\  \r\n  ,----,'    | \r\n  |    :  .  ; \r\n  ;    |.'  /  \r\n  `----'/  ;   \r\n    /  ;  /    \r\n   ;  /  /-,   \r\n  /  /  /.`|   \r\n./__;      :   \r\n|   :    .'    \r\n;   | .'       \r\n`---'          \r\n               ";
            L2[35] = "                \r\n  .--,-``-.     \r\n /   /     '.   \r\n/ ../        ;  \r\n\\ ``\\  .`-    ' \r\n \\___\\/   \\   : \r\n      \\   :   | \r\n      /  /   /  \r\n      \\  \\   \\  \r\n  ___ /   :   | \r\n /   /\\   /   : \r\n/ ,,/  ',-    . \r\n\\ ''\\        ;  \r\n \\   \\     .'   \r\n  `--`-,,-'     \r\n                ";
            L2[36] = "             \r\n        ,--, \r\n      ,--.'| \r\n   ,--,  | : \r\n,---.'|  : ' \r\n;   : |  | ; \r\n|   | : _' | \r\n:   : |.'  | \r\n|   ' '  ; : \r\n\\   \\  .'. | \r\n `---`:  | ' \r\n      '  ; | \r\n      |  : ; \r\n      '  ,/  \r\n      '--'   \r\n             ";
            L2[37] = "       ,----,. \r\n     ,'   ,' | \r\n   ,'   .'   | \r\n ,----.'    .' \r\n |    |   .'   \r\n :    :  |--,  \r\n :    |  ;.' \\ \r\n |    |      | \r\n `----'.'\\   ; \r\n   __  \\  .  | \r\n /   /\\/  /  : \r\n/ ,,/  ',-   . \r\n\\ ''\\       ;  \r\n \\   \\    .'   \r\n  `--`-,-'     \r\n               ";
            L2[38] = "             \r\n             \r\n             \r\n    ,---.    \r\n   /     \\   \r\n  /    / '   \r\n .    ' /    \r\n'    / ;     \r\n|   :  \\     \r\n;   |   ``.  \r\n'   ;      \\ \r\n'   |  .\\  | \r\n|   :  ';  : \r\n \\   \\    /  \r\n  `---`--`   \r\n             ";
            L2[39] = "         ,----, \r\n       .'   .`| \r\n    .'   .'   ; \r\n  ,---, '    .' \r\n  |   :     ./  \r\n  ;   | .'  /   \r\n  `---' /  ;    \r\n    /  ;  /     \r\n   ;  /  /      \r\n  /  /  /       \r\n./__;  /        \r\n|   : /         \r\n;   |/          \r\n`---'           \r\n                \r\n                ";
            L2[40] = "   ,---.-,    \r\n  '   ,'  '.  \r\n /   /      \\ \r\n.   ;  ,/.  : \r\n'   |  | :  ; \r\n'   |  ./   : \r\n|   :       , \r\n \\   \\     /  \r\n  ;   ,   '\\  \r\n /   /      \\ \r\n.   ;  ,/.  : \r\n'   |  | :  ; \r\n'   |  ./   : \r\n|   :      /  \r\n \\   \\   .'   \r\n  `---`-'     ";
            L2[41] = "              \r\n   ,---.-,    \r\n  '   ,'  '.  \r\n /   /      \\ \r\n.   ;  ,/.  : \r\n'   |  | :  ; \r\n'   |  ./   : \r\n|   :       , \r\n \\   \\      | \r\n  `---`---  ; \r\n     |   |  | \r\n     '   :  ; \r\n     |   |  ' \r\n     ;   |.'  \r\n     '---'    \r\n              ";

            List<string[]> L = new List<string[]>();
            //Un int (numéro de la ligne) -> liste de string qui correspond à chaque lettre

            for (int i = 0; i < 42; i++) //Chaque ligne
            {
                L.Add(L2[i].Split(Environment.NewLine));
            }

            char[] lettre = ch.ToCharArray();
            int[] position = new int[lettre.Length];
            //Position des lettres dans l'alphabet
            for (int i = 0; i < lettre.Length; i++)
            {
                if (lettre[i] == ' ')
                {
                    position[i] = 26;
                }
                else if (lettre[i] == '!')
                {
                    position[i] = 27;
                }
                else if (lettre[i] == '?')
                {
                    position[i] = 28;
                }
                else if (lettre[i] == ':')
                {
                    position[i] = 29;
                }
                else if (lettre[i] == ')')
                {
                    position[i] = 30;
                }
                else if (lettre[i] == '(')
                {
                    position[i] = 31;
                }
                else if (lettre[i] == '0')
                {
                    position[i] = 32;
                }
                else if (lettre[i] == '1')
                {
                    position[i] = 33;
                }
                else if (lettre[i] == '2')
                {
                    position[i] = 34;
                }
                else if (lettre[i] == '3')
                {
                    position[i] = 35;
                }
                else if (lettre[i] == '4')
                {
                    position[i] = 36;
                }
                else if (lettre[i] == '5')
                {
                    position[i] = 37;
                }
                else if (lettre[i] == '6')
                {
                    position[i] = 38;
                }
                else if (lettre[i] == '7')
                {
                    position[i] = 39;
                }
                else if (lettre[i] == '8')
                {
                    position[i] = 40;
                }
                else if (lettre[i] == '9')
                {
                    position[i] = 41;
                }
                else
                {
                    lettre[i] = char.ToUpper(lettre[i]);
                    position[i] = lettre[i] - 'A';
                }
            }

            for (int j = 0; j < 16; j++) // Boucle chaque ligne
            {
                for (int i = 0; i < position.Length; i++) //Position des lettres concernées
                {
                    Console.Write(L[position[i]][j]);
                }
                Console.WriteLine();

            }
        }
    }
}