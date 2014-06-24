using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsGallery
{
    public partial class SwitchDemoPage
    {
        public SwitchDemoPage()
        {
            InitializeComponent();
        }
        void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            label.Text = String.Format("Switch is now {0}", e.Value);
        }
    }
}
