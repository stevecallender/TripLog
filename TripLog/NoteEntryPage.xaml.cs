using System;
using System.Collections.Generic;
using System.IO;
using TripLog.Models;

using Xamarin.Forms;

namespace TripLog
{
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.Database.SaveNoteAsyn(note);
            await Navigation.PopAsync();
        }


        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {            
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
                
        }
    }
}
