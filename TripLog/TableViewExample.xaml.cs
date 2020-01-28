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
        private TableViewExampleViewModel viewModel = new TableViewExampleViewModel();

        /*private ObservableCollection<Note> notes;// List<Note> notes;

        private ObservableCollection<ObservableNoteList> _Notes = new ObservableCollection<ObservableNoteList>();

        public ObservableCollection<ObservableNoteList> Notes
        {
            get { return _Notes; }

            set { }
            

            
        }

        */

        //public ObservableCollection<Note> Notes { get { return _Notes; } }

        public TableViewExample()
        {
            InitializeComponent();
            BindingContext = viewModel;
            //Notes = new ObservableCollection<Note>();

        }

        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            viewModel.Populate();
            /*
            List<Note> notesList = await App.Database.GetNotesAsync();
            ObservableCollection<ObservableNoteList> temp = new ObservableCollection<ObservableNoteList>();

            foreach (var note in notesList)
            {                
                temp.Add(new ObservableNoteList(note));
            }

            Notes = temp;


            //items.ItemsSource = new ObservableCollection<Note>(notesList);

            */
        }
        */
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            viewModel.OnDeleteClicked(sender, e);

            /*var  noteRemoved = (Note)BindingContext;
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
