// TODO: Create unit tests for ArtistService
//
// You have done this before with TurtleServiceTests! Follow the same pattern:
//
// 1. Add using statements for:
//    using Lumivate.TrackStack.Data;
//    using Lumivate.TrackStack.Models;
//    using Lumivate.TrackStack.Services;
//    using Microsoft.EntityFrameworkCore;
//    using Xunit;
//
// 2. Create a test class called ArtistServiceTests
//
// 3. Add the GetInMemoryContext() helper (same pattern as TurtleServiceTests):
//    private TrackStackContext GetInMemoryContext()
//    {
//        var options = new DbContextOptionsBuilder<TrackStackContext>()
//            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
//            .Options;
//        return new TrackStackContext(options);
//    }
//
// 4. Write tests for at least:
//    - AddArtist_IncreasesCount
//    - GetArtistById_WithValidId_ReturnsArtist
//    - GetArtistById_WithInvalidId_ReturnsNull
//    - DeleteArtist_RemovesArtist
//    - GetArtistById_IncludesSongs (add an artist, add a song for that artist,
//      then verify GetArtistById returns the artist WITH the song in the Songs list)
//
// The last test is new - it verifies the one-to-many relationship works correctly.
// You will need to add the song directly to _context.Songs and SaveChanges()
// before calling GetArtistById.

namespace Lumivate.TrackStack.Tests
{
    // Your test class goes here
}
