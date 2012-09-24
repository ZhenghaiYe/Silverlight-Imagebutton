using System.Windows.Controls;

namespace SilverlightImageButton
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            LangEn.OffImageSource = SilverlightImageButton.Resources.Images.LangEn_off;
            LangEn.OnImageSource = SilverlightImageButton.Resources.Images.LangEn_on;
        }
    }
}
