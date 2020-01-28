using System;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TripLog.Data;
using TripLog.Models;

namespace TripLog
{
    public class TableViewExampleViewModel : INotifyPropertyChanged
    {
        public TableViewExampleViewModel()
        {
            this.Populate();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private ObservableCollection<ObservableNoteList> _Notes = new ObservableCollection<ObservableNoteList>();

        public ObservableCollection<ObservableNoteList> Notes
        {
            get { return _Notes; }

            set
            {
                if (_Notes != value)
                {
                    ObservableCollection<ObservableNoteList> temp = new ObservableCollection<ObservableNoteList>();

                    foreach (var note in value)
                    {
                        temp.Add(note);                        
                    }

                    Notes = temp;
                }
            }



        }



        //public ObservableCollection<Note> Notes { get { return _Notes; } }


        public async void Populate()
        {

            List<Note> notesList = await App.Database.GetNotesAsync();
            ObservableCollection<ObservableNoteList> temp = new ObservableCollection<ObservableNoteList>();

            foreach (var note in notesList)
            {
                temp.Add(new ObservableNoteList(note));
            }

            Notes = temp;


            //items.ItemsSource = new ObservableCollection<Note>(notesList);


        }

        public async void OnDeleteClicked(object sender, EventArgs e)
        {
            /*var noteRemoved = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(noteRemoved);

            List<Note> notesList = await App.Database.GetNotesAsync();
            ObservableCollection<ObservableNoteList> temp = new ObservableCollection<ObservableNoteList>();

            foreach (var note in notesList)
            {
                temp.Add(new ObservableNoteList(note));
            }

            Notes = temp;
            */

        }
        /*
        void VisibleFeatures_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (ObservableNoteList item in e.NewItems)
                    item.PropertyChanged += MyFeature_PropertyChanged;

            if (e.OldItems != null)
                foreach (ObservableNoteList item in e.OldItems)
                    item.PropertyChanged -= MyFeature_PropertyChanged;
        }

        void MyFeature_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // NotifyPropertyChanged() defined again elsewhere in the class
            NotifyPropertyChanged("Notes");
        }
        */


    }
}
