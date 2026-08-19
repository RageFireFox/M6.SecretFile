using System.ComponentModel;

namespace M6.SecretFile
{
    enum ShitRobots { [Description("Опущеные фекалисты")] LowShit, [Description("Ровные калосборы")] MidShit, [Description("Блатные черенки")] HighShit }
    internal class Crook : Liberator
    {

        private int _shit;
        public ShitRobots Level { get; set; }
        public Crook(string callsign = "Unknown", int id = 0, int shit = 0, ShitRobots level = ShitRobots.LowShit) 
            : base(callsign, id) {
            _shit = shit;
            Level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"\nUnit: {Callsign}\nID: {Id}\nShit level: {_shit}");

            if (Level == ShitRobots.LowShit)
                Console.WriteLine("He is lowshit.");
        }
    }
}
