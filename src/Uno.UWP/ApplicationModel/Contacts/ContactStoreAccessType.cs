namespace Windows.ApplicationModel.Contacts
{
	public enum ContactStoreAccessType
	{
		AllContactsReadOnly = 1,

#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented]
		AppContactsReadWrite = 0,
#endif

#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		[global::Uno.NotImplemented]
		AllContactsReadWrite = 2,
#endif
	}
}
