using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsGallery
{
    public partial class StepperDemoPage
    {
        public StepperDemoPage()
        {
            InitializeComponent();
        }
        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
        }
    }
}
