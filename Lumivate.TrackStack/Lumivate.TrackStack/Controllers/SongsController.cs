using Microsoft.AspNetCore.Mvc;

namespace Lumivate.TrackStack.Controllers
{
    // TODO: Create the SongsController
    //
    // 1. Make this class extend Controller
    //
    // 2. Inject ISongService and IArtistService via the constructor
    //    (you'll need using Lumivate.TrackStack.Services)
    //    We need IArtistService to populate the artist dropdown in Create/Edit forms.
    //
    // 3. Add the following actions:
    //
    //   Index (GET) - get all songs (they should include Artist info) and return the view
    //
    //   Details (GET) - accept an int id, get song by id, return NotFound() or view
    //
    //   Create (GET) - get all artists and pass them via ViewBag.Artists,
    //                  then return the view.
    //     Example: ViewBag.Artists = _artistService.GetAllArtists();
    //
    //   Create (POST) - accept a Song parameter, call AddSong, redirect to Index
    //                   (you'll need using Lumivate.TrackStack.Models and [HttpPost])
    //
    //   Edit (GET) - get song by id, also set ViewBag.Artists, return view
    //
    //   Edit (POST) - accept a Song parameter, call UpdateSong, redirect to Index
    //
    //   Delete (GET) - get song by id, return NotFound() or view
    //
    //   DeleteConfirmed (POST) - accept an int id, call DeleteSong, redirect to Index
    //                            Use [HttpPost, ActionName("Delete")] attribute
    //
    // NOTE: The Create and Edit GET actions need ViewBag.Artists so the form
    // can show a dropdown of artists. This is a new pattern you haven't seen before.
    // Look at the Create.cshtml and Edit.cshtml views to see how it's used.
}
