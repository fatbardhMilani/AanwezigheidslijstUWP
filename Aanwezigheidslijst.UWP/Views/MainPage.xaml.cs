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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NvSample_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            //FrameNavigationOptions navOptions = new FrameNavigationOptions();
            //navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
            //if (sender.PanePosition == NavigationViewPanePosition.Top)
            //{
            //    navOptions.IsNavigationStackEnabled = False;
            //}
            //Type pageType;
            //if (itemContainer == SamplePage1Item)
            //{
            //    pageType = typeof(SamplePage1);
            //}
            //else if (itemContainer == SamplePage2Item)
            //{
            //    pageType = typeof(SamplePage2);
            //}
            //else if (itemContainer == SamplePage3Item)
            //{
            //    pageType = typeof(SamplePage3);
            //}
            //else if (itemContainer == SamplePage4Item)
            //{
            //    pageType = typeof(SamplePage4);
            //}
            //ContentFrame.NavigateToType(pageType, null, navOptions);

        }

        private void NvSample_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (NavigationViewItem)args.SelectedItem;
            if (selectedItem != null)
            {
                selectedItem.Tag.ToString();

                if (selectedItem.Tag.ToString() == "Docenten")
                {
                    contentFrame.Navigate(typeof(CreateDocentView));
                }
                
            }
        }
    }
}
