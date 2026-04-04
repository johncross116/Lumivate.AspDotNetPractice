namespace Lumivate.TrackStack.Models
{
    // TODO: Create the Song model
    //
    // Properties:
    //   - int Id (primary key)
    //   - string Title (required)
    //   - int DurationSeconds (how long the song is, in seconds)
    //   - int ArtistId (foreign key to Artist)
    //   - Artist Artist (navigation property - each song belongs to one artist)
    //
    // The ArtistId + Artist navigation property creates the many-to-one relationship.
    // EF Core will automatically create a foreign key constraint in the database.
    //
    // Hint: This is similar to how OrderItem had an OrderId foreign key in the Turtle Store.
}
