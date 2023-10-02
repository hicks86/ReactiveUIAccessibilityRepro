using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAccessibility
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow  : ReactiveWindow<RxViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new RxViewModel();


            this.WhenActivated(d =>
            {
                this.OneWayBind(ViewModel, vm => vm.Fruits, v => v.RxCombobox.ItemsSource);
            });

            //WpfCombobox.ItemsSource = new List<Fruit> { new Fruit(1, "Grapes"), new Fruit(2, "Melon"), new Fruit(3, "Tomoato") };

        }
    }
}
