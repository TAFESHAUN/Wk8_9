
using CommunityToolkit.Mvvm.ComponentModel;
//using System.ComponentModel;

namespace Wk8_9MAUI
{
    internal class Fruit:ObservableObject // : INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //[ObservableProperty]
        //private int id { get; set; }
        //public int Id { get => id; set => OnPropertyChanged() ; }

        //FRUIT id will eventually be part of our datagrid
        //THEREFORE IF the dg OR the id property changes 
        //BOTH PLACES CHANGE
        //That is to say the Id changes AND the UI element IN REALTIME
        //WITHOUT THE NEED TO CALL OR TRACK THESE THINGS OURSELF

    }
}
