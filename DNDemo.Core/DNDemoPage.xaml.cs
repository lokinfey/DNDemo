using Xamarin.Forms;
using DNDemo.Lib;

namespace DNDemo.Core
{
    public partial class DNDemoPage : ContentPage
    {
        public DNDemoPage()
        {
            InitializeComponent();
            lbName.Text = Kinfey.GetInfo();
        }
    }
}
