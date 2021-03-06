﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms.Platform.UWP;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ShellSample.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var app = e.Parameter as Xamarin.Forms.Application;
            LoadApplication(app);
            ApplicationView appView = ApplicationView.GetForCurrentView();
            string title = app.MainPage.Title;
            if (string.IsNullOrEmpty(title))
            {
                title = app.GetType().Namespace;
            }
            appView.Title = title;
            base.OnNavigatedTo(e);
        }
    }
}
