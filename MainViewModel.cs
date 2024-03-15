using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1;
public class MainViewModel : INotifyPropertyChanged
{
    public MainViewModel()
    {
        _title = "Hello World 👋";

        Console.WriteLine("MainViewModel created: " + this.GetHashCode());
        Registrations.ViewModelRegistrations.Add(DateTime.Now + " HashCode: " + this.GetHashCode());

        // Update the title every second
        var timer = new System.Timers.Timer(1000);
        timer.Elapsed += (s, e) =>
        {
            Title = DateTime.Now.ToString() + " ViewModel HashCode " + this.GetHashCode();
        };
        timer.Start();

    }



    string _title;
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
