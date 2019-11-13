using System;


class SetListGenerator
{
    static void Main(string[] args)
    {
        //How many possible songs to use
        const int SONG_LIST_SIZE = 10;

        //Declare an array of possible songs
        string[] songList = new string[SONG_LIST_SIZE];

        //Random number generator
        var rnd = new Random();

        //Read in all songs
        for (int i = 0; i < SONG_LIST_SIZE; i = i + 1)
        {
            Console.Clear();
            Console.WriteLine("Add a song: ");
            songList[i] = Console.ReadLine();
        }

        //Print all songs back
        Console.Clear();
        Console.WriteLine("Your song list is: ");
        for (int i = 0; i < SONG_LIST_SIZE; i = i + 1)
        {
            //int j = rnd.Next(songList.Length);
            Console.WriteLine(songList[i]);
        }

        //Declare an empty array for our setlist indices
        Console.Clear();
        int setListLength;
        Console.WriteLine("How long is your setlist?");
        setListLength = int.Parse(Console.ReadLine());
        int[] setListNums = new int[setListLength];

        Console.Clear();

        //Randomly generate indices into setListNums
        for (int i = 0; i < setListLength; i = i + 1)
        {
            int j;
            j = (rnd.Next(0, songList.Length - 1));
            Console.WriteLine(j);
            //setListNums.SetValue(i, j);

        }

        //Console.WriteLine(songList.GetValue(j));
        //string[] setList = new string[setListLength];
        //Console.WriteLine("Your set list is: ");
        //Console.WriteLine(songList[j]);
        //["Song 1", "Song 2", "Song 3", "Song 4"];



    }
}
