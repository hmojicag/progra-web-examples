using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesHelloWorld.Data;
using RazorPagesHelloWorld.Models;

namespace RazorPagesHelloWorld.Pages
{
    public class MusicModel : PageModel {
        public String PageTitle = "List of Music";
        public List<Song> Songs;
        public SongFilters SongFilters;

        public void OnGet([FromQuery] SongFilters filters) {
            SongFilters = filters;
            Songs = SongsRepository.Songs;

            if (filters.Name != null) {
                Songs = Songs.Where(
                    song => song.Name.ToLower().Contains(filters.Name.ToLower())
                    ).ToList();
            }
            
            if (filters.Album != null) {
                Songs = Songs.Where(
                    song => song.Album.ToLower().Contains(filters.Album.ToLower())
                ).ToList();
            }
            
            if (filters.Artist != null) {
                Songs = Songs.Where(
                    song => song.Artist.ToLower().Contains(filters.Artist.ToLower())
                ).ToList();
            }
            
        }
    }
    
    public class SongFilters {
        public string Name { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
    }
    
}
