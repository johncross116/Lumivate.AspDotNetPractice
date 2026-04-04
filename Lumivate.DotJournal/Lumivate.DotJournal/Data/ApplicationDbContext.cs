using Lumivate.DotJournal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lumivate.DotJournal.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
	{
		// TODO-dotjournal step 2: Add a DbSet for JournalEntry
		//   public DbSet<JournalEntry> JournalEntries { get; set; }
		//
		// Then run the following commands in the terminal (from the Lumivate.DotJournal project folder):
		//   dotnet ef migrations add AddJournalEntries
		//   dotnet ef database update
		//
		// TODO-dotjournal step 7: After adding UserId to JournalEntry, create another migration:
		//   dotnet ef migrations add AddUserIdToJournalEntry
		//   dotnet ef database update
	}
}
