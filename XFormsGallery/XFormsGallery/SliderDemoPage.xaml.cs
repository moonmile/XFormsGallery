using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsGallery
{
    public partial class SliderDemoPage
    {
        public SliderDemoPage()
        {
            InitializeComponent();
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Slider value is {0:F1}", e.NewValue);
        }
    }
}
