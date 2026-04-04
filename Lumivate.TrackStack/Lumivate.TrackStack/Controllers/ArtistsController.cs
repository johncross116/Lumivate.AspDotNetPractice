using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TrackStack.Controllers
{
    // TODO: Create the ArtistsController
    //
    // 1. Make this class extend Controller
    //
    // 2. Inject IArtistService via the constructor
    //    (you'll need using Lumivate.TrackStack.Services)
    //
    // 3. Add the following actions:
    //
    //   Index (GET) - get all artists and return the view
    //
    //   Details (GET) - accept an int id, get artist by id (includes songs),
    //                   return NotFound() if null, otherwise return the view
    //
    //   Create (GET) - just return the view
    //
    //   Create (POST) - accept an Artist parameter, call AddArtist, redirect to Index
    //                   (you'll need using Lumivate.TrackStack.Models and [HttpPost])
    //
    //   Edit (GET) - accept an int id, get artist by id, return NotFound() or view
    //
    //   Edit (POST) - accept an Artist parameter, call UpdateArtist, redirect to Index
    //
    //   Delete (GET) - accept an int id, get artist by id, return NotFound() or view
    //
    //   DeleteConfirmed (POST) - accept an int id, call DeleteArtist, redirect to Index
    //                            Use [HttpPost, ActionName("Delete")] attribute
    //
    // Hint: This is the same CRUD pattern as TurtlesController.
    // The Details page is extra useful here because it shows the artist's songs.
}
