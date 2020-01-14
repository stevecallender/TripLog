using System;
using SQLite;
namespace TripLog.Models
{
    public class Note
    {
        public Note()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }        
        public String Text { get; set; }
        public DateTime Date { get; set; }
    }
}
