﻿using Microsoft.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Media.Animation;

[ContentProperty(Name = nameof(DefaultNavigationTransitionInfo))]
#if __ANDROID__ || __APPLE_UIKIT__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
[global::Uno.NotImplemented]
#endif
public partial class NavigationThemeTransition : Transition
{
}
