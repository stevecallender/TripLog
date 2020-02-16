using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using TripLog.Models;

using Xamarin.Forms;

namespace TripLog
{
    public partial class NotesView : ContentPage
    {

        private ObservableCollection<Note> _observableList; 

        public NotesView()
        {
            InitializeComponent();
            listView.ItemsSource = _observableList;           
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            List<Note> notes = await App.Database.GetNotesAsync(); 

            foreach (var note in notes)
            {
                _observableList.Add(note);
            }


        }
        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage
            {
                BindingContext = new Note()
            });
        }

        void OnDeleteClicked(object sender, EventArgs e)
        {
            
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}
