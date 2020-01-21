using System;
using System.Collections.Generic;
using TripLog.Data;
using TripLog.Models;
using System.Collections.ObjectModel;


using Xamarin.Forms;

namespace TripLog
{
    public partial class TableViewExample : ContentPage
    {
        //private ObservableCollection<Note> notes;// List<Note> notes;

        public ObservableCollection<Note> Notes { get; set; }

        //public ObservableCollection<Note> Notes { get { return _Notes; } }

        public TableViewExample()
        {
            InitializeComponent();
            Notes = new ObservableCollection<Note>();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            List<Note> notesList = await App.Database.GetNotesAsync();

            foreach (var note in notesList)
            {
                Notes.Add(note);
            }

            


            //items.ItemsSource = new ObservableCollection<Note>(notesList);


        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            Notes.Remove(note);
            
        }
    }
}
