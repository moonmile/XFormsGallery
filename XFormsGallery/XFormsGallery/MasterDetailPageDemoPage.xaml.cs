using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsGallery
{
    public partial class MasterDetailPageDemoPage
    {
        public MasterDetailPageDemoPage()
        {
            InitializeComponent();

            this.listView.ItemsSource = namedColors;
            this.listView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
        NamedColor[] namedColors = 
        {
            new NamedColor("Aqua", Color.Aqua),
            new NamedColor("Black", Color.Black),
            new NamedColor("Blue", Color.Blue),
            new NamedColor("Fuschia", Color.Fuschia),
            new NamedColor("Gray", Color.Gray),
            new NamedColor("Green", Color.Green),
            new NamedColor("Lime", Color.Lime),
            new NamedColor("Maroon", Color.Maroon),
            new NamedColor("Navy", Color.Navy),
            new NamedColor("Olive", Color.Olive),
            new NamedColor("Purple", Color.Purple),
            new NamedColor("Red", Color.Red),
            new NamedColor("Silver", Color.Silver),
            new NamedColor("Teal", Color.Teal),
            new NamedColor("White", Color.White),
            new NamedColor("Yellow", Color.Yellow)
        };

    }
}
