using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Album
{
    public string albumName { get; set; }
    public string artistName { get; set; }
    public string title { get; set; }


public void ReadAlbumName()
{
        bool isValidAlbum = false;
        while (!isValidAlbum)
        { 
        Console.WriteLine("Enter album name: ");
        string albumNameInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(albumNameInput))
            {
            this.albumName = albumNameInput;
            isValidAlbum = true;
                
            }
            else
            {
            Console.WriteLine("Please use letters!!");
            }
        
        bool isValidArtist = false;
        while (!isValidArtist) 
            {
        Console.WriteLine("Enter Artist: ");
        string artistNameInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(artistNameInput))
                {
                    this.artistName = artistNameInput;
                    isValidArtist = true;
                }
                else
                {
                    Console.WriteLine("Please use letters!");
                }

        this.albumName = Console.ReadLine();
        //Console.WriteLine("Enter number of tracks");

    }
    }
    }
}



