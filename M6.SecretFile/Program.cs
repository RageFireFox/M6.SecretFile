using M6.SecretFile;

namespace m6
{
    class Program
    {
        static void Main()
        {

            Bible Koran = new Bible();
            Koran.access("Долбоеб", "Декстер Афанасьевич", "шадэ");
            Koran.print();

            Crook unit_crook = new Crook("Mellstroy", 10112, 100, ShitRobots.LowShit);
            unit_crook.print();
            unit_crook.LiberatorGo();

            Eblan Fedya = new Eblan("Федя", 01, "Дрочить");
            Fedya.print();
            Fedya.LiberatorJump();

            Liberator.Active();

        }


    }
}