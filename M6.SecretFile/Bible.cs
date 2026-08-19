namespace M6.SecretFile
{
    struct Bible
    {
        private string _title, _author, _intro;
        private short _pages;

        public void Access(string title, string author, string intro) {
            _title = title;
            _author = author;
            _intro = intro;
        }

        public void Print()
        {
            Console.WriteLine($"{_author} написал книгу \"{_title}\"");
        }
    }
}
