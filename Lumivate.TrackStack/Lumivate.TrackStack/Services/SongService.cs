using Lumivate.TrackStack.Models;

namespace Lumivate.TrackStack.Services
{
    // TODO: Create the SongService class that implements ISongService
    //
    // 1. Inject TrackStackContext via the constructor
    //
    // 2. Implement all methods from ISongService:
    //   - GetAllSongs(): return all songs, including their Artist navigation property
    //     Hint: Use .Include(s => s.Artist) so you can display the artist name
    //   - GetSongsByArtist(int artistId): filter songs by ArtistId, include Artist
    //   - GetSongById(int id): return a single song with its Artist included
    //   - AddSong(Song song): add to context and save
    //   - UpdateSong(Song song): find existing, update properties, save
    //   - DeleteSong(int id): find by id, remove, save
    //
    // Hint: The .Include() calls are important here because without them,
    // the Artist property on each Song will be null when you try to display it.
}
