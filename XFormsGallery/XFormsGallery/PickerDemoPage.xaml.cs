using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsGallery
{
    public partial class PickerDemoPage
    {
        public PickerDemoPage()
        {
            InitializeComponent();
            foreach (string colorName in nameToColor.Keys)
            {
                picker.Items.Add(colorName);
            }
        }

        // Dictionary to get Color from color name.
        Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua },         { "Black", Color.Black },
            { "Blue", Color.Blue },         { "Fuschia", Color.Fuschia },
            { "Gray", Color.Gray },         { "Green", Color.Green },
            { "Lime", Color.Lime },         { "Maroon", Color.Maroon },
            { "Navy", Color.Navy },         { "Olive", Color.Olive },
            { "Purple", Color.Purple },     { "Red", Color.Red },
            { "Silver", Color.Silver },     { "Teal", Color.Teal },
            { "White", Color.White },       { "Yellow", Color.Yellow }
        };

        void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker.SelectedIndex == -1)
            {
                boxView.Color = Color.Default;
            }
            else
            {
                string colorName = picker.Items[picker.SelectedIndex];
                boxView.Color = nameToColor[colorName];
            }
        }

    }
}
