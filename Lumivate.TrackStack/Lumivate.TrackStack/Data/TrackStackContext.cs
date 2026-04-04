// using Lumivate.TrackStack.Models;
// using Microsoft.EntityFrameworkCore;

namespace Lumivate.TrackStack.Data
{
    // TODO: Create the TrackStackContext class that extends DbContext
    //
    // 1. Add a constructor that accepts DbContextOptions<TrackStackContext> and passes it to the base class
    //    public TrackStackContext(DbContextOptions<TrackStackContext> options) : base(options) { }
    //
    // 2. Add DbSet properties for Artist and Song:
    //    public DbSet<Artist> Artists { get; set; }
    //    public DbSet<Song> Songs { get; set; }
    //
    // 3. Override OnModelCreating to seed the data below.
    //    The seed data is provided for you - just uncomment it inside your OnModelCreating method.
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        base.OnModelCreating(modelBuilder);
    //        // ... paste seed data here ...
    //    }
    //
    // 4. After setting up the DbContext, run the migration commands in the Package Manager Console
    //    (Tools > NuGet Package Manager > Package Manager Console):
    //      Add-Migration InitialCreate
    //      Update-Database

    // =====================================================
    // SEED DATA - Uncomment and place this inside OnModelCreating
    // =====================================================
    //
    // modelBuilder.Entity<Artist>().HasData(
    //     new Artist { Id = 1, Name = "Adele", Genre = "Pop" },
    //     new Artist { Id = 2, Name = "The Weeknd", Genre = "R&B" },
    //     new Artist { Id = 3, Name = "Bruno Mars", Genre = "Pop" },
    //     new Artist { Id = 4, Name = "Billie Eilish", Genre = "Pop" },
    //     new Artist { Id = 5, Name = "Post Malone", Genre = "Hip-Hop" },
    //     new Artist { Id = 6, Name = "Queen", Genre = "Rock" },
    //     new Artist { Id = 7, Name = "The Beatles", Genre = "Rock" },
    //     new Artist { Id = 8, Name = "Fleetwood Mac", Genre = "Rock" },
    //     new Artist { Id = 9, Name = "Michael Jackson", Genre = "Pop" },
    //     new Artist { Id = 10, Name = "Elton John", Genre = "Rock" },
    //     new Artist { Id = 11, Name = "Dua Lipa", Genre = "Pop" },
    //     new Artist { Id = 12, Name = "Harry Styles", Genre = "Pop" },
    //     new Artist { Id = 13, Name = "SZA", Genre = "R&B" },
    //     new Artist { Id = 14, Name = "Arctic Monkeys", Genre = "Rock" },
    //     new Artist { Id = 15, Name = "Johnny Cash", Genre = "Country" },
    //     new Artist { Id = 16, Name = "Morgan Wallen", Genre = "Country" },
    //     new Artist { Id = 17, Name = "Stevie Wonder", Genre = "R&B" },
    //     new Artist { Id = 18, Name = "Nirvana", Genre = "Rock" },
    //     new Artist { Id = 19, Name = "Olivia Rodrigo", Genre = "Pop" },
    //     new Artist { Id = 20, Name = "Hozier", Genre = "Indie" },
    //     new Artist { Id = 21, Name = "Chappell Roan", Genre = "Pop" },
    //     new Artist { Id = 22, Name = "Forrest Frank", Genre = "Christian Pop" },
    //     new Artist { Id = 23, Name = "Skillet", Genre = "Rock" },
    //     new Artist { Id = 24, Name = "Jelly Roll", Genre = "Country" },
    //     new Artist { Id = 25, Name = "Linkin Park", Genre = "Rock" },
    //     new Artist { Id = 26, Name = "Lecrae", Genre = "Hip-Hop" },
    //     new Artist { Id = 27, Name = "Red Hot Chili Peppers", Genre = "Rock" },
    //     new Artist { Id = 28, Name = "Paramore", Genre = "Rock" },
    //     new Artist { Id = 29, Name = "Green Day", Genre = "Rock" },
    //     new Artist { Id = 30, Name = "Coldplay", Genre = "Rock" },
    //     new Artist { Id = 31, Name = "The White Stripes", Genre = "Rock" },
    //     new Artist { Id = 32, Name = "Kings of Leon", Genre = "Rock" },
    //     new Artist { Id = 33, Name = "Fall Out Boy", Genre = "Rock" },
    //     new Artist { Id = 34, Name = "Imagine Dragons", Genre = "Rock" },
    //     new Artist { Id = 35, Name = "Hillsong United", Genre = "Worship" },
    //     new Artist { Id = 36, Name = "Manafest", Genre = "Hip-Hop" },
    //     new Artist { Id = 37, Name = "NF", Genre = "Hip-Hop" }
    // );
    //
    // modelBuilder.Entity<Song>().HasData(
    //     // Adele
    //     new Song { Id = 1, Title = "Rolling in the Deep", DurationSeconds = 228, ArtistId = 1 },
    //     new Song { Id = 2, Title = "Someone Like You", DurationSeconds = 285, ArtistId = 1 },
    //     new Song { Id = 3, Title = "Hello", DurationSeconds = 295, ArtistId = 1 },
    //     new Song { Id = 4, Title = "Set Fire to the Rain", DurationSeconds = 241, ArtistId = 1 },
    //     new Song { Id = 5, Title = "Easy On Me", DurationSeconds = 224, ArtistId = 1 },
    //     new Song { Id = 6, Title = "Skyfall", DurationSeconds = 286, ArtistId = 1 },
    //     new Song { Id = 7, Title = "When We Were Young", DurationSeconds = 290, ArtistId = 1 },
    //     new Song { Id = 8, Title = "Chasing Pavements", DurationSeconds = 209, ArtistId = 1 },
    //     // The Weeknd
    //     new Song { Id = 9, Title = "Blinding Lights", DurationSeconds = 200, ArtistId = 2 },
    //     new Song { Id = 10, Title = "Starboy", DurationSeconds = 230, ArtistId = 2 },
    //     new Song { Id = 11, Title = "Save Your Tears", DurationSeconds = 215, ArtistId = 2 },
    //     new Song { Id = 12, Title = "Can't Feel My Face", DurationSeconds = 213, ArtistId = 2 },
    //     new Song { Id = 13, Title = "The Hills", DurationSeconds = 242, ArtistId = 2 },
    //     new Song { Id = 14, Title = "After Hours", DurationSeconds = 361, ArtistId = 2 },
    //     new Song { Id = 15, Title = "Die for You", DurationSeconds = 260, ArtistId = 2 },
    //     new Song { Id = 16, Title = "I Feel It Coming", DurationSeconds = 269, ArtistId = 2 },
    //     // Bruno Mars
    //     new Song { Id = 17, Title = "Just the Way You Are", DurationSeconds = 221, ArtistId = 3 },
    //     new Song { Id = 18, Title = "Grenade", DurationSeconds = 222, ArtistId = 3 },
    //     new Song { Id = 19, Title = "24K Magic", DurationSeconds = 226, ArtistId = 3 },
    //     new Song { Id = 20, Title = "Uptown Funk", DurationSeconds = 269, ArtistId = 3 },
    //     new Song { Id = 21, Title = "That's What I Like", DurationSeconds = 206, ArtistId = 3 },
    //     new Song { Id = 22, Title = "Locked Out of Heaven", DurationSeconds = 233, ArtistId = 3 },
    //     new Song { Id = 23, Title = "When I Was Your Man", DurationSeconds = 213, ArtistId = 3 },
    //     new Song { Id = 24, Title = "Treasure", DurationSeconds = 178, ArtistId = 3 },
    //     // Billie Eilish
    //     new Song { Id = 25, Title = "Bad Guy", DurationSeconds = 194, ArtistId = 4 },
    //     new Song { Id = 26, Title = "Happier Than Ever", DurationSeconds = 298, ArtistId = 4 },
    //     new Song { Id = 27, Title = "Lovely", DurationSeconds = 200, ArtistId = 4 },
    //     new Song { Id = 28, Title = "Ocean Eyes", DurationSeconds = 200, ArtistId = 4 },
    //     new Song { Id = 29, Title = "Therefore I Am", DurationSeconds = 174, ArtistId = 4 },
    //     new Song { Id = 30, Title = "Everything I Wanted", DurationSeconds = 245, ArtistId = 4 },
    //     new Song { Id = 31, Title = "Birds of a Feather", DurationSeconds = 210, ArtistId = 4 },
    //     new Song { Id = 32, Title = "What Was I Made For", DurationSeconds = 260, ArtistId = 4 },
    //     // Post Malone
    //     new Song { Id = 33, Title = "Circles", DurationSeconds = 215, ArtistId = 5 },
    //     new Song { Id = 34, Title = "Sunflower", DurationSeconds = 158, ArtistId = 5 },
    //     new Song { Id = 35, Title = "Congratulations", DurationSeconds = 220, ArtistId = 5 },
    //     new Song { Id = 36, Title = "Rockstar", DurationSeconds = 218, ArtistId = 5 },
    //     new Song { Id = 37, Title = "Better Now", DurationSeconds = 231, ArtistId = 5 },
    //     new Song { Id = 38, Title = "White Iverson", DurationSeconds = 268, ArtistId = 5 },
    //     new Song { Id = 39, Title = "I Had Some Help", DurationSeconds = 179, ArtistId = 5 },
    //     new Song { Id = 40, Title = "Chemical", DurationSeconds = 202, ArtistId = 5 },
    //     // Queen
    //     new Song { Id = 41, Title = "Bohemian Rhapsody", DurationSeconds = 354, ArtistId = 6 },
    //     new Song { Id = 42, Title = "Don't Stop Me Now", DurationSeconds = 209, ArtistId = 6 },
    //     new Song { Id = 43, Title = "We Will Rock You", DurationSeconds = 122, ArtistId = 6 },
    //     new Song { Id = 44, Title = "Somebody to Love", DurationSeconds = 296, ArtistId = 6 },
    //     new Song { Id = 45, Title = "We Are the Champions", DurationSeconds = 179, ArtistId = 6 },
    //     new Song { Id = 46, Title = "Under Pressure", DurationSeconds = 248, ArtistId = 6 },
    //     new Song { Id = 47, Title = "Another One Bites the Dust", DurationSeconds = 215, ArtistId = 6 },
    //     new Song { Id = 48, Title = "Radio Ga Ga", DurationSeconds = 343, ArtistId = 6 },
    //     // The Beatles
    //     new Song { Id = 49, Title = "Hey Jude", DurationSeconds = 431, ArtistId = 7 },
    //     new Song { Id = 50, Title = "Let It Be", DurationSeconds = 243, ArtistId = 7 },
    //     new Song { Id = 51, Title = "Come Together", DurationSeconds = 259, ArtistId = 7 },
    //     new Song { Id = 52, Title = "Yesterday", DurationSeconds = 125, ArtistId = 7 },
    //     new Song { Id = 53, Title = "Here Comes the Sun", DurationSeconds = 185, ArtistId = 7 },
    //     new Song { Id = 54, Title = "Twist and Shout", DurationSeconds = 155, ArtistId = 7 },
    //     new Song { Id = 55, Title = "A Hard Day's Night", DurationSeconds = 154, ArtistId = 7 },
    //     new Song { Id = 56, Title = "Help!", DurationSeconds = 138, ArtistId = 7 },
    //     // Fleetwood Mac
    //     new Song { Id = 57, Title = "Dreams", DurationSeconds = 254, ArtistId = 8 },
    //     new Song { Id = 58, Title = "The Chain", DurationSeconds = 269, ArtistId = 8 },
    //     new Song { Id = 59, Title = "Go Your Own Way", DurationSeconds = 222, ArtistId = 8 },
    //     new Song { Id = 60, Title = "Everywhere", DurationSeconds = 222, ArtistId = 8 },
    //     new Song { Id = 61, Title = "Rhiannon", DurationSeconds = 276, ArtistId = 8 },
    //     new Song { Id = 62, Title = "Little Lies", DurationSeconds = 210, ArtistId = 8 },
    //     new Song { Id = 63, Title = "Don't Stop", DurationSeconds = 190, ArtistId = 8 },
    //     new Song { Id = 64, Title = "Landslide", DurationSeconds = 198, ArtistId = 8 },
    //     // Michael Jackson
    //     new Song { Id = 65, Title = "Thriller", DurationSeconds = 357, ArtistId = 9 },
    //     new Song { Id = 66, Title = "Billie Jean", DurationSeconds = 293, ArtistId = 9 },
    //     new Song { Id = 67, Title = "Beat It", DurationSeconds = 258, ArtistId = 9 },
    //     new Song { Id = 68, Title = "Smooth Criminal", DurationSeconds = 257, ArtistId = 9 },
    //     new Song { Id = 69, Title = "Black or White", DurationSeconds = 253, ArtistId = 9 },
    //     new Song { Id = 70, Title = "Bad", DurationSeconds = 247, ArtistId = 9 },
    //     new Song { Id = 71, Title = "Rock with You", DurationSeconds = 220, ArtistId = 9 },
    //     new Song { Id = 72, Title = "The Way You Make Me Feel", DurationSeconds = 299, ArtistId = 9 },
    //     // Elton John
    //     new Song { Id = 73, Title = "Rocket Man", DurationSeconds = 282, ArtistId = 10 },
    //     new Song { Id = 74, Title = "Tiny Dancer", DurationSeconds = 383, ArtistId = 10 },
    //     new Song { Id = 75, Title = "Crocodile Rock", DurationSeconds = 234, ArtistId = 10 },
    //     new Song { Id = 76, Title = "Your Song", DurationSeconds = 241, ArtistId = 10 },
    //     new Song { Id = 77, Title = "Bennie and the Jets", DurationSeconds = 312, ArtistId = 10 },
    //     new Song { Id = 78, Title = "Don't Let the Sun Go Down on Me", DurationSeconds = 327, ArtistId = 10 },
    //     new Song { Id = 79, Title = "I'm Still Standing", DurationSeconds = 182, ArtistId = 10 },
    //     new Song { Id = 80, Title = "Goodbye Yellow Brick Road", DurationSeconds = 198, ArtistId = 10 },
    //     // Dua Lipa
    //     new Song { Id = 81, Title = "Levitating", DurationSeconds = 203, ArtistId = 11 },
    //     new Song { Id = 82, Title = "Don't Start Now", DurationSeconds = 183, ArtistId = 11 },
    //     new Song { Id = 83, Title = "New Rules", DurationSeconds = 209, ArtistId = 11 },
    //     new Song { Id = 84, Title = "Physical", DurationSeconds = 194, ArtistId = 11 },
    //     new Song { Id = 85, Title = "One Kiss", DurationSeconds = 214, ArtistId = 11 },
    //     new Song { Id = 86, Title = "IDGAF", DurationSeconds = 217, ArtistId = 11 },
    //     new Song { Id = 87, Title = "Break My Heart", DurationSeconds = 221, ArtistId = 11 },
    //     new Song { Id = 88, Title = "Houdini", DurationSeconds = 185, ArtistId = 11 },
    //     // Harry Styles
    //     new Song { Id = 89, Title = "As It Was", DurationSeconds = 167, ArtistId = 12 },
    //     new Song { Id = 90, Title = "Watermelon Sugar", DurationSeconds = 174, ArtistId = 12 },
    //     new Song { Id = 91, Title = "Adore You", DurationSeconds = 207, ArtistId = 12 },
    //     new Song { Id = 92, Title = "Sign of the Times", DurationSeconds = 340, ArtistId = 12 },
    //     new Song { Id = 93, Title = "Golden", DurationSeconds = 208, ArtistId = 12 },
    //     new Song { Id = 94, Title = "Late Night Talking", DurationSeconds = 178, ArtistId = 12 },
    //     new Song { Id = 95, Title = "Kiwi", DurationSeconds = 158, ArtistId = 12 },
    //     new Song { Id = 96, Title = "Lights Up", DurationSeconds = 172, ArtistId = 12 },
    //     // SZA
    //     new Song { Id = 97, Title = "Kill Bill", DurationSeconds = 153, ArtistId = 13 },
    //     new Song { Id = 98, Title = "Snooze", DurationSeconds = 202, ArtistId = 13 },
    //     new Song { Id = 99, Title = "Good Days", DurationSeconds = 279, ArtistId = 13 },
    //     new Song { Id = 100, Title = "Kiss Me More", DurationSeconds = 208, ArtistId = 13 },
    //     new Song { Id = 101, Title = "Love Galore", DurationSeconds = 275, ArtistId = 13 },
    //     new Song { Id = 102, Title = "The Weekend", DurationSeconds = 232, ArtistId = 13 },
    //     new Song { Id = 103, Title = "Shirt", DurationSeconds = 211, ArtistId = 13 },
    //     new Song { Id = 104, Title = "Saturn", DurationSeconds = 213, ArtistId = 13 },
    //     // Arctic Monkeys
    //     new Song { Id = 105, Title = "Do I Wanna Know", DurationSeconds = 272, ArtistId = 14 },
    //     new Song { Id = 106, Title = "R U Mine", DurationSeconds = 201, ArtistId = 14 },
    //     new Song { Id = 107, Title = "505", DurationSeconds = 253, ArtistId = 14 },
    //     new Song { Id = 108, Title = "Why'd You Only Call Me When You're High", DurationSeconds = 163, ArtistId = 14 },
    //     new Song { Id = 109, Title = "Fluorescent Adolescent", DurationSeconds = 177, ArtistId = 14 },
    //     new Song { Id = 110, Title = "I Bet You Look Good on the Dancefloor", DurationSeconds = 174, ArtistId = 14 },
    //     new Song { Id = 111, Title = "Arabella", DurationSeconds = 207, ArtistId = 14 },
    //     new Song { Id = 112, Title = "Knee Socks", DurationSeconds = 256, ArtistId = 14 },
    //     // Johnny Cash
    //     new Song { Id = 113, Title = "Ring of Fire", DurationSeconds = 157, ArtistId = 15 },
    //     new Song { Id = 114, Title = "Folsom Prison Blues", DurationSeconds = 170, ArtistId = 15 },
    //     new Song { Id = 115, Title = "Walk the Line", DurationSeconds = 166, ArtistId = 15 },
    //     new Song { Id = 116, Title = "Hurt", DurationSeconds = 217, ArtistId = 15 },
    //     new Song { Id = 117, Title = "Man in Black", DurationSeconds = 181, ArtistId = 15 },
    //     new Song { Id = 118, Title = "Boy Named Sue", DurationSeconds = 222, ArtistId = 15 },
    //     new Song { Id = 119, Title = "Jackson", DurationSeconds = 166, ArtistId = 15 },
    //     new Song { Id = 120, Title = "Get Rhythm", DurationSeconds = 138, ArtistId = 15 },
    //     // Morgan Wallen
    //     new Song { Id = 121, Title = "Last Night", DurationSeconds = 163, ArtistId = 16 },
    //     new Song { Id = 122, Title = "Whiskey Glasses", DurationSeconds = 219, ArtistId = 16 },
    //     new Song { Id = 123, Title = "Wasted on You", DurationSeconds = 239, ArtistId = 16 },
    //     new Song { Id = 124, Title = "You Proof", DurationSeconds = 171, ArtistId = 16 },
    //     new Song { Id = 125, Title = "Thought You Should Know", DurationSeconds = 198, ArtistId = 16 },
    //     new Song { Id = 126, Title = "Sand in My Boots", DurationSeconds = 232, ArtistId = 16 },
    //     // Stevie Wonder
    //     new Song { Id = 127, Title = "Superstition", DurationSeconds = 245, ArtistId = 17 },
    //     new Song { Id = 128, Title = "Isn't She Lovely", DurationSeconds = 376, ArtistId = 17 },
    //     new Song { Id = 129, Title = "Sir Duke", DurationSeconds = 245, ArtistId = 17 },
    //     new Song { Id = 130, Title = "I Just Called to Say I Love You", DurationSeconds = 259, ArtistId = 17 },
    //     new Song { Id = 131, Title = "Signed Sealed Delivered", DurationSeconds = 187, ArtistId = 17 },
    //     new Song { Id = 132, Title = "Higher Ground", DurationSeconds = 231, ArtistId = 17 },
    //     // Nirvana
    //     new Song { Id = 133, Title = "Smells Like Teen Spirit", DurationSeconds = 301, ArtistId = 18 },
    //     new Song { Id = 134, Title = "Come as You Are", DurationSeconds = 219, ArtistId = 18 },
    //     new Song { Id = 135, Title = "Lithium", DurationSeconds = 257, ArtistId = 18 },
    //     new Song { Id = 136, Title = "Heart-Shaped Box", DurationSeconds = 283, ArtistId = 18 },
    //     new Song { Id = 137, Title = "In Bloom", DurationSeconds = 254, ArtistId = 18 },
    //     new Song { Id = 138, Title = "About a Girl", DurationSeconds = 169, ArtistId = 18 },
    //     // Olivia Rodrigo
    //     new Song { Id = 139, Title = "Drivers License", DurationSeconds = 242, ArtistId = 19 },
    //     new Song { Id = 140, Title = "Good 4 U", DurationSeconds = 178, ArtistId = 19 },
    //     new Song { Id = 141, Title = "Vampire", DurationSeconds = 220, ArtistId = 19 },
    //     new Song { Id = 142, Title = "Deja Vu", DurationSeconds = 215, ArtistId = 19 },
    //     new Song { Id = 143, Title = "Traitor", DurationSeconds = 229, ArtistId = 19 },
    //     new Song { Id = 144, Title = "Brutal", DurationSeconds = 143, ArtistId = 19 },
    //     // Hozier
    //     new Song { Id = 145, Title = "Take Me to Church", DurationSeconds = 242, ArtistId = 20 },
    //     new Song { Id = 146, Title = "Too Sweet", DurationSeconds = 251, ArtistId = 20 },
    //     new Song { Id = 147, Title = "Cherry Wine", DurationSeconds = 250, ArtistId = 20 },
    //     new Song { Id = 148, Title = "Work Song", DurationSeconds = 226, ArtistId = 20 },
    //     new Song { Id = 149, Title = "Someone New", DurationSeconds = 204, ArtistId = 20 },
    //     new Song { Id = 150, Title = "From Eden", DurationSeconds = 222, ArtistId = 20 },
    //     // Chappell Roan
    //     new Song { Id = 151, Title = "Good Luck Babe!", DurationSeconds = 218, ArtistId = 21 },
    //     new Song { Id = 152, Title = "Hot to Go!", DurationSeconds = 179, ArtistId = 21 },
    //     new Song { Id = 153, Title = "Pink Pony Club", DurationSeconds = 244, ArtistId = 21 },
    //     new Song { Id = 154, Title = "Red Wine Supernova", DurationSeconds = 206, ArtistId = 21 },
    //     new Song { Id = 155, Title = "Femininomenon", DurationSeconds = 195, ArtistId = 21 },
    //     new Song { Id = 156, Title = "Casual", DurationSeconds = 223, ArtistId = 21 },
    //     // Forrest Frank
    //     new Song { Id = 157, Title = "Good Day", DurationSeconds = 210, ArtistId = 22 },
    //     new Song { Id = 158, Title = "No Weapon", DurationSeconds = 195, ArtistId = 22 },
    //     new Song { Id = 159, Title = "Searching", DurationSeconds = 200, ArtistId = 22 },
    //     new Song { Id = 160, Title = "Joy of the Lord", DurationSeconds = 215, ArtistId = 22 },
    //     new Song { Id = 161, Title = "On My Way", DurationSeconds = 198, ArtistId = 22 },
    //     new Song { Id = 162, Title = "Sunbeam", DurationSeconds = 185, ArtistId = 22 },
    //     // Skillet
    //     new Song { Id = 163, Title = "Monster", DurationSeconds = 180, ArtistId = 23 },
    //     new Song { Id = 164, Title = "Hero", DurationSeconds = 186, ArtistId = 23 },
    //     new Song { Id = 165, Title = "Feel Invincible", DurationSeconds = 225, ArtistId = 23 },
    //     new Song { Id = 166, Title = "Not Gonna Die", DurationSeconds = 237, ArtistId = 23 },
    //     new Song { Id = 167, Title = "Awake and Alive", DurationSeconds = 193, ArtistId = 23 },
    //     new Song { Id = 168, Title = "Comatose", DurationSeconds = 222, ArtistId = 23 },
    //     new Song { Id = 169, Title = "Rebirthing", DurationSeconds = 204, ArtistId = 23 },
    //     // Jelly Roll
    //     new Song { Id = 170, Title = "Save Me", DurationSeconds = 202, ArtistId = 24 },
    //     new Song { Id = 171, Title = "Need a Favor", DurationSeconds = 190, ArtistId = 24 },
    //     new Song { Id = 172, Title = "Son of a Sinner", DurationSeconds = 214, ArtistId = 24 },
    //     new Song { Id = 173, Title = "Dead Man Walking", DurationSeconds = 182, ArtistId = 24 },
    //     new Song { Id = 174, Title = "I Am Not Okay", DurationSeconds = 230, ArtistId = 24 },
    //     new Song { Id = 175, Title = "Halfway to Hell", DurationSeconds = 195, ArtistId = 24 },
    //     // Linkin Park
    //     new Song { Id = 176, Title = "In the End", DurationSeconds = 216, ArtistId = 25 },
    //     new Song { Id = 177, Title = "Numb", DurationSeconds = 186, ArtistId = 25 },
    //     new Song { Id = 178, Title = "Crawling", DurationSeconds = 209, ArtistId = 25 },
    //     new Song { Id = 179, Title = "Breaking the Habit", DurationSeconds = 196, ArtistId = 25 },
    //     new Song { Id = 180, Title = "What I've Done", DurationSeconds = 206, ArtistId = 25 },
    //     new Song { Id = 181, Title = "Faint", DurationSeconds = 162, ArtistId = 25 },
    //     new Song { Id = 182, Title = "Somewhere I Belong", DurationSeconds = 212, ArtistId = 25 },
    //     new Song { Id = 183, Title = "New Divide", DurationSeconds = 269, ArtistId = 25 },
    //     // Lecrae
    //     new Song { Id = 184, Title = "I'll Find You", DurationSeconds = 237, ArtistId = 26 },
    //     new Song { Id = 185, Title = "Blessings", DurationSeconds = 290, ArtistId = 26 },
    //     new Song { Id = 186, Title = "All I Need Is You", DurationSeconds = 230, ArtistId = 26 },
    //     new Song { Id = 187, Title = "Tell the World", DurationSeconds = 228, ArtistId = 26 },
    //     new Song { Id = 188, Title = "Don't Waste Your Life", DurationSeconds = 220, ArtistId = 26 },
    //     new Song { Id = 189, Title = "Messengers", DurationSeconds = 196, ArtistId = 26 },
    //     // Red Hot Chili Peppers
    //     new Song { Id = 190, Title = "Under the Bridge", DurationSeconds = 264, ArtistId = 27 },
    //     new Song { Id = 191, Title = "Californication", DurationSeconds = 329, ArtistId = 27 },
    //     new Song { Id = 192, Title = "Can't Stop", DurationSeconds = 269, ArtistId = 27 },
    //     new Song { Id = 193, Title = "Snow (Hey Oh)", DurationSeconds = 334, ArtistId = 27 },
    //     new Song { Id = 194, Title = "Otherside", DurationSeconds = 255, ArtistId = 27 },
    //     new Song { Id = 195, Title = "Scar Tissue", DurationSeconds = 217, ArtistId = 27 },
    //     new Song { Id = 196, Title = "By the Way", DurationSeconds = 216, ArtistId = 27 },
    //     new Song { Id = 197, Title = "Dani California", DurationSeconds = 282, ArtistId = 27 },
    //     // Paramore
    //     new Song { Id = 198, Title = "Decode", DurationSeconds = 260, ArtistId = 28 },
    //     new Song { Id = 199, Title = "Misery Business", DurationSeconds = 211, ArtistId = 28 },
    //     new Song { Id = 200, Title = "Still Into You", DurationSeconds = 209, ArtistId = 28 },
    //     new Song { Id = 201, Title = "Hard Times", DurationSeconds = 182, ArtistId = 28 },
    //     new Song { Id = 202, Title = "The Only Exception", DurationSeconds = 257, ArtistId = 28 },
    //     new Song { Id = 203, Title = "Ain't It Fun", DurationSeconds = 236, ArtistId = 28 },
    //     new Song { Id = 204, Title = "crushcrushcrush", DurationSeconds = 200, ArtistId = 28 },
    //     // Green Day
    //     new Song { Id = 205, Title = "Boulevard of Broken Dreams", DurationSeconds = 262, ArtistId = 29 },
    //     new Song { Id = 206, Title = "American Idiot", DurationSeconds = 167, ArtistId = 29 },
    //     new Song { Id = 207, Title = "Wake Me Up When September Ends", DurationSeconds = 285, ArtistId = 29 },
    //     new Song { Id = 208, Title = "21 Guns", DurationSeconds = 303, ArtistId = 29 },
    //     new Song { Id = 209, Title = "Basket Case", DurationSeconds = 181, ArtistId = 29 },
    //     new Song { Id = 210, Title = "Holiday", DurationSeconds = 232, ArtistId = 29 },
    //     new Song { Id = 211, Title = "When I Come Around", DurationSeconds = 175, ArtistId = 29 },
    //     // Coldplay
    //     new Song { Id = 212, Title = "Yellow", DurationSeconds = 266, ArtistId = 30 },
    //     new Song { Id = 213, Title = "The Scientist", DurationSeconds = 309, ArtistId = 30 },
    //     new Song { Id = 214, Title = "Fix You", DurationSeconds = 295, ArtistId = 30 },
    //     new Song { Id = 215, Title = "Viva la Vida", DurationSeconds = 242, ArtistId = 30 },
    //     new Song { Id = 216, Title = "Clocks", DurationSeconds = 308, ArtistId = 30 },
    //     new Song { Id = 217, Title = "A Sky Full of Stars", DurationSeconds = 267, ArtistId = 30 },
    //     new Song { Id = 218, Title = "Paradise", DurationSeconds = 277, ArtistId = 30 },
    //     new Song { Id = 219, Title = "Something Just Like This", DurationSeconds = 247, ArtistId = 30 },
    //     // The White Stripes
    //     new Song { Id = 220, Title = "Seven Nation Army", DurationSeconds = 232, ArtistId = 31 },
    //     new Song { Id = 221, Title = "Fell in Love with a Girl", DurationSeconds = 101, ArtistId = 31 },
    //     new Song { Id = 222, Title = "Icky Thump", DurationSeconds = 244, ArtistId = 31 },
    //     new Song { Id = 223, Title = "Hotel Yorba", DurationSeconds = 134, ArtistId = 31 },
    //     new Song { Id = 224, Title = "Dead Leaves and the Dirty Ground", DurationSeconds = 195, ArtistId = 31 },
    //     new Song { Id = 225, Title = "Blue Orchid", DurationSeconds = 211, ArtistId = 31 },
    //     // Kings of Leon
    //     new Song { Id = 226, Title = "Use Somebody", DurationSeconds = 231, ArtistId = 32 },
    //     new Song { Id = 227, Title = "Sex on Fire", DurationSeconds = 203, ArtistId = 32 },
    //     new Song { Id = 228, Title = "Radioactive", DurationSeconds = 236, ArtistId = 32 },
    //     new Song { Id = 229, Title = "Closer", DurationSeconds = 239, ArtistId = 32 },
    //     new Song { Id = 230, Title = "The Bucket", DurationSeconds = 176, ArtistId = 32 },
    //     new Song { Id = 231, Title = "Waste a Moment", DurationSeconds = 215, ArtistId = 32 },
    //     // Fall Out Boy
    //     new Song { Id = 232, Title = "Sugar We're Goin Down", DurationSeconds = 229, ArtistId = 33 },
    //     new Song { Id = 233, Title = "Thnks fr th Mmrs", DurationSeconds = 218, ArtistId = 33 },
    //     new Song { Id = 234, Title = "Dance Dance", DurationSeconds = 182, ArtistId = 33 },
    //     new Song { Id = 235, Title = "My Songs Know What You Did in the Dark", DurationSeconds = 203, ArtistId = 33 },
    //     new Song { Id = 236, Title = "Centuries", DurationSeconds = 237, ArtistId = 33 },
    //     new Song { Id = 237, Title = "Immortals", DurationSeconds = 196, ArtistId = 33 },
    //     new Song { Id = 238, Title = "Uma Thurman", DurationSeconds = 198, ArtistId = 33 },
    //     // Imagine Dragons
    //     new Song { Id = 239, Title = "Radioactive", DurationSeconds = 187, ArtistId = 34 },
    //     new Song { Id = 240, Title = "Believer", DurationSeconds = 204, ArtistId = 34 },
    //     new Song { Id = 241, Title = "Demons", DurationSeconds = 177, ArtistId = 34 },
    //     new Song { Id = 242, Title = "Thunder", DurationSeconds = 187, ArtistId = 34 },
    //     new Song { Id = 243, Title = "Whatever It Takes", DurationSeconds = 201, ArtistId = 34 },
    //     new Song { Id = 244, Title = "Natural", DurationSeconds = 190, ArtistId = 34 },
    //     new Song { Id = 245, Title = "Enemy", DurationSeconds = 173, ArtistId = 34 },
    //     new Song { Id = 246, Title = "Bones", DurationSeconds = 165, ArtistId = 34 },
    //     // Hillsong United
    //     new Song { Id = 247, Title = "Oceans", DurationSeconds = 534, ArtistId = 35 },
    //     new Song { Id = 248, Title = "So Will I", DurationSeconds = 379, ArtistId = 35 },
    //     new Song { Id = 249, Title = "What a Beautiful Name", DurationSeconds = 349, ArtistId = 35 },
    //     new Song { Id = 250, Title = "Touch the Sky", DurationSeconds = 337, ArtistId = 35 },
    //     new Song { Id = 251, Title = "Hosanna", DurationSeconds = 290, ArtistId = 35 },
    //     new Song { Id = 252, Title = "Mighty to Save", DurationSeconds = 303, ArtistId = 35 },
    //     // Manafest
    //     new Song { Id = 253, Title = "Impossible", DurationSeconds = 199, ArtistId = 36 },
    //     new Song { Id = 254, Title = "Fighter", DurationSeconds = 213, ArtistId = 36 },
    //     new Song { Id = 255, Title = "Every Time You Run", DurationSeconds = 205, ArtistId = 36 },
    //     new Song { Id = 256, Title = "Renegade", DurationSeconds = 191, ArtistId = 36 },
    //     new Song { Id = 257, Title = "No Plan B", DurationSeconds = 188, ArtistId = 36 },
    //     new Song { Id = 258, Title = "Stick to Your Gunz", DurationSeconds = 197, ArtistId = 36 },
    //     // NF
    //     new Song { Id = 259, Title = "Let You Down", DurationSeconds = 213, ArtistId = 37 },
    //     new Song { Id = 260, Title = "The Search", DurationSeconds = 241, ArtistId = 37 },
    //     new Song { Id = 261, Title = "When I Grow Up", DurationSeconds = 228, ArtistId = 37 },
    //     new Song { Id = 262, Title = "Clouds", DurationSeconds = 194, ArtistId = 37 },
    //     new Song { Id = 263, Title = "HOPE", DurationSeconds = 282, ArtistId = 37 },
    //     new Song { Id = 264, Title = "Mansion", DurationSeconds = 267, ArtistId = 37 },
    //     new Song { Id = 265, Title = "Lie", DurationSeconds = 215, ArtistId = 37 }
    // );
}
