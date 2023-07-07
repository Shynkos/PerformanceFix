#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StoreSendRequestResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreSendRequestResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreSendRequestResult.ExtendedError");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Response
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StoreSendRequestResult.Response is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StoreSendRequestResult.Response");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Web.Http.HttpStatusCode HttpStatusCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member HttpStatusCode StoreSendRequestResult.HttpStatusCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpStatusCode%20StoreSendRequestResult.HttpStatusCode");
			}
		}
		#endif
		// Forced skipping of method Windows.Services.Store.StoreSendRequestResult.Response.get
		// Forced skipping of method Windows.Services.Store.StoreSendRequestResult.ExtendedError.get
		// Forced skipping of method Windows.Services.Store.StoreSendRequestResult.HttpStatusCode.get
	}
}