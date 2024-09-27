using System.Windows.Controls;
using Test_WPF.ViewModel;

namespace Test_WPF.View
{

    public partial class ImageDisplay : UserControl
    {
        ImageDisplayViewModel vm = new ImageDisplayViewModel();


        private int scale;

        public int Scale
        {
            get { return scale; }
            set { scale = value;
                vm.Scale = scale;
            }
        }


        public ImageDisplay()
        {
            InitializeComponent();
            DataContext = vm;
        }


    }
}
