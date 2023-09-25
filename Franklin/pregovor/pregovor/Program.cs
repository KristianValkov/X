namespace pregovor
{
    internal class Program
    {
        static void Main()
        {
            //kolko dushi ste v chas
            
            int x;
            do
            {
                Console.WriteLine("Kolko choveka ste v chas?");
                x = int.Parse(Console.ReadLine());
                if (x < 1)
                {
                    Console.WriteLine("tvurde malko ste");
                }
                else
                if (x > 14)
                {
                    Console.WriteLine("tvurde mnogo ste");
                }
                else
                if (x>1&x<=14)
                {
                    Console.WriteLine("Koi e umen?");
                }
                else
                {
                    Console.WriteLine("Nevalidno chislo");
                }
            }
            while (x<1 & x>=14);
            




        }
    }
}