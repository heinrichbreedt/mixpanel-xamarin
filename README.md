# mixpanel-xamarin

iOS + Android bindings for MixPanel (i386, armv7, arm64).
i86_64 has been left out because Xamarin linker fails.
armv7s has been left out as it is optional and makes the app size thinner.

#Status
iOS: working OK on device. Unable to get it to work on simulator.
Android: linking won't work

# Usage

To connect to the webinterface, press 4 fingers for 5 seconds on the device, or press the option key + click and hold in the simulator for 5 seconds.

#Important

On iOS: you need to have a non null Window property in your AppDelegate file. Otherwise Mixpanel throws an exception.


    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate
    {
        UIWindow window;

        /// <summary>
        /// Required for MixPanel
        /// </summary>
        [Preserve]
        public override UIWindow Window { get { return window; }}

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //Setup main window
            window = new UIWindow(UIScreen.MainScreen.Bounds);

             ...

            window.MakeKeyAndVisible();

            return false;
        }

