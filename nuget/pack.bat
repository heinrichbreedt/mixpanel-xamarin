@rem NuGet.CommandLine is too old and does not support Xamarin.iOS libs
@rem @echo Please install the package "NuGet.CommandLine" from https://chocolatey.org/ before running this script
@rem @echo After chocolatey is installed, type: choco install NuGet.CommandLine

@echo Before running this script, download nuget.exe from @echo https://nuget.codeplex.com/releases/view/133091
@echo and put nuget.exe in the path.

set nugetexe=NuGet
del *.nupkg
set version=4.7.1
%nugetexe% pack Vapolia.Mixpanel.nuspec -Version "%version%"
%nugetexe% push Vapolia.Mixpanel*.nupkg

pause
