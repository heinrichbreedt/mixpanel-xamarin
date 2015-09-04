using System;
using ObjCRuntime;

//[assembly: LinkWith ("libMixpanel.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, 
//Removed Simulator64, it does not work with the xamarin version used (error on link in the test project)
//Removed armv7s, it is not required for appstore submission and does not provide improvements

[assembly: LinkWith ("libMixpanel.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64, SmartLink = true, 
    Frameworks = "Security SystemConfiguration QuartzCore CFNetwork CoreTelephony", LinkerFlags = "-licucore", ForceLoad = true)]
