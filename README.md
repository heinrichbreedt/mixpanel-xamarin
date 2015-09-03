# mixpanel-xamarin

## Build android: 
using VS in release mode

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

## Create nuget

compile in release mode both libs using the help above
On a command line:

pack.bat

## Thks

https://cocoapods.org/
NinZine (Andreas Kröhnke)


