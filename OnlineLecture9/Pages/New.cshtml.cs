using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesHelloWorld.Data;
using RazorPagesHelloWorld.Models;

namespace RazorPagesHelloWorld.Pages
{
    public class NewModel : PageModel
    {
        public IActionResult OnGet() {
            return Page();
        }
        
        public IActionResult OnPost(string songName, string album, string artist) {
            Console.WriteLine($"Adding new song: {songName} {album} {artist}");
            
            SongsRepository.Songs.Add(new Song() {
                Id = SongsRepository.Songs.Count + 1,
                Name = songName,
                Album = album,
                Artist = artist
            });
            
            return RedirectToPage("/Music");
        }
        
    }
}