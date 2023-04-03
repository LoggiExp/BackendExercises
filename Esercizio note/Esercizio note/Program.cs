using Esercizio_note;

internal class Program
{
    private static void Main(string[] args) {
        Note notes = new Note();

        notes.createNote("Funziona?", "Ma certo che funziona!", new DateTime(2023, 04, 1, 14, 38, 20));
        //Console.WriteLine(Tools<Note>.serialize(notes.getNote(0)));


        //notes.modifyNote(0, null, null, DateTime.Now);
        //Console.WriteLine(Tools<Note>.serialize(notes.getNote(0)));

        //notes.deleteNote(0);
        //Console.WriteLine(Tools<List<Note>>.serialize(notes.getListofNote()));

        //try
        //{
        //    Console.WriteLine(Tools<Note>.serialize(notes.getNote(0)));
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    return;
        //}
        Console.ReadKey();
    }
}