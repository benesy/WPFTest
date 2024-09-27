using System.Windows;

namespace Test_WPF
{

    public partial class MainWindow : Window
    {

        private int scale;

        public int Scale
        {
            get { return scale; }
            set { scale = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScaleHasChanged(object sender, int scale)
        {
            imgDisplay.Scale = scale;
        }
    }
}