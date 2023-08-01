using GraduationThesis4211036.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraduationThesis4211036.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RouteTrackerPage : ContentPage
	{
        public RouteTrackerPage()
		{
			InitializeComponent();
			BindingContext = new RouteTrackerViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CreateMenu();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            RemoveMenu();
        }
        private void CreateMenu()
        {
            ToolbarItem wayPointMenuItem = new ToolbarItem()
            {
                Text = "Tọa độ điểm",
                Order = ToolbarItemOrder.Secondary,
                Priority = 0
            };
            ToolbarItem showRouteMenuItem = new ToolbarItem()
            {
                Text = "Hiện tuyến đường",
                Order = ToolbarItemOrder.Secondary,
                Priority = 0
            };
            ToolbarItem settingMenuItem = new ToolbarItem()
            {
                Text = "Tùy chọn",
                Order = ToolbarItemOrder.Secondary,
                Priority = 0
            };
            ToolbarItem infoMenuItem = new ToolbarItem()
            {
                Text = "Giới thiệu",
                Order = ToolbarItemOrder.Secondary,
                Priority = 0
            };
            ToolbarItem saveMenuItem = new ToolbarItem()
            {
                Text = "Lưu",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                IconImageSource = ImageSource.FromFile("btn_save.png")
            };

            ToolbarItems.Add(saveMenuItem);
            ToolbarItems.Add(wayPointMenuItem);
            ToolbarItems.Add(showRouteMenuItem);
            ToolbarItems.Add(settingMenuItem);
            ToolbarItems.Add(infoMenuItem);
        }

        private void RemoveMenu()
        {
            ToolbarItems.Clear();
        }   
    }
}