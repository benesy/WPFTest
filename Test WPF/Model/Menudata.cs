using System.Windows;

namespace Test_WPF.Model
{
    internal class Menudata
    {
        public int Lvl { get; set; }
        public string? Label
        {
            get
            {
                return Lvl + " µm";
            }
        }
        public bool Selected;
        public int SeparatorSize { get; set; }
        public bool AlwaysVisible { get; set; }
        public Visibility Visibility {
            get {
                return AlwaysVisible ? Visibility.Visible : Selected ? Visibility.Visible : Visibility.Collapsed;
            }
        }
        public Visibility SelectedVisibility
        {
            get
            {
                return Selected ? Visibility.Visible : Visibility.Collapsed;
            }
        }
    }
}
