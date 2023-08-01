using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GraduationThesis4211036.Models;
using GraduationThesis4211036.Services;
using GraduationThesis4211036.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GraduationThesis4211036.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IDataStore<Route> routeDataStore;
        public Command OpenSettingCommand { get; }
        public Command GetListRouteCommand { get; }
        [ObservableProperty]
        private bool isHaveNoRoute;
        public ObservableCollection<Route> Routes { get; set; }
        [ObservableProperty]
        private Route selectedRoute;
        [ObservableProperty]
        private bool isBusy;
        public MainViewModel() {
            IsHaveNoRoute = true;
            Routes = new ObservableCollection<Route>();
            routeDataStore = new MockRouteDataStore();
            OpenSettingCommand = new Command(()=>OpenSetting());
            GetListRouteCommand = new Command(()=>GetListRoute());
        }
        private async Task GetListRoute()
        {
            IsBusy = true;
            try
            {
                var routes = await routeDataStore.GetItemsAsync(true);
                Routes.Clear();
                foreach (var route in routes)
                {
                    Routes.Add(route);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                IsHaveNoRoute = Routes.Count == 0;
                IsBusy = false;
            }
        }
        [RelayCommand]
        private async Task AddNewRoute()
        {
            try
            {
                await Shell.Current.Navigation.PushAsync(new RouteDetailPage());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
        private async Task OpenSetting()
        {
            try
            {
                await Shell.Current.Navigation.PushAsync(new SettingPage());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
