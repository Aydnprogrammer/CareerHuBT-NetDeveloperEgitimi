using System.Diagnostics;

namespace _01.MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmini Oyununa Hoşgeldiniz");
            Random random = new Random();
            int TargetNumber = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("Hazırsanız 1 ile 101 Arasında Bir Sayı Girin Ve Tuttuğum Sayıyı Bulmaya Çalışın");
                string input = Console.ReadLine();
                int myGuess = Convert.ToInt32(input);

                if (myGuess == TargetNumber)
                {
                    Console.WriteLine("Tebrik Ederimm Tuttuğum Sayıyı Bildiniz :)");
                    Console.ReadLine();
                    Console.WriteLine("Tekrar Oynamak İster Misiniz?");

                }
                else if (myGuess > TargetNumber)
                {
                    if (myGuess - 1 == TargetNumber)
                    {
                        Console.WriteLine("Vay Be Çok Yaklaştın Senin Yerinde Olsaydım Sayıyı Bir Azaltırdım");
                    }
                    else
                    {
                        Console.WriteLine("Tuttuğum Sayıdan Daha Büyük Bir Tahminde Bulundunuz");
                    }
                }
                else if (myGuess < TargetNumber)
                {
                    if (myGuess + 1 == TargetNumber)
                    {
                        Console.WriteLine("Hmm Çok Yaklaştın Ben Sen Olsaydım Eğer Sayıyı Bir Arttırırdım");
                    }
                    else
                    {
                        Console.WriteLine("Tuttuğum sayıdan daha küçük bir tahminde bulundunuz");
                    }
                }


            }

        }
    }
}
