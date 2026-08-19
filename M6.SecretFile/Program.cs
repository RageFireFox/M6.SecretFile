using M6.SecretFile;

namespace m6
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Bible Koran = new Bible();
            Koran.Access("Долбоеб", "Декстер Афанасьевич", "шадэ");
            Koran.Print();

            Crook unit_crook = new Crook("Mellstroy", 10112, 100, ShitRobots.LowShit);
            unit_crook.Print();
            unit_crook.LiberatorGo();

            Eblan Fedya = new Eblan("Федя", 01, "Дрочить");
            Fedya.Print();
            Fedya.LiberatorJump();

            Liberator.Active();

        }


    }
}