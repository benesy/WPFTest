using System.Collections.ObjectModel;
using Test_WPF.Model;
using Test_WPF.Tools;

namespace Test_WPF.ViewModel
{
    internal class ZoomBarViewModel : ViewModelBase
    {
        public int menuLength = 16;
        private int menuLargerSeparatorSize = 70;
        private int menuThinerSeparatorSize = 40;

        public int selectedItem = 6;

        public ObservableCollection<Menudata> items = new ObservableCollection<Menudata>();

        public ZoomBarViewModel()
        {
            InitMenu();
        }

        private void InitMenu()
        {
            for (int i = 0; i < menuLength; i++)
            {
                items.Add(new Menudata()
                {
                    Lvl = i,
                    Selected = i == selectedItem,
                    AlwaysVisible = i == 0 || i == menuLength -1,
                    SeparatorSize = i == 0 || i == menuLength -2  ? menuLargerSeparatorSize : i == menuLength -1 ? 0 : menuThinerSeparatorSize
                });
            }
        }

        public void UpdateMenu()
        {
            items.Clear();
            InitMenu();
        }
    }
}
