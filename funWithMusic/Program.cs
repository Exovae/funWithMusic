using System;

namespace MusicProgram
{
    enum MusicGenre
    {
        Rock,
        Pop,
        HipHop,
        Jazz,
        Country
    }

    struct Music
    {
        public string Title;
        public string Artist;
        public string Album;
        private int length;
        public MusicGenre Genre;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Music(string title, string artist, string album, int length, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            this.length = length;
            Genre = genre;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Album: " + Album);
            Console.WriteLine("Length: " + Length + " minutes");
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string tempTitle, tempArtist, tempAlbum;
            int tempLength;
            MusicGenre tempGenre;

            Console.WriteLine("Enter information for the first song:");
            Console.Write("Enter music title: ");
            tempTitle = Console.ReadLine();

            Console.Write("Enter music artist: ");
            tempArtist = Console.ReadLine();

            Console.Write("Enter music album: ");
            tempAlbum = Console.ReadLine();

            Console.Write("Enter music length (in minutes): ");
            tempLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter music genre (0-Rock, 1-Pop, 2-HipHop, 3-Jazz, 4-Country): ");
            tempGenre = (MusicGenre)Convert.ToInt32(Console.ReadLine());

            Music music1 = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine();

            Console.WriteLine("Enter information for the second song:");
            Console.Write("Enter music title: ");
            tempTitle = Console.ReadLine();

            Console.Write("Enter music artist: ");
            tempArtist = Console.ReadLine();

            Console.Write("Enter music album: ");
            tempAlbum = Console.ReadLine();

            Console.Write("Enter music length (in minutes): ");
            tempLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter music genre (0-Rock, 1-Pop, 2-HipHop, 3-Jazz, 4-Country): ");
            tempGenre = (MusicGenre)Convert.ToInt32(Console.ReadLine());

            Music music2 = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine();

            Console.WriteLine("First Song:");
            music1.Display();

            Console.WriteLine("Second Song:");
            music2.Display();

            Console.ReadKey();
        }
    }
}
