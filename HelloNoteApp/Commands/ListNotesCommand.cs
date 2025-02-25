namespace HelloNoteApp.Commands;

public class ListNotesCommand : ICommand
{
    private readonly AppDbContext _dbContext;

    public ListNotesCommand(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Execute()
    {
        var notes = _dbContext.Notes.ToList();

        if (notes.Count == 0)
        {
            Console.WriteLine("There are no notes");
            return;
        }

        foreach (var note in notes)
        {
            Console.WriteLine($"Title: {note.Title}");
        }
    }
}