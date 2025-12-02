// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT license.

using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace U5BFA.Libraries
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			Suspending += OnSuspending;
		}

		protected override void OnLaunched(LaunchActivatedEventArgs e)
		{
			if (Window.Current.Content is not Frame rootFrame)
			{
				rootFrame = new Frame();
				Window.Current.Content = rootFrame;
			}

			if (!e.PrelaunchActivated)
			{
				if (rootFrame.Content is null)
					rootFrame.Navigate(typeof(MainPage), e.Arguments);
				Window.Current.Activate();
			}

			TrayIconManager.Default.Initialize();
		}

		private void OnSuspending(object sender, SuspendingEventArgs e)
		{
			SuspendingDeferral deferral = e.SuspendingOperation.GetDeferral();

			deferral.Complete();
		}
	}
}
