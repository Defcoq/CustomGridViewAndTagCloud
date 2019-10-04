using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGridViewAndTagCloud.Models
{
    public class DataContext
    {
        public List<GenreLookUp> GetAllGenre()
        {
            List<GenreLookUp> genres = new List<GenreLookUp>();
            GenreLookUp rock = new GenreLookUp() { GenreLookUpId = 1, GenreName = "Rock" };
            GenreLookUp jazz = new GenreLookUp() { GenreLookUpId = 2, GenreName = "Jazz" };
            GenreLookUp heavyMetal = new GenreLookUp() { GenreLookUpId = 3, GenreName = "Heavy Metal" };
            GenreLookUp blues = new GenreLookUp() { GenreLookUpId = 4, GenreName = "Blues" };
            GenreLookUp salsa = new GenreLookUp() { GenreLookUpId = 5, GenreName = "salsa" };
            GenreLookUp makossa = new GenreLookUp() { GenreLookUpId = 6, GenreName = "Makossa" };
            GenreLookUp assiko = new GenreLookUp() { GenreLookUpId = 7, GenreName = "Assiko" };
            GenreLookUp bikutsi = new GenreLookUp() { GenreLookUpId = 8, GenreName = "Bikutsi" };
            GenreLookUp benskin = new GenreLookUp() { GenreLookUpId = 9, GenreName = "Ben Skin" };
            GenreLookUp hippop = new GenreLookUp() { GenreLookUpId = 10, GenreName = "Hippop" };
            genres.Add(rock);
            genres.Add(jazz);
            genres.Add(heavyMetal);
            genres.Add(blues);
            genres.Add(salsa);
            genres.Add(makossa);
            genres.Add(assiko);
            genres.Add(bikutsi);
            genres.Add(benskin);
            genres.Add(hippop);

            return genres;

        }

        public List<Song> GetSong()
        {
            List<Song> songs = new List<Song>();
            for (int i = 0; i < 1000; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 1 });

            }

            for (int i = 1001; i < 1800; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 2 });

            }

            for (int i = 1802; i < 2400; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 3 });

            }
            for (int i = 2402; i < 2800; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 4 });

            }
            for (int i = 2802; i < 3000; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 5 });

            }
            for (int i = 3002; i < 3200; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 6 });

            }
            for (int i = 4000; i < 4500; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 7 });

            }
            for (int i = 4700; i < 5000; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 8 });

            }
            for (int i = 5500; i < 6000; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 9 });

            }
            for (int i = 6500; i < 7500; i++)
            {
                songs.Add(new Song() { SongId = i + 1, SongDescription = "Song_" + i, GenreId = 10 });

            }

            return songs;
        }

        public List<Artist> GetAllArtists()
        {

            List<Artist> artists = new List<Artist>();
            for (int i = 1; i < 30; i++)
            {
                artists.Add(new Artist() { UserName= "Artist_" +i, AvatarUrlSample= "https://i.pravatar.cc/150?img="+i , Country="Country_"+i, ProfileViews= i});
            }
            return artists;
        }
    }
}
