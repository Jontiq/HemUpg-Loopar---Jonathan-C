using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HemuppgiftLoopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 1 - Skriv ett program som läser in heltal och summerar dem. Anta att inmatningen avslutas med 0.
            {
                //static void SumNumbers()
                //{
                //    int sum = 0;
                //    int number;
                //    do
                //    {
                //        Console.Write("Ange ett heltal (0 för att avsluta): ");
                //        number = Convert.ToInt32(Console.ReadLine());
                //        sum += number;
                //    } while (number != 0);
                //    Console.WriteLine($"Summan av de inmatade talen är: {sum}");
                //}
                //SumNumbers();
            }
            //Uppgift 2 - Skriv ett C# program som ber användaren att ange ett heltal och skriver ut multiplikationstabellen för det talet (1-10).
            {
                //static void MultiplicationTable()
                //{
                //    Console.WriteLine("Ge mig ett heltal: ");
                //    int usernum = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine();
                //    for (int i = 1; i <= 10; i++)
                //    {
                //        Console.WriteLine($"{usernum} * {i} = {usernum * i}");
                //    }
                //}
                //MultiplicationTable();
            }
            //Uppgift 3 - Skriv ett program som skapa en lista med siffror och räknar hur många gånger ett specifikt tal förekommer i listan.
            {
                //static void ListCount()
                //{
                //    List<int> list = new List<int> { 1, 2, 3, 4, 3, 2, 2, 3, 5, 6, 2, 9, 7, 2, 3, 5, 8, 9, 6, 5, 3, 4, 5, 6 };
                //    Console.WriteLine("Ge mig ett heltal: ");
                //    int userNum = Convert.ToInt32(Console.ReadLine());
                //    int count = 0;
                //    foreach (int num in list)
                //    {
                //        if (num == userNum)
                //        {
                //            count++;
                //        }
                //    }
                //    Console.WriteLine($"\"{userNum}\" finns {count} gånger i listan.");
                //}
                //ListCount();
            }
            //Uppgift 4 - Skriv ett program som skapar en lista med heltal och använder en foreach-loop som skapar en ny lista som bara innehåller de tal som är jämna.
            {
                //static void EvenNumbers()
                //{
                //    List<int> nummer = new List<int>();
                //    List<int> jämnaNummer = new List<int>();

                //    //Skapar en lista med tal 0-100
                //    for (int i = 0; i <= 100; i++)
                //    {
                //        nummer.Add(i);
                //    }
                //    //Kollar igenom listan och lägger till jämna tal i en ny lista
                //    foreach (int num in nummer)
                //    {
                //        if (num % 2 == 0)
                //        {
                //            jämnaNummer.Add(num);
                //            Console.WriteLine(num);
                //        }
                //    }
                //}
                //EvenNumbers();
            }
            //Uppgift 5 Skriv ett c#-program som ber användaren att ange ett lösenord och kontrollerar om det är giltigt eller ogiltigt. Programmet ska innehålla tre booleska metoder.
            {
                //static void PasswordValidator()
                //{
                //    //Ber användaren om lösenord
                //    Console.Write("New Password: ");
                //    string userPassword = Console.ReadLine();

                //    // Kontrollerar att lösenord är 8 tecken eller mer
                //    static bool ValidLength(string password)
                //    {
                //        // Kontrollerar att lösenord är 8 tecken eller mer
                //        return password.Length >= 8;
                //    }

                //    // Kontrollerar innehåll av minst ett specialtecken
                //    static bool CheckSpecial(string password)
                //    {
                //        string specialCharacters = "!@#$%^&*()-_=+[{]};:'\"|\\,<.>/?";
                //        foreach (char c in password)
                //        {
                //            if (specialCharacters.Contains(c))
                //            {
                //                return true;
                //            }
                //        }
                //        return false;
                //    }

                //    // Kontrollerar innehåll av minst en versal
                //    static bool CheckVersal(string password)
                //    {
                //        foreach (char c in password)
                //        {
                //            if (char.IsUpper(c))
                //                return true;
                //        }
                //        return false;
                //    }

                //    // Anropar alla  metoder för att validera lösenordet
                //    bool eightCharacters = ValidLength(userPassword);
                //    bool oneSpecial = CheckSpecial(userPassword);
                //    bool oneUpper = CheckVersal(userPassword);

                //    // Skriver ut resultatet av valideringen
                //    if (eightCharacters && oneSpecial && oneUpper)
                //    {
                //        Console.WriteLine("Lösenord OK");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Lösenord EJ OK");
                //    }
                //}
                //PasswordValidator();
            }
            //Uppgift 6 - Skriv ett program som använder en for-loop för att hitta det största talet i en array av heltal.
            {
                //static void FindMax()
                //{
                //    int[] massaTal = { 1, 5, 48, 5, 3, 6, 9, 3, 25, 4, 85, 28, 8 };
                //    int max = 0;
                //    // För varje tal i massaTal, kontrollera om talet är större än max. Om sant, sätt max till det talet.
                //    for (int i = 0; i < massaTal.Length; i++)
                //    {
                //        if (massaTal[i] > max)
                //        {
                //            max = massaTal[i];
                //        }
                //    }
                //    Console.WriteLine(max);
                //}
                //FindMax();
            }
        }
    }
}

