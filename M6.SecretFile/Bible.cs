namespace M6.SecretFile
{
    struct Bible
    {
        private string title, author, intro;

        private short pages;

        public void access(string title, string author, string intro)
        {
            this.title = title;
            this.author = author;
            this.intro = intro;
        }

        public void print()
        {
            Console.WriteLine(author + " написал книгу " + '"' + title + '"');
        }
    }
}
