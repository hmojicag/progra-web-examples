using System.Collections.Generic;
using RazorPagesHelloWorld.Models;

namespace RazorPagesHelloWorld.Data {
    public class SongsRepository {
        public static List<Song> Songs { get; set; }

        static SongsRepository() {
            Songs = new List<Song>();
            
            Songs.Add(new Song() {
                Id = 1,
                Name = "Birth Of Venus Illegitima",
                Album = "Vovin",
                Artist = "Therion",
                AlbumCoverURL = "https://3.bp.blogspot.com/-LIg5SzOqiF8/T-Kfwzwk4pI/AAAAAAAAASA/AT8ZtVbcQZA/s1600/Front.jpg"
            });
            
            Songs.Add(new Song() {
                Id = 2,
                Name = "Young Folks",
                Album = "Writer's Block",
                Artist = "Peter Bjorn and John",
                AlbumCoverURL = "https://upload.wikimedia.org/wikipedia/en/7/77/PB%26Jyoung_folks.JPG"
            });
            
            Songs.Add(new Song() {
                Id = 3,
                Name = "Driving to Heaven",
                Album = "Elements of Live",
                Artist = "Tiesto",
                AlbumCoverURL = "https://i.ytimg.com/vi/MyHlmGA5uHM/0.jpg"
            });
            
            Songs.Add(new Song() {
                Id = 4,
                Name = "Source",
                Album = "Crab in Honey",
                Artist = "Fever the Ghost",
                AlbumCoverURL = "https://images.genius.com/d83247230e8ec246dc6b22d22e3b97d7.999x1000x1.jpg"
            });
            
        }
        
    }
}