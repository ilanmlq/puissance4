using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ILAN MALEQ 2/09/2021 CSV_GENERATOR V1
namespace CSV_generator
{
    class Program
    {
        const int MIN_LINE_NB = 1;
        const int MAX_LINE_NB = 10;
        const int MAX_COLUMNS_NB = 3;
        const int MIN_RND_NB = 0;
        const int MAX_RND_NB = 100;
        const string SEPARATOR = ";";
        const string OPERATOR = "=MOYENNE(";
        
        static void Main(string[] args)
        {
            string formule = ""; 
            Random rnd1 = new Random();
            
            for (int line = 0; line < MAX_LINE_NB; line++)
            {
                for (int column = 0; column < MAX_COLUMNS_NB; column++)
                {
                    // le +1 est pour que le nombre s'arrete pas au nombre juste avant
                    Console.Write(rnd1.Next(MIN_RND_NB, MAX_RND_NB +1));
                    // le -1 est pour qu'il est pas de separateur au dernier 
                    if (column != MAX_COLUMNS_NB - 1)
                    {
                        Console.Write(SEPARATOR);
                    }
                }
                Console.WriteLine();

                
            }
            for (int column = 0; column < 1; column++)
            {
                for (char lettre = 'A'; lettre - 'A' < MAX_COLUMNS_NB; lettre++)
                {
                    formule = OPERATOR + lettre + MIN_LINE_NB.ToString() + ":" + lettre + MAX_LINE_NB.ToString() + ")";
                    Console.Write(formule);
                    if (column != MAX_COLUMNS_NB - 1)
                    {
                        Console.Write(SEPARATOR);
                    }
                }
            }
            
            //Console.WriteLine((char)('A' + 1));
            Console.WriteLine();
        }
    }
}
