using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {

            // A new List called goodSongs that references the Song class
            var goodSongs = new List<Song>();

            // A new HashSet called allSongs that references the Song class
            var allSongs = new HashSet<Song>();
            allSongs.Add(new Song { Artist = "Nickelback", Name = "How You Remind Me" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "Burn It To The Ground" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "Rockstar" });
            allSongs.Add(new Song { Artist = "Nickelback", Name = "If Today Was Your Last Day" });
            allSongs.Add(new Song { Artist = "Blink 182", Name = "All The Small Things" });
            allSongs.Add(new Song { Artist = "A Day To Remember", Name = "We Got This" });
            allSongs.Add(new Song { Artist = "New Found Glory", Name = "My Friend's Over You" });

            // Loop through the allSongs HashSet
            foreach (var song in allSongs)
            {

                // If statement to check if the Artist equals the string "Nickelback"
                // If it doesn't, then that Artist and Name gets added to the goodSongs List 
                if (song.Artist != "Nickelback")
                {
                    goodSongs.Add(song);
                }

            }

            // Loops through the goodSongs List and prints the Artist and Name to the console
            Console.WriteLine("These are the good bands:");
            foreach (var newGoodSong in goodSongs)
            {
                Console.WriteLine($"{newGoodSong.Artist}: {newGoodSong.Name}");
            }

            Console.ReadLine();

        }
    }
}
