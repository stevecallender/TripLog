using System;
namespace TripLog.Models
{
    public class Note
    {
        public Note()
        {
        }

        public String Filename { get; set; }
        public String Text { get; set; }
        public DateTime Date { get; set; }
    }
}
