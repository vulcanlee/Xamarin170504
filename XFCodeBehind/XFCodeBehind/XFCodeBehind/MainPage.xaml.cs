using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFCodeBehind
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            fooButton.Clicked += ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            fooLabel.Text = $"Hello {fooEntry.Text}";
        }
    }
}
