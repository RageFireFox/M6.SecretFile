using System.ComponentModel;

namespace M6.SecretFile
{
    enum ShitRobots { [Description("Опущеные фекалисты")] LowShit, [Description("Ровные калосборы")] MidShit, [Description("Блатные черенки")] HighShit }
    internal class Crook : Liberator
    {

        private int shit;

        public ShitRobots level;

        public Crook() { }
        public Crook(string callsign, int id, int shit, ShitRobots level) : base(callsign, id)
        {
            this.shit = shit;
            this.level = level;
        }

        public override void print()
        {
            Console.WriteLine($"\nUnit: {this.Callsign}\nID: {this.Id}\nShit level: {this.shit}");

            if (this.level == ShitRobots.LowShit)
            {
                Console.WriteLine("He is lowshit.");
            }
        }

    }


}
