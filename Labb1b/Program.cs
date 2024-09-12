namespace Labb1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //string tal = "29535123p48723487597645723645";
            
            // Skriver ut en uppmaning till användaren att mata in en textsträng.
            Console.WriteLine("Mata in en textsträng: ");

            //Läser in strängen från användaren och sparar den i variabeln ´tal`.
              string tal = Console.ReadLine();


            //En metod som hittar och skriver ut i tur och ordning av samma siffra i strängen.
            static void HittaTal (string tal)
            {
                //Skapar en variabel som kommer att användas för att spara den aktuella ordningen av siffror. 
                string subString = tal; 
                
                // Här loopar vi igenom varje tecken i strängen `tal`.
                for (int i = 0; i < tal.Length; i++)
                {
                    //Kontrollerar vi om det aktuella tecknet är en siffra.
                    if (char.IsDigit(tal[i]))
                    {
                        //Här sparar vi den aktuella siffran som vi söker efter i variabeln `sparaSiffran`.
                        char sparaSiffra = tal[i];
                        
                        //Här startar vi en ny loop för att leta efter fler av samma siffra.
                        for (int j = i + 1; j < tal.Length; j++)
                        {
                            //Kontrollerar om tecknet vid position `j` inte är en siffra, då ska den avsluta (break) den inre loopen.
                            if (!char.IsDigit(tal[j])) 
                            
                            {
                                break;
                            }
                            //Kontrollerar om tecknet vid position `j` är samma som den sparade siffran.
                            //Här skapar och skriver vi ut i tor oc ordning, innan, under och efter den funna ordningen.
                            if (tal[j] == sparaSiffra)
                            {
                                //Här skapar vi en sträng som heter `innan` som innehåller allt före den aktuella ordningen.
                                string innan = tal.Substring(0, i);

                                //Här skapar vi en till sträng som heter `efter` som innehåller allt efter den aktuella ordningen.
                                string efter = tal.Substring(j + 1);

                                //Här sparar vi den aktuella ordningen i `subString`.
                                subString = tal.Substring(i, j - i + 1);

                                //Här skriver vi ut strängen som heter `innan` och behåller den som den är.
                                Console.Write(innan);       
                                
                                //Här väljer vi färg för att markera den aktuella ordningen.
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                //Här skriver vi ut den aktuella ordningen.
                                Console.Write(subString);

                                //Här återställer vi färgen till standard.
                                Console.ResetColor();

                                //Här skriver vi ut strängen som heter `efter` utan formatering.
                                Console.WriteLine(efter);


                            }

                        }
                    }
                }
            }
            //Här anropar vi metoden `HittaTal` med den inmatade strängen.
            HittaTal(tal);

        }
    }
}
