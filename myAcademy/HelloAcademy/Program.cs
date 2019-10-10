using HelloAcademy.Entities;
using HelloAcademy.Utils;
using System;

namespace HelloAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // => "HelloAcademy publish test"
            //args[0] = "publish"
            //args[1] = "test"

            //1) Parte il programma

            //2) Mostrare un menu utente
            
           

            //creo una variabile di controllo
            bool verifica = false;

            //Selezione della funzione da avviare
            do
            {
                menu.mostraMenu();
                var selezione = ConsoleUtils.LeggiNumeroInteroDaConsole(0, 3);
                switch (selezione)
                {
                    case 1:
                        FunzioniMatematiche.RecuperaDivisioneEDividendoEDividi();
                        verifica = true;
                        break;
                    case 2:
                        FunzioniRubrica.InserisciPersoneEMostraRubrica();
                        verifica = true;
                        break;
                    case 3:
                        FunzioniRubrica.InserisciNumeroArbitrarioPersoneInRubrica();
                        verifica = true;
                        break;
                    case 0:
                        Console.WriteLine("Uscita....");                        
                        verifica = false;
                        break;
                    default:
                        Console.WriteLine("Selezione non valida");
                        break;
                }
            }
            while (verifica == true);

            
           

            //3) Se premo 1, parte "RecuperaDivisioneEDividendoEDividi"

            //4) Se premo 2, parte "InserisciPersoneEMostraRubrica"

            //5) Se premo 3, parte "InserisciNumeroArbitrarioPersoneInRubrica"


            //FunzioniMatematiche.RecuperaDivisioneEDividendoEDividi();

            //FunzioniRubrica.InserisciPersoneEMostraRubrica();

            //FunzioniRubrica.InserisciNumeroArbitrarioPersoneInRubrica();

        }

        
    }    
}
