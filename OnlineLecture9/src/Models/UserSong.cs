using System;

namespace RazorPagesHelloWorld.Models {
    public class UserSong {
        public long UserId { get; set; }
        public long SongId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool IsValid { get; set; }
    }
}