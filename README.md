# mixpanel 2.8.3 xamarin bindings
iOS + Android bindings for MixPanel (i386, armv7, arm64).
i86_64 has been left out because Xamarin linker fails.
armv7s has been left out as it is optional and makes the app size thinner.

#Status
iOS: working OK on device and simulator. It seems it requires the ALT key not the Option key though.  
Android: linking won't currenlty work. Seems a bug in current Xamarin version. Will check that later this month.

# Usage
To connect to the webinterface, open the webinterface in a browser, then on the device press 4 fingers for 5 seconds, or in the simulator press the option (or alt?) key + click and hold both key and clic in the simulator for 5 seconds. The app's window should be rendered in the webinterface.

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


## Build android: 
Using VS in release mode

1) Download latest .aar file for mixpanel

2) Replace it in the Jars folder. Make sure build action is LibraryProjectZip.

3) Build in release mode

## Build ios:
On a mac, open a command line in the mixpanel-xamarin folder.

0) Make sure cocoapod is installed: 

sudo gem install cocoapods

1) Download latest source code: https://github.com/mixpanel/mixpanel-iphone/releases/ 
and extract it in the mixpanel-xamarin/ subfolder.

2) Open MixpanelStaticLibrary\Mixpanel.xcodeproj in xcode, and update the project's files to reflect the changes in the latest source code

Remove the files in red (deleted files), open the "add files" box by right clicking the project folder and add the files in black (new files).

3) Build the static ios lib from a command line in mixpanel/

make

4) Open the solution in Xamarin Studio Mac, build in release mode

## Create the nuget

Compile in release mode both libs using the help above.
On a command line:

pack.bat

## Credits

https://cocoapods.org/
NinZine (Andreas Kröhnke)
