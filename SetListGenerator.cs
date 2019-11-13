using System;


class SetListGenerator
{
    static void Main(string[] args)
    {
        //How many possible songs to use
        const int SONG_LIST_SIZE = 4;

        //Declare an array of possible songs
        string[] songList = new string[SONG_LIST_SIZE];

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
            Console.WriteLine(songList[i]);
        }




        //["Song 1", "Song 2", "Song 3", "Song 4"];



    }
}
