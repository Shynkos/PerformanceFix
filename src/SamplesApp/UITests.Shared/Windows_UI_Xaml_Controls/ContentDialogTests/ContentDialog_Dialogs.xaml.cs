﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UITests.Windows_UI_Xaml_Controls.ContentDialogTests.Dialogs;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Windows_UI_Xaml_Controls.ContentDialogTests
{
	[Sample("Dialogs")]
	public sealed partial class ContentDialog_Dialogs : UserControl
	{
		public ContentDialog_Dialogs()
		{
			this.InitializeComponent();
		}

		private async void ShowTermsAndConditions(object sender, RoutedEventArgs args)
		{
			var dialog = new ContentDialog_TermsAndConditions();
			dialog.XamlRoot = this.XamlRoot;
			await dialog.ShowAsync();
		}

		private async void ShowSignIn(object sender, RoutedEventArgs args)
		{
			var dialog = new ContentDialog_SignIn();
			dialog.XamlRoot = this.XamlRoot;
			await dialog.ShowAsync();
		}

		private async void ShowRateApp(object sender, RoutedEventArgs args)
		{
			var dialog = new ContentDialogRateApp();
			dialog.XamlRoot = this.XamlRoot;
			await dialog.ShowAsync();
		}
	}
}
