using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesHelloWorld.Data;
using RazorPagesHelloWorld.Models;

namespace RazorPagesHelloWorld.Pages {
    public class SongModel : PageModel {
        
        public Song Song { get; set; }
        
        public IActionResult OnGet(int id) {
            if (id == 0) {
                Song = null;
            }

            /*foreach (var song in SongsRepository.Songs) {
                if (song.Id == id) {
                    Song = song;
                }
            }*/
            Song = SongsRepository.Songs.FirstOrDefault(
                song => song.Id == id
            );

            return Page();
        }
    }
}