namespace M6.SecretFile
{
    abstract class Liberator : IGo, IJump
    {
        private const int MINID = 1;
        private const int MAXID = 5000;

        public static int activeduty;
        private string _callsign;
        private int _id;
        private byte[] _targets;
        private bool _jetpack;

        public string Callsign => _callsign;   
        public bool Jetpack => _jetpack; 
        public byte[] Targets => _targets;
        public int Id {
            get => _id;
            set => _id = (value >= MINID && value <= MAXID) ? 0 : value;
        }
        
        public float Speed { get; set; }
        public float Y { get; set; }

        public Liberator(string callsign = "Unknown", int id = 0, byte[] targets = null, bool jetpack = false) {
            Access(callsign, id, targets ?? Array.Empty<byte>(), jetpack);
            activeduty++;
        }
        public void Access(string callsign, int id, byte[] targets, bool jetpack) {
            _callsign = callsign;
            _id = id;
            _targets = targets;
            _jetpack = jetpack;
        }

        public abstract void Print();

        public static void Active() => Console.WriteLine($"\nActive liberators: {activeduty}");
        public void LiberatorGo() => Console.WriteLine("Liberator is moving");
        public void LiberatorJump() => Console.WriteLine("Liberator is jumping");
        
    }

}
