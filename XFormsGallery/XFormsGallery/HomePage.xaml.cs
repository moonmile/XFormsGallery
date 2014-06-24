using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace XFormsGallery
{
    public partial class HomePage 
    {
        public HomePage()
        {
            InitializeComponent();
            this.cellLabel.Command = new Command(() => 
                this.Navigation.PushAsync(new LabelDemoPage()));
            this.cellImage.Command = new Command(() => 
                this.Navigation.PushAsync(new ImageDemoPage()));
            this.cellBoxView.Command = new Command(() =>
                this.Navigation.PushAsync(new BoxViewDemoPage()));
            this.cellWebView.Command = new Command(() =>
                this.Navigation.PushAsync(new WebViewDemoPage()));
            this.cellMap.Command = new Command(() =>
                this.Navigation.PushAsync(new MapDemoPage()));

            this.cellButton.Command = new Command(() =>
                this.Navigation.PushAsync(new ButtonDemoPage()));
            this.cellSearchBar.Command = new Command(() =>
                this.Navigation.PushAsync(new SearchBarDemoPage()));

            this.cellSlider.Command = new Command(() =>
                this.Navigation.PushAsync(new SliderDemoPage()));
            this.cellStepper.Command = new Command(() =>
                this.Navigation.PushAsync(new StepperDemoPage()));
            this.cellSwitch.Command = new Command(() =>
                this.Navigation.PushAsync(new SwitchDemoPage()));
            this.cellDatePicker.Command = new Command(() =>
                this.Navigation.PushAsync(new DatePickerDemoPage()));
            this.cellTimePicker.Command = new Command(() =>
                this.Navigation.PushAsync(new TimePickerDemoPage()));

            this.cellEntry.Command = new Command(() =>
                this.Navigation.PushAsync(new EntryDemoPage()));
            this.cellEditor.Command = new Command(() =>
                this.Navigation.PushAsync(new EditorDemoPage()));

            this.cellActivityIndicator.Command = new Command(() =>
                this.Navigation.PushAsync(new ActivityIndicatorDemoPage()));
            this.cellProgressBar.Command = new Command(() =>
                this.Navigation.PushAsync(new ProgressBarDemoPage()));

            this.cellPicker.Command = new Command(() =>
                this.Navigation.PushAsync(new PickerDemoPage()));
            this.cellListView.Command = new Command(() =>
                this.Navigation.PushAsync(new ListViewDemoPage()));
            this.cellTableViewMenu.Command = new Command(() =>
                this.Navigation.PushAsync(new TableViewMenuDemoPage()));
            this.cellTableViewForm.Command = new Command(() =>
                this.Navigation.PushAsync(new TableViewFormDemoPage()));

            this.cellTextCell.Command = new Command(() =>
                this.Navigation.PushAsync(new TextCellDemoPage()));
            this.cellImageCell.Command = new Command(() =>
                this.Navigation.PushAsync(new ImageCellDemoPage()));
            this.cellSwitchCell.Command = new Command(() =>
                this.Navigation.PushAsync(new SwitchCellDemoPage()));
            this.cellEntryCell.Command = new Command(() =>
                this.Navigation.PushAsync(new EntryCellDemoPage()));

            this.cellStackLayout.Command = new Command(() =>
                this.Navigation.PushAsync(new StackLayoutDemoPage()));
            this.cellAbsoluteLayout.Command = new Command(() =>
                this.Navigation.PushAsync(new AbsoluteLayoutDemoPage()));
            this.cellGrid.Command = new Command(() =>
                this.Navigation.PushAsync(new GridDemoPage()));
            this.cellRelativeLayout.Command = new Command(() =>
                this.Navigation.PushAsync(new RelativeLayoutDemoPage()));

            this.cellContentPage.Command = new Command(() =>
                this.Navigation.PushAsync(new ContentPageDemoPage()));
            this.cellNavigationPage.Command = new Command(() =>
                this.Navigation.PushAsync(new NavigationPageDemoPage()));
            this.cellMasterDetailPage.Command = new Command(() =>
                this.Navigation.PushAsync(new MasterDetailPageDemoPage()));
            this.cellTabbedPage.Command = new Command(() =>
                this.Navigation.PushAsync(new TabbedPageDemoPage()));
            this.cellCarouselPage.Command = new Command(() =>
                this.Navigation.PushAsync(new CarouselPageDemoPage()));
        }
    }
}
