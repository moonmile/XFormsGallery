using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsGallery
{
    public partial class ButtonDemoPage
    {
        int clickTotal = 0;

        public ButtonDemoPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = String.Format("{0} button click{1}",
                                       clickTotal, clickTotal == 1 ? "" : "s");
        }
    }
}
