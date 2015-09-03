XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=./MixpanelStaticLibrary
PROJECT=$(PROJECT_ROOT)/Mixpanel.xcodeproj
TARGET=Mixpanel

all: libMixpanel.a
	 xbuild MixpanelBindings/*.csproj  /property:Configuration=Release

libMixpanel-i386.a:
	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch i386 -configuration Release clean build
		    -mv $(PROJECT_ROOT)/build/i386/lib$(TARGET).a $@

#libMixpanel-x86_64.a:
#	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch x86_64 -configuration Release clean build
#		    -mv $(PROJECT_ROOT)/build/x86_64/lib$(TARGET).a $@

libMixpanel-armv7.a:
	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
		    -mv $(PROJECT_ROOT)/build/armv7/lib$(TARGET).a $@

#libMixpanel-armv7s.a:
#	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
#		    -mv $(PROJECT_ROOT)/build/armv7s/lib$(TARGET).a $@

libMixpanel-arm64.a:
	    $(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
		    -mv $(PROJECT_ROOT)/build/arm64/lib$(TARGET).a $@


#libMixpanel-x86_64.a 
#libMixpanel-armv7s.a

libMixpanel.a: libMixpanel-i386.a libMixpanel-armv7.a libMixpanel-arm64.a
	    lipo -create -output $@ $^
		-rm $^
		-mv $@ ./MixpanelBindings/

clean:
	    -rm -f *.a *.dll
