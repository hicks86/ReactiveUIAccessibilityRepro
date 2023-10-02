using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAccessibility
{
    public class RxViewModel : ReactiveObject
    {
        public ObservableCollection<Fruit> Fruits { get; }

        public ViewModelActivator Activator { get; }

        public RxViewModel()
        {
            var fruits = new ObservableCollection<Fruit> { new Fruit(1, "Pear"), new Fruit(2, "Apple"), new Fruit(3, "Orange") };
            Fruits = fruits;
    

        }
    }
}
