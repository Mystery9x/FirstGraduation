using CommunityToolkit.Mvvm.ComponentModel;

using System;
using System.Collections.Generic;

namespace GraduationThesis4211036.ViewModels
{
    public partial class SettingViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isEnableSound;

        [ObservableProperty]
        private bool isRequireTrackRestart;
    }
}