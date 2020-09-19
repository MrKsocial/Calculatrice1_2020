using System;

namespace calculatriceConsole
{
    class Program
    {
        static void Main()
        {
            Double soluce = 0;
        start:
            Double nbre=0;
            Double nbre2 = 0;
            
            String operation = "";
            

            if (soluce == 0)
            {
                Console.WriteLine("Ecrivez un nombre.");
                nbre = double.Parse(Console.ReadLine());

                Console.WriteLine("Ecrivez un opérateur de calcul.");
                operation = Console.ReadLine();

                Console.WriteLine("Ecrivez un nombre.");
                nbre2 = double.Parse(Console.ReadLine());
            }

            else if(soluce !=0)
            {
                nbre = soluce;
                nbre2 = 0;
                Console.WriteLine("Votre solution "+soluce+" Ecrivez un opérateur de calcul.");
                operation = Console.ReadLine();

                Console.WriteLine("Ecrivez un nombre.");
                nbre2 = double.Parse(Console.ReadLine());
            }
            

            switch (operation)
            {
                case "+":
                    soluce=nbre + nbre2;
                    nbre = 0;
                    nbre2 = 0;
                    operation = "";
                    Console.WriteLine("Votre solution : " + soluce);
                    goto start;
                    
                case "-":
                    soluce = nbre - nbre2;
                    nbre = 0;
                    nbre2 = 0;
                    operation = "";
                    Console.WriteLine("Votre solution : " + soluce);
                    goto start;
                case "*":
                    soluce = nbre * nbre2;
                    nbre = 0;
                    nbre2 = 0;
                    operation = "";
                    Console.WriteLine("Votre solution : " + soluce);
                    goto start;
                case "/":
                    soluce = nbre / nbre2;
                    nbre = 0;
                    nbre2 = 0;
                    operation = "";
                    Console.WriteLine("Votre solution : " + soluce);
                    goto start;
                default:
                    nbre = 0;
                    nbre2 = 0;
                    operation = "";
                    goto start;
                    //break;
                    

            }
        }
    }
}
