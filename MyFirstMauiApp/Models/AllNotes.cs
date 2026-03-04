using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyFirstMauiApp.Models
{
    internal class AllNotes
    {
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();
    }
}
