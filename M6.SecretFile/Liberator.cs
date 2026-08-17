namespace M6.SecretFile
{
    abstract class Liberator : IGo, IJump
    {

        public static int activeduty;
        private string callsign;
        private int id;
        private byte[] targets;
        private bool jetpack;
        protected string creator;

        public string Callsign
        {
            get
            {
                return callsign;
            }
            private set { }
        }

        public bool Jetpack
        {
            get
            {
                return jetpack;
            }
            private set { }
        }

        public byte[] Targets
        {
            get
            {
                return targets;
            }
            private set { }
        }

        public int Id
        {
            get
            {
                Console.WriteLine($"Результат: ");
                return this.id;
            }

            set
            {
                if (value < 1)
                    this.id = 0;
                else if (value > 5000) this.id = 0;
                else this.id = value;
            }
        }

        public float speed { get; set; }
        public float y { get; set; }

        public Liberator(string callsign, int id, byte[] targets, bool jetpack)
        {
            access(callsign, id, targets, jetpack);
            activeduty++;
        }

        public Liberator(string callsign, int id, byte[] targets)
        {
            access(callsign, id, targets);
            activeduty++;
        }

        public Liberator(string callsign, int id)
        {
            access(callsign, id);
            activeduty++;
        }
        public Liberator(string callsign)
        {
            access(callsign);
            activeduty++;
        }

        public Liberator(int id)
        {
            access(id);
            activeduty++;
        }




        public Liberator() { activeduty++; }
        public void access(string callsign, int id, byte[] targets, bool jetpack)
        {
            this.callsign = callsign;
            this.id = id;
            this.targets = targets;
            this.jetpack = jetpack;
        }

        public void access(string callsign, int id, byte[] targets)
        {
            this.callsign = callsign;
            this.id = id;
            this.targets = targets;

        }

        public void access(string callsign, int id)
        {
            this.callsign = callsign;
            this.id = id;

        }

        public void access(string callsign)
        {
            this.callsign = callsign;
        }

        public void access(int id)
        {
            this.id = id;

        }

        public abstract void print();

        public static void Active()
        {
            Console.WriteLine($"\nActive liberators: {activeduty}");
        }

        public void LiberatorGo()
        {
            Console.WriteLine("Liberator is moving");
        }

        public void LiberatorJump()
        {
            Console.WriteLine("Liberator is jumping");
        }
    }

}
