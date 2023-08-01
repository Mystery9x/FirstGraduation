using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GraduationThesis4211036.ViewModels
{
    public partial class RouteTrackerViewModel:ObservableObject
    {
        [ObservableProperty]
        private bool isShowGridFunction;
        [ObservableProperty]
        private bool isShowGridVehicle;
        [ObservableProperty]
        private bool isShowGridLocation;
        [ObservableProperty]
        private bool isShowGridRestrict;
        [ObservableProperty]
        private bool isShowGridWay;
        [ObservableProperty]
        private string toggleGridFunctionText;
        [ObservableProperty]
        private string toggleGridVehicleText;
        [ObservableProperty]
        private string toggleGridLocationText;
        [ObservableProperty]
        private string toggleGridRestrictText;
        [ObservableProperty]
        private string toggleGridWayText;

        public RouteTrackerViewModel()
        {
            isShowGridFunction = true;
            isShowGridVehicle = true;
            isShowGridLocation = true;
            isShowGridRestrict = true;
            isShowGridWay = true;
            toggleGridFunctionText = "Ẩn";
            toggleGridLocationText = "Ẩn";
            toggleGridRestrictText = "Ẩn";
            toggleGridVehicleText = "Ẩn";
            toggleGridWayText = "Ẩn";
        }
        [RelayCommand]
        private void ToggleShowGridFunction()
        {
            IsShowGridFunction = !IsShowGridFunction;
            ToggleGridFunctionText = IsShowGridFunction ? "Ẩn" : "Hiện";
        }
        [RelayCommand]
        private void ToggleShowGridVehicle()
        {
            IsShowGridVehicle = !IsShowGridVehicle;
            ToggleGridVehicleText = IsShowGridVehicle ? "Ẩn" : "Hiện";
        }
        [RelayCommand]
        private void ToggleShowGridLocation()
        {
            IsShowGridLocation = !IsShowGridLocation;
            ToggleGridLocationText = IsShowGridLocation ? "Ẩn" : "Hiện";
        }
        [RelayCommand]
        private void ToggleShowGridRestrict()
        {
            IsShowGridRestrict = !IsShowGridRestrict;
            ToggleGridRestrictText = IsShowGridRestrict ? "Ẩn" : "Hiện";
        }
        [RelayCommand]
        private void ToggleShowGridWay()
        {
            IsShowGridWay = !IsShowGridWay;
            ToggleGridWayText = IsShowGridWay ? "Ẩn" : "Hiện";
        }
    }
}
