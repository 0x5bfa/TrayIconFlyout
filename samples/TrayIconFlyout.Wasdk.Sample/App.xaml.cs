// Copyright (c) 0x5BFA. All rights reserved.
// Licensed under the MIT license.

using Microsoft.UI.Xaml;
using System;

namespace U5BFA.Libraries
{
	public partial class App : Application
	{
		private Window? _window;

		public App()
		{
			InitializeComponent();

			AppDomain.CurrentDomain.ProcessExit += AppDomain_ProcessExit;
		}

		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			_window = new MainWindow();
			_window.Activate();
			_window.DispatcherQueue.EnsureSystemDispatcherQueue();

			TrayIconManager.Default.Initialize();
		}

		private void AppDomain_ProcessExit(object? sender, EventArgs e)
		{
			TrayIconManager.Default.Dispose();
		}
	}
}
