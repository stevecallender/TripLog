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

        public TableViewExample()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            List<Note> notesList = await App.Database.GetNotesAsync();
            
            items.ItemsSource = new ObservableCollection<Note>(notesList);


        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            items.ItemsSource.Remove(note);
            
        }
    }
}
