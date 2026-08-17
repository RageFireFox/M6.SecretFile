namespace M6.SecretFile
{
    internal class Eblan : Liberator, IGo
    {
        private string purpose;

        public Eblan() { }
        public Eblan(string callsign, int id, string purpose) : base(callsign, id)
        {
            this.purpose = purpose;
        }

        public override void print()
        {
            Console.WriteLine($"\nUnit: {this.Callsign}\nID: {this.Id}\nPurpose: {this.purpose}");
        }
    }


}
