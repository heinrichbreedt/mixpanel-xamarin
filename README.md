# Mixpanel bindings for Xamarin
iOS v2.9.1 (armv7, arm64)
Android 2.8.3 (not working)

#Status
iOS: working OK on device (and simulator if i386 is included in cocoapod). It seems it requires the ALT key not the Option key though.  
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

## Build iOS (new):
On a mac, install objective sharpie from https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/objective_sharpie/

Open a command line in the mixpanel-xamarin folder. Make sure cocoapod is installed: 

	sudo gem install cocoapods

Find which sdk is installed on the mac:

    sharpie xcode -sdks

Create a new binding project with the correct sdk identifier. In 2 steps, "init" then "bind":

	sharpie pod init iphoneos9.1 Mixpanel
	(things happens)
	sharpie pod bind iphoneos9.1 Mixpanel
	(project is build, .a and .cs files are generated)

It generates two .cs files (ApiDefinitions.cs and StructsAndEnums.cs), and the .a file containing the target architectures.
The following command displays the architectures contained in the .a file.

	cd ~/Library/Caches/Xamarin
	lipo -info build/Release-iphoneos/libMixpanel.a

Open the solution in Xamarin Studio Mac, override the existing libMixpanel.a with the new one, compare/override the content of the .cs files, then build in release mode. 
The output is the DLL in the project's Release folder.

## Create the nuget

Compile in release mode both libs using the help above. Make sure the DLL from the release folder of Android and iOS are up to date.

Open pack.bat, and update the version number. Open Vapolia.Mixpanel.nuspec then add release notes for this version. Then on an elevated command prompt:

	pack.bat
