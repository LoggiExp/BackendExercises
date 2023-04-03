using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_note
{
    internal class Note
    {
        private List<Note> notes = new List<Note>();
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Content { get; set; }

        public void createNote(string title, string content, DateTime expireDate)
        {
            Title = title;
            Content = content;
            CreationDate = DateTime.Now;
            ExpireDate = expireDate;
            notes.Add(this);
            clear();

            showNote(expireDate, this);
        }

        public void modifyNote(int indexofNote, string? title = null, string? content = null, DateTime expireDate = new DateTime())
        {
            if (!isNull<string>(title)) notes[indexofNote].Title = title;
            if (!isNull<string>(content)) notes[indexofNote].Content = content;
            notes[indexofNote].ModifiedDate = DateTime.Now;
            if (expireDate != new DateTime()) notes[indexofNote].ExpireDate = expireDate;
        }

        public void deleteNote(int indexofNote)
        {
            notes.Remove(notes[indexofNote]);
        }

        public List<Note> getListofNote()
        {
            return notes;
        }

        public Note getNote(int indexofNote)
        {
            if (notes[indexofNote] != null)
            {
                return notes[indexofNote];
            }
            else
            {
                throw new Exception("Does  not exist in list"); 
            }            
        }

        public static bool isNull<T>(T obj)
        {
            return (obj == null) ? true : false;
        }

        private void clear()
        {
        ModifiedDate = new DateTime();
        }
        
        async public void showNote(DateTime expireDate, Note note)
        {
            TimeSpan awaitTime = new TimeSpan();
            if (expireDate >= DateTime.Now)
            {
                awaitTime = expireDate - DateTime.Now;
            }
            Console.WriteLine("Timer to se note: " + awaitTime);
            await Task.Delay(awaitTime);
            Console.WriteLine("Titolo: " + note.Title);
            Console.WriteLine("Contenuto: " + note.Content);
        }
    }
}
