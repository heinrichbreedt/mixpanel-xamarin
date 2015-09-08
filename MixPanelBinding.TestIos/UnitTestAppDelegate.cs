using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;
using MonoTouch.NUnit.UI;

namespace MixPanelBinding.TestIos
{
	[Register ("UnitTestAppDelegate")]
	public partial class UnitTestAppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		TouchRunner runner;

        /// <summary>
        /// Required by Mixpanel, otherwise it crashes
        /// </summary>
        [Preserve]
	    public override UIWindow Window { get { return window; } }

	    //
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
            MixPanelStat.Init();


            runner = new TouchRunner (window);
			// register every tests included in the main application/assembly
			runner.Add (System.Reflection.Assembly.GetExecutingAssembly ());

			window.RootViewController = new UINavigationController (runner.GetViewController ());
			// make the window visible
			window.MakeKeyAndVisible ();
			return true;
		}
	}
}
