using GraduationThesis4211036.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraduationThesis4211036.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RouteDetailPage : ContentPage { 
        public RouteDetailPage()
        {
            InitializeComponent();
            BindingContext = new RouteDetailViewModel();
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
                Text = "Hủy bỏ",
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
                Text = "Tải lên OpenStreetMap",
                Order = ToolbarItemOrder.Secondary,
                Priority = 0
            };

            ToolbarItems.Add(wayPointMenuItem);
            ToolbarItems.Add(showRouteMenuItem);
            ToolbarItems.Add(settingMenuItem);
        }

        private void RemoveMenu()
        {
            ToolbarItems.Clear();
        }
    }
}