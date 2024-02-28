using System;
namespace Uppgift_6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BeräknaPoäng("5 7 7 5 5"));
        }
        static int BeräknaPoäng(string kort)
        {
            string[] kortArr = kort.Split(' ');
            Dictionary<int, int> antalLista = new Dictionary<int, int>();
            int x;
            
            for (int i = 0; i < kortArr.Length; i++)
            {
                int antal = 0;

                //Om kortet inte redan är i dictionaryn och är ett nummer:
                if (!antalLista.ContainsKey(int.Parse(kortArr[i])) && int.TryParse(kortArr[i], out x))
                {
                    foreach (string str in kortArr) //Kolla hur många gånger kortet finns
                    {
                        if (str == kortArr[i])
                        {
                            antal++;
                        } 
                    }
                    antalLista[int.Parse(kortArr[i])] = antal;
                }
            }

            int poäng = 0;
            foreach (int kortTal in antalLista.Keys)
            {
                poäng += (int)Math.Pow(kortTal, antalLista[kortTal]);
            }
            return poäng;
        }
    }
}