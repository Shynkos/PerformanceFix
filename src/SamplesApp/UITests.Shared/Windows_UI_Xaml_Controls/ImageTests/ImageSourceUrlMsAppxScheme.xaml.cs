﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace Uno.UI.Samples.UITests.ImageTests
{
	[SampleControlInfo(category: "Image", controlName: nameof(ImageSourceUrlMsAppxScheme), Description = "ImageMsAppxScheme")]
	public sealed partial class ImageSourceUrlMsAppxScheme : Page
	{
		public ImageSourceUrlMsAppxScheme()
		{
			this.InitializeComponent();
		}
	}
}
