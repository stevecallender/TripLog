using System;
using System.Collections.Generic;
using TripLog.Data;
using TripLog.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;


using Xamarin.Forms;

namespace TripLog
{
    public partial class TableViewExample : ContentPage
    {
        //private ObservableCollection<Note> notes;// List<Note> notes;

        private ObservableCollection<ObservableNoteList> _Notes = new ObservableCollection<ObservableNoteList>();

        public ObservableCollection<ObservableNoteList> Notes
        {
            get;

            set;
            

            
        }

        

        //public ObservableCollection<Note> Notes { get { return _Notes; } }

        public TableViewExample()
        {
            InitializeComponent();
            //Notes = new ObservableCollection<Note>();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            List<Note> notesList = await App.Database.GetNotesAsync();

            foreach (var note in notesList)
            {
                Notes.Add(new ObservableNoteList(note));
            }

            


            //items.ItemsSource = new ObservableCollection<Note>(notesList);


        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            Notes.Remove(new ObservableNoteList(note));
            
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
