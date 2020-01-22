using System;
using System.Collections.Generic;
using TripLog.Data;
using TripLog.Models;
using System.Collections.ObjectModel;
using TripLog.Data;
using TripLog.Models;
using System.ComponentModel;

namespace TripLog.Models
{
    public class ObservableNoteList : INotifyPropertyChanged
    {
        private Note _note;

        public ObservableNoteList(Note note)
        {
            _note = note;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Note NoteProperty
        {
            get { return _note; }
            set { _note = value; NotifyPropertyChanged("NoteProperty"); }
        }

    }



    
}
