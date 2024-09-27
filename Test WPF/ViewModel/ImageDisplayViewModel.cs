using Test_WPF.Tools;

namespace Test_WPF.ViewModel
{
    internal class ImageDisplayViewModel : ViewModelBase
    {

        private string image;

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        private int scale;

        public int Scale
        {
            get { return scale; }
            set { 
                scale = value;
                getImage();
                OnPropertyChanged();
            }
        }

        public ImageDisplayViewModel()
        {
            Scale = 6;
        }

        // Assuming each scale have a different picture
        // Need some provider rules to get each image
        public void getImage()
        {
            if (Scale % 2 == 0)
                Image = "/Assets/Img1.png";
            else
                Image = "/Assets/Img.png";
        }
    }
}
