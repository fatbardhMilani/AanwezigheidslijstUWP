using Aanwezigheidslijst.UWP.Models;
using Aanwezigheidslijst.UWP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Aanwezigheidslijst.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateDocentView : Page
    {
        public readonly CreateDocentViewModel ViewModel;
        public readonly ViewDocentViewModel ViewDocentView;
        public CreateDocentView()
        {
            this.InitializeComponent();
            ViewModel = new CreateDocentViewModel();
            ViewDocentView = new ViewDocentViewModel(new Models.ViewDocentModel());
            ViewDocentModel docentModel = new ViewDocentModel();
            ViewDocentView = new ViewDocentViewModel(docentModel);
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateDocentView));
        }
    }
}
