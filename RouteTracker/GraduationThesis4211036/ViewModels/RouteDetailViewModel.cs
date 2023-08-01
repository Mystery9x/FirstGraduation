using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GraduationThesis4211036.Models;
using GraduationThesis4211036.Services;
using GraduationThesis4211036.Views;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GraduationThesis4211036.ViewModels
{
    public partial class RouteDetailViewModel:ObservableObject
    {
        private IDataStore<Route> routeStore;
        [ObservableProperty]
        private Route route;
        public RouteDetailViewModel()
        {
            route = new Route();
            routeStore = new MockRouteDataStore();
        }
        public RouteDetailViewModel(Route route) {
            this.route = route;
            routeStore = new MockRouteDataStore();
        }
        [RelayCommand]
        private async Task Save()
        {
            try
            {
                await routeStore.AddItemAsync(Route);
                await Shell.Current.Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            { 
                Debug.WriteLine(ex);
            }
        }
        [RelayCommand]
        private async Task Cancel()
        {
            try
            {
                await Shell.Current.Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
