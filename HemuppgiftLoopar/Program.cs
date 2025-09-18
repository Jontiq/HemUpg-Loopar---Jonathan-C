using System.Security.Cryptography.X509Certificates;

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
                //Console.WriteLine("Ge mig ett heltal: ");
                //int userNum = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine();
                //for (int i = 1; i <= 10; i++)
                //{
                //    Console.WriteLine($"{userNum} * {i} = {userNum * i}");
                //}
            }
            //Uppgift 3 - Skriv ett program som skapa en lista med siffror och räknar hur många gånger ett specifikt tal förekommer i listan.
            {
                //List<int> list = new List<int> { 1, 2, 3, 4, 3, 2, 2, 3, 5, 6, 2, 9, 7, 2, 3, 5, 8, 9, 6, 5, 3, 4, 5, 6 };
                //Console.WriteLine("Ge mig ett heltal: ");
                //int userNum = Convert.ToInt32(Console.ReadLine());
                //int Qty = 0;
                //foreach (int item in list)
                //{
                //    if (item == userNum)
                //    {
                //        Qty++;
                //    }
                //}
                //Console.WriteLine($"{userNum} finns {Qty} gånger i listan.");
            }
            //Uppgift 4
            {
                //List<int> nummer = new List<int>();
                //List<int> jämnaNummer = new List<int>();

                //for (int i = 0; i <= 100; i++)
                //{
                //    nummer.Add(i);
                //}

                //foreach(int num in nummer)
                //{
                //    if (num % 2 == 0)
                //    {
                //        jämnaNummer.Add(num);
                //        Console.WriteLine(num);
                //    }
                //}
            }
            //Uppgift 5
            {
                //Console.Write("New Password: ");
                //string userPassword = Console.ReadLine();
                //string specialCharacters = "!@#$%^&*()-_=+[{]};:’\"|\\,<.>/?";
                //bool oneSpecial = false;
                //bool oneUpper = false;
                //bool eightCharacters = false;
                //    //Kontrollerar att lösenord är 8 tecken eller mer
                //    if (userPassword.Length >= 8)
                //    {
                //        eightCharacters = true;
                //    }
                //    //Kontrollerar innehåll av specialtecken
                //    for (int i = 0; i < userPassword.Length; i++)
                //    {
                //        for (int j = 0;  j < specialCharacters.Length; j++)
                //        {
                //            if (userPassword[i] == specialCharacters[j])
                //            {
                //                oneSpecial = true;
                //            }
                //        }
                //    }
                //    //Kontrollerar innehåll av 1 uppercase
                //    for (int i = 0; i < userPassword.Length; i++)
                //    {
                //        if (char.IsUpper(userPassword[i]))
                //        {
                //            oneUpper = true;
                //            break;
                //        }
                //    }
                //    //Kontrollerar så att alla boolean värdena är sanna eller inte.
                //    if (oneSpecial == true && oneUpper == true && eightCharacters == true)
                //    {
                //        Console.WriteLine("Lösenord OK"); //om allt är sant
                //    }
                //    else
                //    {
                //        Console.WriteLine("Lösenord EJ OK"); // om något är falskt
                //    }
            }
            //Uppgift 6
            {
                //int[] massaTal = { 1, 5, 48, 5, 3, 6, 9, 3, 25, 4, 85, 28, 8 };
                //int max = 0;

                //for (int i = 0; i < massaTal.Length; i++)
                //{
                //    if (massaTal[i] > max)
                //    {
                //        max = massaTal[i];
                //    }
                //}
                //Console.WriteLine(max);
            }
        }
    }
}

