using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using Notes.Domain.Interfaces;
using Notes.Persistence.Configuratuons;

namespace Notes.Persistence.Contexts
{
    public class NotesDbContext : DbContext,INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
             : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
