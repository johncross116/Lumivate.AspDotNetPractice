using Lumivate.TrackStack.Models;

namespace Lumivate.TrackStack.Services
{
    // TODO: Create the ArtistService class that implements IArtistService
    //
    // 1. Inject TrackStackContext via the constructor (you'll need a using for Lumivate.TrackStack.Data)
    //
    // 2. Implement all methods from IArtistService:
    //   - GetAllArtists(): return all artists from the database
    //   - GetArtistById(int id): return a single artist INCLUDING their songs
    //     Hint: Use .Include(a => a.Songs) to eagerly load the related songs
    //     You will need: using Microsoft.EntityFrameworkCore;
    //   - AddArtist(Artist artist): add to context and save
    //   - UpdateArtist(Artist artist): find existing, update properties, save
    //   - DeleteArtist(int id): find by id, remove, save
    //
    // Remember: This is the same pattern as TurtleService, but GetArtistById
    // needs .Include() because of the one-to-many relationship with Songs.
}
