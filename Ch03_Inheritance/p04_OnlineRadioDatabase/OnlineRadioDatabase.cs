using System.Collections.Generic;
using System.Linq;

namespace p04_OnlineRadioDatabase
{
    using System;

    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            List<Song> playList = new List<Song>();

            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split(';').Select(x => x.Trim()).ToArray();

                try
                {
                    Song newSong = new Song(input[0], input[1], input[2]);
                    playList.Add(newSong);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Songs added: {playList.Count}");

            int totalLength = playList.Count > 0 ? playList.Sum(x => x.TotalSongLengthInSeconds) : 0;
            int hours = totalLength / 3600;
            int min = (totalLength / 60) % 60;
            int sec = totalLength % 60;
            Console.WriteLine($"Playlist length: {hours}h {min}m {sec}s");


        }
    }
}
