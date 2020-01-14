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
            if (String.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }
            else
            {
                File.WriteAllText(note.Filename, note.Text);
            }

            await Navigation.PopAsync();
        }


        async void OnDeleteButtonclicked(object sender, EventArgs e)
        {
            //might need to combine filename here because we are not using root folder
            var note = (Note)BindingContext;
            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }
            await Navigation.PopAsync();
                
        }
    }
}
