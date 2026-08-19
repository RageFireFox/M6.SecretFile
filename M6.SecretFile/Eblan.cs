namespace M6.SecretFile
{
    internal class Eblan : Liberator, IGo
    {
        private string _purpose;

        public Eblan(string callsign = "Unknown", int id = 0, string purpose = "Unknown") 
            : base(callsign, id) {
            _purpose = purpose;
        }
        public override void Print() => 
            Console.WriteLine($"\nUnit: {Callsign}\nID: {Id}\nPurpose: {_purpose}");
    }
}
