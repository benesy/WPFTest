using System.Windows;
using System.Windows.Controls;
using Test_WPF.ViewModel;

namespace Test_WPF.View
{
    public partial class ZoomBar : UserControl
    {
        internal ZoomBarViewModel vm = new ZoomBarViewModel();

        public event EventHandler<int> ScaleEmitter;

        public ZoomBar()
        {
            InitializeComponent();
            icMenu.ItemsSource = vm.items;
            DataContext = vm;
        }

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            if (vm.selectedItem - 1 > 0)
            {
                vm.selectedItem--;
                vm.UpdateMenu();
                ScaleChanged();
            }
        }

        private void btdown_Click(object sender, RoutedEventArgs e)
        {
            if (vm.selectedItem + 2 < vm.menuLength)
            {
                vm.selectedItem++;
                vm.UpdateMenu();
                ScaleChanged();
            }

        }

        private void ScaleChanged()
        {
            this.ScaleEmitter?.Invoke(this, vm.selectedItem);
        }
    }
}
