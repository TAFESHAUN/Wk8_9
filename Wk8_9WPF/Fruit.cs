using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk8_9WPF
{
    internal class Fruit//:INotifyPropertyChanged
    {
        //OBS Property, collection, object -> Write this logic in WPF
        //MAUI Skips with MVVM toolkit = Behave straight away
        public int id {  get; set; }
        public string name { get; set; }

        public string description { get; set; }

        public Fruit(int theId, string theName, string theDesc) 
        { 
            id = theId;
            name = theName;
            description = theDesc;
        }
    }
}
