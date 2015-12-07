using System;
using System.Drawing;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace MixpanelBindings
{
    // @interface Mixpanel : NSObject
    [BaseType(typeof(NSObject))]
    interface Mixpanel
    {
        // @property (readonly, atomic, strong) MixpanelPeople * people;
        [Export("people", ArgumentSemantic.Strong)]
        MixpanelPeople People { get; }

        // @property (readonly, copy, atomic) NSString * distinctId;
        [Export("distinctId")]
        string DistinctId { get; }

        // @property (copy, atomic) NSString * nameTag;
        [Export("nameTag")]
        string NameTag { get; set; }

        // @property (copy, atomic) NSString * serverURL;
        [Export("serverURL")]
        string ServerURL { get; set; }

        // @property (atomic) NSUInteger flushInterval;
        [Export("flushInterval")]
        nuint FlushInterval { get; set; }

        // @property (atomic) BOOL flushOnBackground;
        [Export("flushOnBackground")]
        bool FlushOnBackground { get; set; }

        // @property (atomic) BOOL showNetworkActivityIndicator;
        [Export("showNetworkActivityIndicator")]
        bool ShowNetworkActivityIndicator { get; set; }

        // @property (atomic) BOOL checkForSurveysOnActive;
        [Export("checkForSurveysOnActive")]
        bool CheckForSurveysOnActive { get; set; }

        // @property (atomic) BOOL showSurveyOnActive;
        [Export("showSurveyOnActive")]
        bool ShowSurveyOnActive { get; set; }

        // @property (atomic) BOOL checkForNotificationsOnActive;
        [Export("checkForNotificationsOnActive")]
        bool CheckForNotificationsOnActive { get; set; }

        // @property (atomic) BOOL checkForVariantsOnActive;
        [Export("checkForVariantsOnActive")]
        bool CheckForVariantsOnActive { get; set; }

        // @property (atomic) BOOL showNotificationOnActive;
        [Export("showNotificationOnActive")]
        bool ShowNotificationOnActive { get; set; }

        // @property (atomic) CGFloat miniNotificationPresentationTime;
        [Export("miniNotificationPresentationTime")]
        nfloat MiniNotificationPresentationTime { get; set; }

        // @property (atomic) UIColor * miniNotificationBackgroundColor;
        [Export("miniNotificationBackgroundColor", ArgumentSemantic.Assign)]
        UIColor MiniNotificationBackgroundColor { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MixpanelDelegate Delegate { get; set; }

        // @property (atomic, weak) id<MixpanelDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // +(Mixpanel *)sharedInstanceWithToken:(NSString *)apiToken;
        [Static]
        [Export("sharedInstanceWithToken:")]
        Mixpanel SharedInstanceWithToken(string apiToken);

        // +(Mixpanel *)sharedInstanceWithToken:(NSString *)apiToken launchOptions:(NSDictionary *)launchOptions;
        [Static]
        [Export("sharedInstanceWithToken:launchOptions:")]
        Mixpanel SharedInstanceWithToken(string apiToken, NSDictionary launchOptions);

        // +(Mixpanel *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        Mixpanel SharedInstance { get; }

        // -(instancetype)initWithToken:(NSString *)apiToken launchOptions:(NSDictionary *)launchOptions andFlushInterval:(NSUInteger)flushInterval;
        [Export("initWithToken:launchOptions:andFlushInterval:")]
        IntPtr Constructor(string apiToken, NSDictionary launchOptions, nuint flushInterval);

        // -(instancetype)initWithToken:(NSString *)apiToken andFlushInterval:(NSUInteger)flushInterval;
        [Export("initWithToken:andFlushInterval:")]
        IntPtr Constructor(string apiToken, nuint flushInterval);

        // -(void)identify:(NSString *)distinctId;
        [Export("identify:")]
        void Identify(string distinctId);

        // -(void)track:(NSString *)event;
        [Export("track:")]
        void Track(string @event);

        // -(void)track:(NSString *)event properties:(NSDictionary *)properties;
        [Export("track:properties:")]
        void Track(string @event, NSDictionary properties);

        // -(void)trackPushNotification:(NSDictionary *)userInfo;
        [Export("trackPushNotification:")]
        void TrackPushNotification(NSDictionary userInfo);

        // -(void)registerSuperProperties:(NSDictionary *)properties;
        [Export("registerSuperProperties:")]
        void RegisterSuperProperties(NSDictionary properties);

        // -(void)registerSuperPropertiesOnce:(NSDictionary *)properties;
        [Export("registerSuperPropertiesOnce:")]
        void RegisterSuperPropertiesOnce(NSDictionary properties);

        // -(void)registerSuperPropertiesOnce:(NSDictionary *)properties defaultValue:(id)defaultValue;
        [Export("registerSuperPropertiesOnce:defaultValue:")]
        void RegisterSuperPropertiesOnce(NSDictionary properties, NSObject defaultValue);

        // -(void)unregisterSuperProperty:(NSString *)propertyName;
        [Export("unregisterSuperProperty:")]
        void UnregisterSuperProperty(string propertyName);

        // -(void)clearSuperProperties;
        [Export("clearSuperProperties")]
        void ClearSuperProperties();

        // -(NSDictionary *)currentSuperProperties;
        [Export("currentSuperProperties")]
        NSDictionary CurrentSuperProperties { get; }

        // -(void)timeEvent:(NSString *)event;
        [Export("timeEvent:")]
        void TimeEvent(string @event);

        // -(void)clearTimedEvents;
        [Export("clearTimedEvents")]
        void ClearTimedEvents();

        // -(void)reset;
        [Export("reset")]
        void Reset();

        // -(void)flush;
        [Export("flush")]
        void Flush();

        // -(void)flushWithCompletion:(void (^)())handler;
        [Export("flushWithCompletion:")]
        void FlushWithCompletion(Action handler);

        // -(void)archive;
        [Export("archive")]
        void Archive();

        // -(void)createAlias:(NSString *)alias forDistinctID:(NSString *)distinctID;
        [Export("createAlias:forDistinctID:")]
        void CreateAlias(string alias, string distinctID);

        // -(NSString *)libVersion;
        [Export("libVersion")]
        string LibVersion { get; }

        // -(void)showSurveyWithID:(NSUInteger)ID;
        [Export("showSurveyWithID:")]
        void ShowSurveyWithID(nuint ID);

        // -(void)showSurvey;
        [Export("showSurvey")]
        void ShowSurvey();

        // -(void)showNotificationWithID:(NSUInteger)ID;
        [Export("showNotificationWithID:")]
        void ShowNotificationWithID(nuint ID);

        // -(void)showNotificationWithType:(NSString *)type;
        [Export("showNotificationWithType:")]
        void ShowNotificationWithType(string type);

        // -(void)showNotification;
        [Export("showNotification")]
        void ShowNotification();

        // -(void)joinExperiments;
        [Export("joinExperiments")]
        void JoinExperiments();

        // -(void)joinExperimentsWithCallback:(void (^)())experimentsLoadedCallback;
        [Export("joinExperimentsWithCallback:")]
        void JoinExperimentsWithCallback(Action experimentsLoadedCallback);
    }

    // @interface MixpanelPeople : NSObject
    [BaseType(typeof(NSObject))]
    interface MixpanelPeople
    {
        // -(void)addPushDeviceToken:(NSData *)deviceToken;
        [Export("addPushDeviceToken:")]
        void AddPushDeviceToken(NSData deviceToken);

        // -(void)set:(NSDictionary *)properties;
        [Export("set:")]
        void Set(NSDictionary properties);

        // -(void)set:(NSString *)property to:(id)object;
        [Export("set:to:")]
        void Set(string property, NSObject @object);

        // -(void)setOnce:(NSDictionary *)properties;
        [Export("setOnce:")]
        void SetOnce(NSDictionary properties);

        // -(void)increment:(NSDictionary *)properties;
        [Export("increment:")]
        void Increment(NSDictionary properties);

        // -(void)increment:(NSString *)property by:(NSNumber *)amount;
        [Export("increment:by:")]
        void Increment(string property, NSNumber amount);

        // -(void)append:(NSDictionary *)properties;
        [Export("append:")]
        void Append(NSDictionary properties);

        // -(void)union:(NSDictionary *)properties;
        [Export("union:")]
        void Union(NSDictionary properties);

        // -(void)trackCharge:(NSNumber *)amount;
        [Export("trackCharge:")]
        void TrackCharge(NSNumber amount);

        // -(void)trackCharge:(NSNumber *)amount withProperties:(NSDictionary *)properties;
        [Export("trackCharge:withProperties:")]
        void TrackCharge(NSNumber amount, NSDictionary properties);

        // -(void)clearCharges;
        [Export("clearCharges")]
        void ClearCharges();

        // -(void)deleteUser;
        [Export("deleteUser")]
        void DeleteUser();
    }

    // @protocol MixpanelDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MixpanelDelegate
    {
        // @optional -(BOOL)mixpanelWillFlush:(Mixpanel *)mixpanel;
        [Export("mixpanelWillFlush:")]
        bool MixpanelWillFlush(Mixpanel mixpanel);
    }

	/*
    // @protocol MPABTestDesignerMessage <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPABTestDesignerMessage
    {
        // @required @property (readonly, copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; }

        // @required -(void)setPayloadObject:(id)object forKey:(NSString *)key;
        [Abstract]
        [Export("setPayloadObject:forKey:")]
        void SetPayloadObject(NSObject @object, string key);

        // @required -(id)payloadObjectForKey:(NSString *)key;
        [Abstract]
        [Export("payloadObjectForKey:")]
        NSObject PayloadObjectForKey(string key);

        // @required -(NSData *)JSONData;
        [Abstract]
        [Export("JSONData")]
        [Verify(MethodToProperty)]
        NSData JSONData { get; }

        // @required -(NSOperation *)responseCommandWithConnection:(MPABTestDesignerConnection *)connection;
        [Abstract]
        [Export("responseCommandWithConnection:")]
        NSOperation ResponseCommandWithConnection(MPABTestDesignerConnection connection);
    }

    // @interface MPAbstractABTestDesignerMessage : NSObject <MPABTestDesignerMessage>
    [BaseType(typeof(NSObject))]
    interface MPAbstractABTestDesignerMessage : IMPABTestDesignerMessage
    {
        // @property (readonly, copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; }

        // +(instancetype)messageWithType:(NSString *)type payload:(NSDictionary *)payload;
        [Static]
        [Export("messageWithType:payload:")]
        MPAbstractABTestDesignerMessage MessageWithType(string type, NSDictionary payload);

        // -(instancetype)initWithType:(NSString *)type;
        [Export("initWithType:")]
        IntPtr Constructor(string type);

        // -(instancetype)initWithType:(NSString *)type payload:(NSDictionary *)payload;
        [Export("initWithType:payload:")]
        IntPtr Constructor(string type, NSDictionary payload);

        // -(void)setPayloadObject:(id)object forKey:(NSString *)key;
        [Export("setPayloadObject:forKey:")]
        void SetPayloadObject(NSObject @object, string key);

        // -(id)payloadObjectForKey:(NSString *)key;
        [Export("payloadObjectForKey:")]
        NSObject PayloadObjectForKey(string key);

        // -(NSDictionary *)payload;
        [Export("payload")]
        [Verify(MethodToProperty)]
        NSDictionary Payload { get; }

        // -(NSData *)JSONData;
        [Export("JSONData")]
        [Verify(MethodToProperty)]
        NSData JSONData { get; }
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const MPABTestDesignerChangeRequestMessageType;
        [Field("MPABTestDesignerChangeRequestMessageType", "__Internal")]
        NSString MPABTestDesignerChangeRequestMessageType { get; }
    }

    // @interface MPABTestDesignerChangeRequestMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerChangeRequestMessage
    {
    }

    // @interface MPABTestDesignerChangeResponseMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerChangeResponseMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPABTestDesignerChangeResponseMessage Message();

        // @property (copy, nonatomic) NSString * status;
        [Export("status")]
        string Status { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPABTestDesignerClearRequestMessageType;
        [Field("MPABTestDesignerClearRequestMessageType", "__Internal")]
        NSString MPABTestDesignerClearRequestMessageType { get; }
    }

    // @interface MPABTestDesignerClearRequestMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerClearRequestMessage
    {
    }

    // @interface MPABTestDesignerClearResponseMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerClearResponseMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPABTestDesignerClearResponseMessage Message();

        // @property (copy, nonatomic) NSString * status;
        [Export("status")]
        string Status { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPWebSocketErrorDomain;
        [Field("MPWebSocketErrorDomain", "__Internal")]
        NSString MPWebSocketErrorDomain { get; }
    }

    // @interface MPWebSocket : NSObject <NSStreamDelegate>
    [BaseType(typeof(NSObject))]
    interface MPWebSocket : INSStreamDelegate
    {
        [Wrap("WeakDelegate")]
        MPWebSocketDelegate Delegate { get; set; }

        // @property (assign, nonatomic) id<MPWebSocketDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) MPWebSocketReadyState readyState;
        [Export("readyState")]
        MPWebSocketReadyState ReadyState { get; }

        // @property (readonly, retain, nonatomic) NSURL * url;
        [Export("url", ArgumentSemantic.Retain)]
        NSUrl Url { get; }

        // @property (readonly, copy, nonatomic) NSString * protocol;
        [Export("protocol")]
        string Protocol { get; }

        // -(instancetype)initWithURLRequest:(NSURLRequest *)request protocols:(NSArray *)protocols;
        [Export("initWithURLRequest:protocols:")]
        [Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSUrlRequest request, NSObject[] protocols);

        // -(instancetype)initWithURLRequest:(NSURLRequest *)request;
        [Export("initWithURLRequest:")]
        IntPtr Constructor(NSUrlRequest request);

        // -(instancetype)initWithURL:(NSURL *)url protocols:(NSArray *)protocols;
        [Export("initWithURL:protocols:")]
        [Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSUrl url, NSObject[] protocols);

        // -(instancetype)initWithURL:(NSURL *)url;
        [Export("initWithURL:")]
        IntPtr Constructor(NSUrl url);

        // -(void)setDelegateOperationQueue:(NSOperationQueue *)queue;
        [Export("setDelegateOperationQueue:")]
        void SetDelegateOperationQueue(NSOperationQueue queue);

        // -(void)setDelegateDispatchQueue:(dispatch_queue_t)queue;
        [Export("setDelegateDispatchQueue:")]
        void SetDelegateDispatchQueue(DispatchQueue queue);

        // -(void)scheduleInRunLoop:(NSRunLoop *)aRunLoop forMode:(NSString *)mode;
        [Export("scheduleInRunLoop:forMode:")]
        void ScheduleInRunLoop(NSRunLoop aRunLoop, string mode);

        // -(void)unscheduleFromRunLoop:(NSRunLoop *)aRunLoop forMode:(NSString *)mode;
        [Export("unscheduleFromRunLoop:forMode:")]
        void UnscheduleFromRunLoop(NSRunLoop aRunLoop, string mode);

        // -(void)open;
        [Export("open")]
        void Open();

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)closeWithCode:(NSInteger)code reason:(NSString *)reason;
        [Export("closeWithCode:reason:")]
        void CloseWithCode(nint code, string reason);

        // -(void)send:(id)data;
        [Export("send:")]
        void Send(NSObject data);
    }

    // @protocol MPWebSocketDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPWebSocketDelegate
    {
        // @required -(void)webSocket:(MPWebSocket *)webSocket didReceiveMessage:(id)message;
        [Abstract]
        [Export("webSocket:didReceiveMessage:")]
        void WebSocket(MPWebSocket webSocket, NSObject message);

        // @optional -(void)webSocketDidOpen:(MPWebSocket *)webSocket;
        [Export("webSocketDidOpen:")]
        void WebSocketDidOpen(MPWebSocket webSocket);

        // @optional -(void)webSocket:(MPWebSocket *)webSocket didFailWithError:(NSError *)error;
        [Export("webSocket:didFailWithError:")]
        void WebSocket(MPWebSocket webSocket, NSError error);

        // @optional -(void)webSocket:(MPWebSocket *)webSocket didCloseWithCode:(NSInteger)code reason:(NSString *)reason wasClean:(BOOL)wasClean;
        [Export("webSocket:didCloseWithCode:reason:wasClean:")]
        void WebSocket(MPWebSocket webSocket, nint code, string reason, bool wasClean);
    }

    // @interface CertificateAdditions (NSURLRequest)
    [Category]
    [BaseType(typeof(NSUrlRequest))]
    interface NSURLRequest_CertificateAdditions
    {
        // @property (readonly, retain, nonatomic) NSArray * mp_SSLPinnedCertificates;
        [Export("mp_SSLPinnedCertificates", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Mp_SSLPinnedCertificates { get; }
    }

    // @interface CertificateAdditions (NSMutableURLRequest)
    [Category]
    [BaseType(typeof(NSMutableUrlRequest))]
    interface NSMutableURLRequest_CertificateAdditions
    {
        // @property (retain, nonatomic) NSArray * mp_SSLPinnedCertificates;
        [Export("mp_SSLPinnedCertificates", ArgumentSemantic.Retain)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Mp_SSLPinnedCertificates { get; set; }
    }

    // @interface MPWebSocket (NSRunLoop)
    [Category]
    [BaseType(typeof(NSRunLoop))]
    interface NSRunLoop_MPWebSocket
    {
        // +(NSRunLoop *)mp_networkRunLoop;
        [Static]
        [Export("mp_networkRunLoop")]
        [Verify(MethodToProperty)]
        NSRunLoop Mp_networkRunLoop { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const kSessionVariantKey;
        [Field("kSessionVariantKey", "__Internal")]
        NSString kSessionVariantKey { get; }
    }

    // @interface MPABTestDesignerConnection : NSObject
    [BaseType(typeof(NSObject))]
    interface MPABTestDesignerConnection
    {
        // @property (readonly, nonatomic) BOOL connected;
        [Export("connected")]
        bool Connected { get; }

        // @property (assign, nonatomic) BOOL sessionEnded;
        [Export("sessionEnded")]
        bool SessionEnded { get; set; }

        // -(instancetype)initWithURL:(NSURL *)url;
        [Export("initWithURL:")]
        IntPtr Constructor(NSUrl url);

        // -(instancetype)initWithURL:(NSURL *)url keepTrying:(BOOL)keepTrying connectCallback:(void (^)())connectCallback disconnectCallback:(void (^)())disconnectCallback;
        [Export("initWithURL:keepTrying:connectCallback:disconnectCallback:")]
        IntPtr Constructor(NSUrl url, bool keepTrying, Action connectCallback, Action disconnectCallback);

        // -(void)setSessionObject:(id)object forKey:(NSString *)key;
        [Export("setSessionObject:forKey:")]
        void SetSessionObject(NSObject @object, string key);

        // -(id)sessionObjectForKey:(NSString *)key;
        [Export("sessionObjectForKey:")]
        NSObject SessionObjectForKey(string key);

        // -(void)sendMessage:(id<MPABTestDesignerMessage>)message;
        [Export("sendMessage:")]
        void SendMessage(MPABTestDesignerMessage message);

        // -(void)close;
        [Export("close")]
        void Close();
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPABTestDesignerDeviceInfoRequestMessageType;
        [Field("MPABTestDesignerDeviceInfoRequestMessageType", "__Internal")]
        NSString MPABTestDesignerDeviceInfoRequestMessageType { get; }
    }

    // @interface MPABTestDesignerDeviceInfoRequestMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerDeviceInfoRequestMessage
    {
    }

    // @interface MPABTestDesignerDeviceInfoResponseMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerDeviceInfoResponseMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPABTestDesignerDeviceInfoResponseMessage Message();

        // @property (copy, nonatomic) NSString * systemName;
        [Export("systemName")]
        string SystemName { get; set; }

        // @property (copy, nonatomic) NSString * systemVersion;
        [Export("systemVersion")]
        string SystemVersion { get; set; }

        // @property (copy, nonatomic) NSString * appVersion;
        [Export("appVersion")]
        string AppVersion { get; set; }

        // @property (copy, nonatomic) NSString * appRelease;
        [Export("appRelease")]
        string AppRelease { get; set; }

        // @property (copy, nonatomic) NSString * deviceName;
        [Export("deviceName")]
        string DeviceName { get; set; }

        // @property (copy, nonatomic) NSString * deviceModel;
        [Export("deviceModel")]
        string DeviceModel { get; set; }

        // @property (copy, nonatomic) NSString * libVersion;
        [Export("libVersion")]
        string LibVersion { get; set; }

        // @property (copy, nonatomic) NSArray * availableFontFamilies;
        [Export("availableFontFamilies", ArgumentSemantic.Copy)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] AvailableFontFamilies { get; set; }

        // @property (copy, nonatomic) NSString * mainBundleIdentifier;
        [Export("mainBundleIdentifier")]
        string MainBundleIdentifier { get; set; }

        // @property (copy, nonatomic) NSArray * tweaks;
        [Export("tweaks", ArgumentSemantic.Copy)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Tweaks { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPABTestDesignerDisconnectMessageType;
        [Field("MPABTestDesignerDisconnectMessageType", "__Internal")]
        NSString MPABTestDesignerDisconnectMessageType { get; }
    }

    // @interface MPABTestDesignerDisconnectMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerDisconnectMessage
    {
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPABTestDesignerSnapshotRequestMessageType;
        [Field("MPABTestDesignerSnapshotRequestMessageType", "__Internal")]
        NSString MPABTestDesignerSnapshotRequestMessageType { get; }
    }

    // @interface MPABTestDesignerSnapshotRequestMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerSnapshotRequestMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPABTestDesignerSnapshotRequestMessage Message();

        // @property (readonly, nonatomic) MPObjectSerializerConfig * configuration;
        [Export("configuration")]
        MPObjectSerializerConfig Configuration { get; }
    }

    // @interface MPABTestDesignerSnapshotResponseMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerSnapshotResponseMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPABTestDesignerSnapshotResponseMessage Message();

        // @property (nonatomic, strong) UIImage * screenshot;
        [Export("screenshot", ArgumentSemantic.Strong)]
        UIImage Screenshot { get; set; }

        // @property (copy, nonatomic) NSDictionary * serializedObjects;
        [Export("serializedObjects", ArgumentSemantic.Copy)]
        NSDictionary SerializedObjects { get; set; }

        // @property (readonly, nonatomic, strong) NSString * imageHash;
        [Export("imageHash", ArgumentSemantic.Strong)]
        string ImageHash { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPABTestDesignerTweakRequestMessageType;
        [Field("MPABTestDesignerTweakRequestMessageType", "__Internal")]
        NSString MPABTestDesignerTweakRequestMessageType { get; }
    }

    // @interface MPABTestDesignerTweakRequestMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerTweakRequestMessage
    {
    }

    // @interface MPABTestDesignerTweakResponseMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPABTestDesignerTweakResponseMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPABTestDesignerTweakResponseMessage Message();

        // @property (copy, nonatomic) NSString * status;
        [Export("status")]
        string Status { get; set; }
    }

    // @interface MPApplicationStateSerializer : NSObject
    [BaseType(typeof(NSObject))]
    interface MPApplicationStateSerializer
    {
        // -(instancetype)initWithApplication:(UIApplication *)application configuration:(MPObjectSerializerConfig *)configuration objectIdentityProvider:(MPObjectIdentityProvider *)objectIdentityProvider;
        [Export("initWithApplication:configuration:objectIdentityProvider:")]
        IntPtr Constructor(UIApplication application, MPObjectSerializerConfig configuration, MPObjectIdentityProvider objectIdentityProvider);

        // -(UIImage *)screenshotImageForWindowAtIndex:(NSUInteger)index;
        [Export("screenshotImageForWindowAtIndex:")]
        UIImage ScreenshotImageForWindowAtIndex(nuint index);

        // -(NSDictionary *)objectHierarchyForWindowAtIndex:(NSUInteger)index;
        [Export("objectHierarchyForWindowAtIndex:")]
        NSDictionary ObjectHierarchyForWindowAtIndex(nuint index);
    }

    // @interface MPTypeDescription : NSObject
    [BaseType(typeof(NSObject))]
    interface MPTypeDescription
    {
        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);

        // @property (readonly, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; }
    }

    // @interface MPClassDescription : MPTypeDescription
    [BaseType(typeof(MPTypeDescription))]
    interface MPClassDescription
    {
        // @property (readonly, nonatomic) MPClassDescription * superclassDescription;
        [Export("superclassDescription")]
        MPClassDescription SuperclassDescription { get; }

        // @property (readonly, nonatomic) NSArray * propertyDescriptions;
        [Export("propertyDescriptions")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] PropertyDescriptions { get; }

        // @property (readonly, nonatomic) NSArray * delegateInfos;
        [Export("delegateInfos")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] DelegateInfos { get; }

        // -(instancetype)initWithSuperclassDescription:(MPClassDescription *)superclassDescription dictionary:(NSDictionary *)dictionary;
        [Export("initWithSuperclassDescription:dictionary:")]
        IntPtr Constructor(MPClassDescription superclassDescription, NSDictionary dictionary);

        // -(BOOL)isDescriptionForKindOfClass:(Class)class;
        [Export("isDescriptionForKindOfClass:")]
        bool IsDescriptionForKindOfClass(Class @class);
    }

    // @interface MPDelegateInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface MPDelegateInfo
    {
        // @property (readonly, nonatomic) NSString * selectorName;
        [Export("selectorName")]
        string SelectorName { get; }

        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPDesignerEventBindingRequestMessageType;
        [Field("MPDesignerEventBindingRequestMessageType", "__Internal")]
        NSString MPDesignerEventBindingRequestMessageType { get; }
    }

    // @interface MPDesignerEventBindingRequestMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPDesignerEventBindingRequestMessage
    {
    }

    // @interface MPDesignerEventBindingRequestMesssage : MPDesignerEventBindingRequestMessage
    [BaseType(typeof(MPDesignerEventBindingRequestMessage))]
    interface MPDesignerEventBindingRequestMesssage
    {
    }

    // @interface MPDesignerEventBindingResponseMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPDesignerEventBindingResponseMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPDesignerEventBindingResponseMessage Message();

        // @property (copy, nonatomic) NSString * status;
        [Export("status")]
        string Status { get; set; }
    }

    // @interface MPDesignerEventBindingResponseMesssage : MPDesignerEventBindingResponseMessage
    [BaseType(typeof(MPDesignerEventBindingResponseMessage))]
    interface MPDesignerEventBindingResponseMesssage
    {
    }

    // @interface MPDesignerTrackMessage : MPAbstractABTestDesignerMessage
    [BaseType(typeof(MPAbstractABTestDesignerMessage))]
    interface MPDesignerTrackMessage
    {
        // +(instancetype)message;
        [Static]
        [Export("message")]
        MPDesignerTrackMessage Message();

        // +(instancetype)messageWithPayload:(NSDictionary *)payload;
        [Static]
        [Export("messageWithPayload:")]
        MPDesignerTrackMessage MessageWithPayload(NSDictionary payload);
    }

    // @protocol MPDesignerSessionCollection <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPDesignerSessionCollection
    {
        // @required -(void)cleanup;
        [Abstract]
        [Export("cleanup")]
        void Cleanup();
    }

    // @interface MPEnumDescription : MPTypeDescription
    [BaseType(typeof(MPTypeDescription))]
    interface MPEnumDescription
    {
        // @property (readonly, getter = isFlagsSet, assign, nonatomic) BOOL flagSet;
        [Export("flagSet")]
        bool FlagSet { [Bind("isFlagsSet")] get; }

        // @property (readonly, copy, nonatomic) NSString * baseType;
        [Export("baseType")]
        string BaseType { get; }

        // -(NSArray *)allValues;
        [Export("allValues")]
        [Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] AllValues { get; }
    }

    // @interface MPObjectSelector : NSObject
    [BaseType(typeof(NSObject))]
    interface MPObjectSelector
    {
        // @property (readonly, nonatomic, strong) NSString * string;
        [Export("string", ArgumentSemantic.Strong)]
        string String { get; }

        // +(MPObjectSelector *)objectSelectorWithString:(NSString *)string;
        [Static]
        [Export("objectSelectorWithString:")]
        MPObjectSelector ObjectSelectorWithString(string @string);

        // -(instancetype)initWithString:(NSString *)string;
        [Export("initWithString:")]
        IntPtr Constructor(string @string);

        // -(NSArray *)selectFromRoot:(id)root;
        [Export("selectFromRoot:")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] SelectFromRoot(NSObject root);

        // -(NSArray *)fuzzySelectFromRoot:(id)root;
        [Export("fuzzySelectFromRoot:")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] FuzzySelectFromRoot(NSObject root);

        // -(BOOL)isLeafSelected:(id)leaf fromRoot:(id)root;
        [Export("isLeafSelected:fromRoot:")]
        bool IsLeafSelected(NSObject leaf, NSObject root);

        // -(BOOL)fuzzyIsLeafSelected:(id)leaf fromRoot:(id)root;
        [Export("fuzzyIsLeafSelected:fromRoot:")]
        bool FuzzyIsLeafSelected(NSObject leaf, NSObject root);

        // -(Class)selectedClass;
        [Export("selectedClass")]
        [Verify(MethodToProperty)]
        Class SelectedClass { get; }

        // -(NSString *)description;
        [Export("description")]
        [Verify(MethodToProperty)]
        string Description { get; }
    }

    // @interface MPEventBinding : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MPEventBinding : INSCoding
    {
        // @property (nonatomic) NSUInteger ID;
        [Export("ID")]
        nuint ID { get; set; }

        // @property (nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (nonatomic) MPObjectSelector * path;
        [Export("path", ArgumentSemantic.Assign)]
        MPObjectSelector Path { get; set; }

        // @property (nonatomic) NSString * eventName;
        [Export("eventName")]
        string EventName { get; set; }

        // @property (assign, nonatomic) Class swizzleClass;
        [Export("swizzleClass", ArgumentSemantic.Assign)]
        Class SwizzleClass { get; set; }

        // @property (nonatomic) BOOL running;
        [Export("running")]
        bool Running { get; set; }

        // +(id)bindingWithJSONObject:(id)object;
        [Static]
        [Export("bindingWithJSONObject:")]
        NSObject BindingWithJSONObject(NSObject @object);

        // +(id)bindngWithJSONObject:(id)object __attribute__((deprecated("")));
        [Static]
        [Export("bindngWithJSONObject:")]
        NSObject BindngWithJSONObject(NSObject @object);

        // -(instancetype)initWithEventName:(NSString *)eventName onPath:(NSString *)path;
        [Export("initWithEventName:onPath:")]
        IntPtr Constructor(string eventName, string path);

        // +(void)track:(NSString *)event properties:(NSDictionary *)properties;
        [Static]
        [Export("track:properties:")]
        void Track(string @event, NSDictionary properties);

        // +(NSString *)typeName;
        [Static]
        [Export("typeName")]
        [Verify(MethodToProperty)]
        string TypeName { get; }

        // -(void)execute;
        [Export("execute")]
        void Execute();

        // -(void)stop;
        [Export("stop")]
        void Stop();
    }

    // @interface MPNotification : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MPNotification
    {
        // @property (readonly, nonatomic) NSUInteger ID;
        [Export("ID")]
        nuint ID { get; }

        // @property (readonly, nonatomic) NSUInteger messageID;
        [Export("messageID")]
        nuint MessageID { get; }

        // @property (nonatomic, strong) NSString * type;
        [Export("type", ArgumentSemantic.Strong)]
        string Type { get; set; }

        // @property (nonatomic, strong) NSURL * imageURL;
        [Export("imageURL", ArgumentSemantic.Strong)]
        NSUrl ImageURL { get; set; }

        // @property (nonatomic, strong) NSData * image;
        [Export("image", ArgumentSemantic.Strong)]
        NSData Image { get; set; }

        // @property (nonatomic, strong) NSString * title;
        [Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * body;
        [Export("body", ArgumentSemantic.Strong)]
        string Body { get; set; }

        // @property (nonatomic, strong) NSString * callToAction;
        [Export("callToAction", ArgumentSemantic.Strong)]
        string CallToAction { get; set; }

        // @property (nonatomic, strong) NSURL * callToActionURL;
        [Export("callToActionURL", ArgumentSemantic.Strong)]
        NSUrl CallToActionURL { get; set; }

        // +(MPNotification *)notificationWithJSONObject:(NSDictionary *)object;
        [Static]
        [Export("notificationWithJSONObject:")]
        MPNotification NotificationWithJSONObject(NSDictionary @object);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MPNotificationTypeMini;
        [Field("MPNotificationTypeMini", "__Internal")]
        NSString MPNotificationTypeMini { get; }

        // extern NSString *const MPNotificationTypeTakeover;
        [Field("MPNotificationTypeTakeover", "__Internal")]
        NSString MPNotificationTypeTakeover { get; }
    }

    // @interface MPNotificationViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface MPNotificationViewController
    {
        // @property (nonatomic, strong) MPNotification * notification;
        [Export("notification", ArgumentSemantic.Strong)]
        MPNotification Notification { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MPNotificationViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MPNotificationViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)hideWithAnimation:(BOOL)animated completion:(void (^)(void))completion;
        [Export("hideWithAnimation:completion:")]
        void HideWithAnimation(bool animated, Action completion);
    }

    // @interface MPTakeoverNotificationViewController : MPNotificationViewController
    [BaseType(typeof(MPNotificationViewController))]
    interface MPTakeoverNotificationViewController
    {
        // @property (nonatomic, strong) UIImage * backgroundImage;
        [Export("backgroundImage", ArgumentSemantic.Strong)]
        UIImage BackgroundImage { get; set; }
    }

    // @interface MPMiniNotificationViewController : MPNotificationViewController
    [BaseType(typeof(MPNotificationViewController))]
    interface MPMiniNotificationViewController
    {
        // @property (nonatomic, strong) UIColor * backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // -(void)showWithAnimation;
        [Export("showWithAnimation")]
        void ShowWithAnimation();
    }

    // @protocol MPNotificationViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPNotificationViewControllerDelegate
    {
        // @required -(void)notificationController:(MPNotificationViewController *)controller wasDismissedWithStatus:(BOOL)status;
        [Abstract]
        [Export("notificationController:wasDismissedWithStatus:")]
        void WasDismissedWithStatus(MPNotificationViewController controller, bool status);
    }

    // @protocol MPObjectIdentifierProvider <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPObjectIdentifierProvider
    {
        // @required -(NSString *)identifierForObject:(id)object;
        [Abstract]
        [Export("identifierForObject:")]
        string IdentifierForObject(NSObject @object);
    }

    // @interface MPObjectIdentityProvider : NSObject
    [BaseType(typeof(NSObject))]
    interface MPObjectIdentityProvider
    {
        // -(NSString *)identifierForObject:(id)object;
        [Export("identifierForObject:")]
        string IdentifierForObject(NSObject @object);
    }

    // @interface MPObjectSerializer : NSObject
    [BaseType(typeof(NSObject))]
    interface MPObjectSerializer
    {
        // -(instancetype)initWithConfiguration:(MPObjectSerializerConfig *)configuration objectIdentityProvider:(MPObjectIdentityProvider *)objectIdentityProvider;
        [Export("initWithConfiguration:objectIdentityProvider:")]
        IntPtr Constructor(MPObjectSerializerConfig configuration, MPObjectIdentityProvider objectIdentityProvider);

        // -(NSDictionary *)serializedObjectsWithRootObject:(id)rootObject;
        [Export("serializedObjectsWithRootObject:")]
        NSDictionary SerializedObjectsWithRootObject(NSObject rootObject);
    }

    // @interface MPObjectSerializerConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface MPObjectSerializerConfig
    {
        // @property (readonly, nonatomic) NSArray * classDescriptions;
        [Export("classDescriptions")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] ClassDescriptions { get; }

        // @property (readonly, nonatomic) NSArray * enumDescriptions;
        [Export("enumDescriptions")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] EnumDescriptions { get; }

        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);

        // -(MPTypeDescription *)typeWithName:(NSString *)name;
        [Export("typeWithName:")]
        MPTypeDescription TypeWithName(string name);

        // -(MPEnumDescription *)enumWithName:(NSString *)name;
        [Export("enumWithName:")]
        MPEnumDescription EnumWithName(string name);

        // -(MPClassDescription *)classWithName:(NSString *)name;
        [Export("classWithName:")]
        MPClassDescription ClassWithName(string name);
    }

    // @interface MPObjectSerializerContext : NSObject
    [BaseType(typeof(NSObject))]
    interface MPObjectSerializerContext
    {
        // -(instancetype)initWithRootObject:(id)object;
        [Export("initWithRootObject:")]
        IntPtr Constructor(NSObject @object);

        // -(BOOL)hasUnvisitedObjects;
        [Export("hasUnvisitedObjects")]
        [Verify(MethodToProperty)]
        bool HasUnvisitedObjects { get; }

        // -(void)enqueueUnvisitedObject:(NSObject *)object;
        [Export("enqueueUnvisitedObject:")]
        void EnqueueUnvisitedObject(NSObject @object);

        // -(NSObject *)dequeueUnvisitedObject;
        [Export("dequeueUnvisitedObject")]
        [Verify(MethodToProperty)]
        NSObject DequeueUnvisitedObject { get; }

        // -(void)addVisitedObject:(NSObject *)object;
        [Export("addVisitedObject:")]
        void AddVisitedObject(NSObject @object);

        // -(BOOL)isVisitedObject:(NSObject *)object;
        [Export("isVisitedObject:")]
        bool IsVisitedObject(NSObject @object);

        // -(void)addSerializedObject:(NSDictionary *)serializedObject;
        [Export("addSerializedObject:")]
        void AddSerializedObject(NSDictionary serializedObject);

        // -(NSArray *)allSerializedObjects;
        [Export("allSerializedObjects")]
        [Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] AllSerializedObjects { get; }
    }

    // @interface MPPropertySelectorParameterDescription : NSObject
    [BaseType(typeof(NSObject))]
    interface MPPropertySelectorParameterDescription
    {
        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);

        // @property (readonly, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; }
    }

    // @interface MPPropertySelectorDescription : NSObject
    [BaseType(typeof(NSObject))]
    interface MPPropertySelectorDescription
    {
        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);

        // @property (readonly, nonatomic) NSString * selectorName;
        [Export("selectorName")]
        string SelectorName { get; }

        // @property (readonly, nonatomic) NSString * returnType;
        [Export("returnType")]
        string ReturnType { get; }

        // @property (readonly, nonatomic) NSArray * parameters;
        [Export("parameters")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Parameters { get; }
    }

    // @interface MPPropertyDescription : NSObject
    [BaseType(typeof(NSObject))]
    interface MPPropertyDescription
    {
        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);

        // @property (readonly, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, nonatomic) BOOL readonly;
        [Export("readonly")]
        bool Readonly { get; }

        // @property (readonly, nonatomic) BOOL nofollow;
        [Export("nofollow")]
        bool Nofollow { get; }

        // @property (readonly, nonatomic) BOOL useKeyValueCoding;
        [Export("useKeyValueCoding")]
        bool UseKeyValueCoding { get; }

        // @property (readonly, nonatomic) BOOL useInstanceVariableAccess;
        [Export("useInstanceVariableAccess")]
        bool UseInstanceVariableAccess { get; }

        // @property (readonly, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic) MPPropertySelectorDescription * getSelectorDescription;
        [Export("getSelectorDescription")]
        MPPropertySelectorDescription GetSelectorDescription { get; }

        // @property (readonly, nonatomic) MPPropertySelectorDescription * setSelectorDescription;
        [Export("setSelectorDescription")]
        MPPropertySelectorDescription SetSelectorDescription { get; }

        // -(BOOL)shouldReadPropertyValueForObject:(NSObject *)object;
        [Export("shouldReadPropertyValueForObject:")]
        bool ShouldReadPropertyValueForObject(NSObject @object);

        // -(NSValueTransformer *)valueTransformer;
        [Export("valueTransformer")]
        [Verify(MethodToProperty)]
        NSValueTransformer ValueTransformer { get; }
    }

    // @interface MPSequenceGenerator : NSObject
    [BaseType(typeof(NSObject))]
    interface MPSequenceGenerator
    {
        // -(int32_t)nextValue;
        [Export("nextValue")]
        [Verify(MethodToProperty)]
        int NextValue { get; }
    }

    // @interface MPSurvey : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MPSurvey
    {
        // @property (readonly, nonatomic) NSUInteger ID;
        [Export("ID")]
        nuint ID { get; }

        // @property (readonly, nonatomic, strong) NSString * name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; }

        // @property (readonly, nonatomic) NSUInteger collectionID;
        [Export("collectionID")]
        nuint CollectionID { get; }

        // @property (readonly, nonatomic, strong) NSArray * questions;
        [Export("questions", ArgumentSemantic.Strong)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Questions { get; }

        // +(MPSurvey *)surveyWithJSONObject:(NSDictionary *)object;
        [Static]
        [Export("surveyWithJSONObject:")]
        MPSurvey SurveyWithJSONObject(NSDictionary @object);
    }

    // @interface MPSurveyNavigationController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface MPSurveyNavigationController
    {
        // @property (nonatomic, strong) MPSurvey * survey;
        [Export("survey", ArgumentSemantic.Strong)]
        MPSurvey Survey { get; set; }

        // @property (nonatomic, strong) UIImage * backgroundImage;
        [Export("backgroundImage", ArgumentSemantic.Strong)]
        UIImage BackgroundImage { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MPSurveyNavigationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MPSurveyNavigationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    // @protocol MPSurveyNavigationControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPSurveyNavigationControllerDelegate
    {
        // @required -(void)surveyController:(MPSurveyNavigationController *)controller wasDismissedWithAnswers:(NSArray *)answers;
        [Abstract]
        [Export("surveyController:wasDismissedWithAnswers:")]
        [Verify(StronglyTypedNSArray)]
        void WasDismissedWithAnswers(MPSurveyNavigationController controller, NSObject[] answers);
    }

    // @interface MPSurveyQuestion : NSObject
    [BaseType(typeof(NSObject))]
    interface MPSurveyQuestion
    {
        // @property (readonly, nonatomic) NSUInteger ID;
        [Export("ID")]
        nuint ID { get; }

        // @property (readonly, nonatomic, strong) NSString * type;
        [Export("type", ArgumentSemantic.Strong)]
        string Type { get; }

        // @property (readonly, nonatomic, strong) NSString * prompt;
        [Export("prompt", ArgumentSemantic.Strong)]
        string Prompt { get; }

        // +(MPSurveyQuestion *)questionWithJSONObject:(NSObject *)object;
        [Static]
        [Export("questionWithJSONObject:")]
        MPSurveyQuestion QuestionWithJSONObject(NSObject @object);
    }

    // @interface MPSurveyMultipleChoiceQuestion : MPSurveyQuestion
    [BaseType(typeof(MPSurveyQuestion))]
    interface MPSurveyMultipleChoiceQuestion
    {
        // @property (readonly, nonatomic, strong) NSArray * choices;
        [Export("choices", ArgumentSemantic.Strong)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Choices { get; }
    }

    // @interface MPSurveyTextQuestion : MPSurveyQuestion
    [BaseType(typeof(MPSurveyQuestion))]
    interface MPSurveyTextQuestion
    {
    }

    // @interface MPSurveyQuestionViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface MPSurveyQuestionViewController
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MPSurveyQuestionViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MPSurveyQuestionViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) MPSurveyQuestion * question;
        [Export("question", ArgumentSemantic.Strong)]
        MPSurveyQuestion Question { get; set; }

        // @property (nonatomic, strong) UIColor * highlightColor;
        [Export("highlightColor", ArgumentSemantic.Strong)]
        UIColor HighlightColor { get; set; }
    }

    // @protocol MPSurveyQuestionViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPSurveyQuestionViewControllerDelegate
    {
        // @required -(void)questionController:(MPSurveyQuestionViewController *)controller didReceiveAnswerProperties:(NSDictionary *)properties;
        [Abstract]
        [Export("questionController:didReceiveAnswerProperties:")]
        void DidReceiveAnswerProperties(MPSurveyQuestionViewController controller, NSDictionary properties);
    }

    // typedef void (^swizzleBlock)();
    delegate void swizzleBlock();

    // @interface MPSwizzler : NSObject
    [BaseType(typeof(NSObject))]
    interface MPSwizzler
    {
        // +(void)swizzleSelector:(SEL)aSelector onClass:(Class)aClass withBlock:(swizzleBlock)block named:(NSString *)aName;
        [Static]
        [Export("swizzleSelector:onClass:withBlock:named:")]
        void SwizzleSelector(Selector aSelector, Class aClass, swizzleBlock block, string aName);

        // +(void)unswizzleSelector:(SEL)aSelector onClass:(Class)aClass named:(NSString *)aName;
        [Static]
        [Export("unswizzleSelector:onClass:named:")]
        void UnswizzleSelector(Selector aSelector, Class aClass, string aName);

        // +(void)printSwizzles;
        [Static]
        [Export("printSwizzles")]
        void PrintSwizzles();
    }

    // @interface MPTweak : NSObject
    [BaseType(typeof(NSObject))]
    interface MPTweak
    {
        // -(instancetype)initWithName:(NSString *)name andEncoding:(NSString *)encoding;
        [Export("initWithName:andEncoding:")]
        IntPtr Constructor(string name, string encoding);

        // @property (readonly, copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * encoding;
        [Export("encoding")]
        string Encoding { get; }

        // @property (readwrite, nonatomic, strong) MPTweakValue defaultValue;
        [Export("defaultValue", ArgumentSemantic.Strong)]
        NSObject DefaultValue { get; set; }

        // @property (readwrite, nonatomic, strong) MPTweakValue currentValue;
        [Export("currentValue", ArgumentSemantic.Strong)]
        NSObject CurrentValue { get; set; }

        // @property (readwrite, nonatomic, strong) MPTweakValue minimumValue;
        [Export("minimumValue", ArgumentSemantic.Strong)]
        NSObject MinimumValue { get; set; }

        // @property (readwrite, nonatomic, strong) MPTweakValue maximumValue;
        [Export("maximumValue", ArgumentSemantic.Strong)]
        NSObject MaximumValue { get; set; }

        // -(void)addObserver:(id<MPTweakObserver>)observer;
        [Export("addObserver:")]
        void AddObserver(MPTweakObserver observer);

        // -(void)removeObserver:(id<MPTweakObserver>)observer;
        [Export("removeObserver:")]
        void RemoveObserver(MPTweakObserver observer);
    }

    // @protocol MPTweakObserver <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPTweakObserver
    {
        // @required -(void)tweakDidChange:(MPTweak *)tweak;
        [Abstract]
        [Export("tweakDidChange:")]
        void TweakDidChange(MPTweak tweak);
    }

    // @interface MPTweakStore : NSObject
    [BaseType(typeof(NSObject))]
    interface MPTweakStore
    {
        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        MPTweakStore SharedInstance();

        // @property (readonly, copy, nonatomic) NSArray * tweaks;
        [Export("tweaks", ArgumentSemantic.Copy)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Tweaks { get; }

        // -(MPTweak *)tweakWithName:(NSString *)name;
        [Export("tweakWithName:")]
        MPTweak TweakWithName(string name);

        // -(void)addTweak:(MPTweak *)tweak;
        [Export("addTweak:")]
        void AddTweak(MPTweak tweak);

        // -(void)removeTweak:(MPTweak *)tweak;
        [Export("removeTweak:")]
        void RemoveTweak(MPTweak tweak);

        // -(void)reset;
        [Export("reset")]
        void Reset();
    }

    // @interface MPUIControlBinding : MPEventBinding
    [BaseType(typeof(MPEventBinding))]
    [DisableDefaultCtor]
    interface MPUIControlBinding
    {
        // @property (readonly, nonatomic) UIControlEvents controlEvent;
        [Export("controlEvent")]
        UIControlEvents ControlEvent { get; }

        // @property (readonly, nonatomic) UIControlEvents verifyEvent;
        [Export("verifyEvent")]
        UIControlEvents VerifyEvent { get; }

        // -(instancetype)initWithEventName:(NSString *)eventName onPath:(NSString *)path withControlEvent:(UIControlEvents)controlEvent andVerifyEvent:(UIControlEvents)verifyEvent;
        [Export("initWithEventName:onPath:withControlEvent:andVerifyEvent:")]
        IntPtr Constructor(string eventName, string path, UIControlEvents controlEvent, UIControlEvents verifyEvent);
    }

    // @interface MPUITableViewBinding : MPEventBinding
    [BaseType(typeof(MPEventBinding))]
    [DisableDefaultCtor]
    interface MPUITableViewBinding
    {
        // -(instancetype)initWithEventName:(NSString *)eventName onPath:(NSString *)path withDelegate:(Class)delegateClass;
        [Export("initWithEventName:onPath:withDelegate:")]
        IntPtr Constructor(string eventName, string path, Class delegateClass);
    }

    // @interface MPPassThroughValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPPassThroughValueTransformer
    {
    }

    // @interface MPBOOLToNSNumberValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPBOOLToNSNumberValueTransformer
    {
    }

    // @interface MPCATransform3DToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPCATransform3DToNSDictionaryValueTransformer
    {
    }

    // @interface MPCGAffineTransformToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPCGAffineTransformToNSDictionaryValueTransformer
    {
    }

    // @interface MPCGColorRefToNSStringValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPCGColorRefToNSStringValueTransformer
    {
    }

    // @interface MPCGPointToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPCGPointToNSDictionaryValueTransformer
    {
    }

    // @interface MPCGRectToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPCGRectToNSDictionaryValueTransformer
    {
    }

    // @interface MPCGSizeToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPCGSizeToNSDictionaryValueTransformer
    {
    }

    // @interface MPNSAttributedStringToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPNSAttributedStringToNSDictionaryValueTransformer
    {
    }

    // @interface MPUIColorToNSStringValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPUIColorToNSStringValueTransformer
    {
    }

    // @interface MPUIEdgeInsetsToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPUIEdgeInsetsToNSDictionaryValueTransformer
    {
    }

    // @interface MPUIFontToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPUIFontToNSDictionaryValueTransformer
    {
    }

    // @interface MPUIImageToNSDictionaryValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPUIImageToNSDictionaryValueTransformer
    {
    }

    // @interface MPNSNumberToCGFloatValueTransformer : NSValueTransformer
    [BaseType(typeof(NSValueTransformer))]
    interface MPNSNumberToCGFloatValueTransformer
    {
    }

    // @interface MPVariant : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface MPVariant : INSCoding
    {
        // @property (nonatomic) NSUInteger ID;
        [Export("ID")]
        nuint ID { get; set; }

        // @property (nonatomic) NSUInteger experimentID;
        [Export("experimentID")]
        nuint ExperimentID { get; set; }

        // @property (readonly, nonatomic) BOOL running;
        [Export("running")]
        bool Running { get; }

        // @property (readonly, nonatomic) BOOL finished;
        [Export("finished")]
        bool Finished { get; }

        // +(MPVariant *)variantWithJSONObject:(NSDictionary *)object;
        [Static]
        [Export("variantWithJSONObject:")]
        MPVariant VariantWithJSONObject(NSDictionary @object);

        // -(void)addActionsFromJSONObject:(NSArray *)actions andExecute:(BOOL)exec;
        [Export("addActionsFromJSONObject:andExecute:")]
        [Verify(StronglyTypedNSArray)]
        void AddActionsFromJSONObject(NSObject[] actions, bool exec);

        // -(void)addActionFromJSONObject:(NSDictionary *)object andExecute:(BOOL)exec;
        [Export("addActionFromJSONObject:andExecute:")]
        void AddActionFromJSONObject(NSDictionary @object, bool exec);

        // -(void)addTweaksFromJSONObject:(NSArray *)tweaks andExecute:(BOOL)exec;
        [Export("addTweaksFromJSONObject:andExecute:")]
        [Verify(StronglyTypedNSArray)]
        void AddTweaksFromJSONObject(NSObject[] tweaks, bool exec);

        // -(void)addTweakFromJSONObject:(NSDictionary *)object andExecute:(BOOL)exec;
        [Export("addTweakFromJSONObject:andExecute:")]
        void AddTweakFromJSONObject(NSDictionary @object, bool exec);

        // -(void)removeActionWithName:(NSString *)name;
        [Export("removeActionWithName:")]
        void RemoveActionWithName(string name);

        // -(void)execute;
        [Export("execute")]
        void Execute();

        // -(void)stop;
        [Export("stop")]
        void Stop();

        // -(void)finish;
        [Export("finish")]
        void Finish();

        // -(void)restart;
        [Export("restart")]
        void Restart();
    }

    // @interface MPVariantAction : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface MPVariantAction : INSCoding
    {
    }

    // @interface MPVariantTweak : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface MPVariantTweak : INSCoding
    {
    }

    // @interface MP_Base64 (NSData)
    [Category]
    [BaseType(typeof(NSData))]
    interface NSData_MP_Base64
    {
        // +(NSData *)mp_dataFromBase64String:(NSString *)aString;
        [Static]
        [Export("mp_dataFromBase64String:")]
        NSData Mp_dataFromBase64String(string aString);

        // -(NSString *)mp_base64EncodedString;
        [Export("mp_base64EncodedString")]
        [Verify(MethodToProperty)]
        string Mp_base64EncodedString { get; }
    }

    // @interface MPHelpers (NSInvocation)
    [Category]
    [BaseType(typeof(NSInvocation))]
    interface NSInvocation_MPHelpers
    {
        // -(void)mp_setArgumentsFromArray:(NSArray *)argumentArray;
        [Export("mp_setArgumentsFromArray:")]
        [Verify(StronglyTypedNSArray)]
        void Mp_setArgumentsFromArray(NSObject[] argumentArray);

        // -(id)mp_returnValue;
        [Export("mp_returnValue")]
        [Verify(MethodToProperty)]
        NSObject Mp_returnValue { get; }
    }

    // @interface MPColor (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_MPColor
    {
        // +(UIColor *)mp_applicationPrimaryColor;
        [Static]
        [Export("mp_applicationPrimaryColor")]
        [Verify(MethodToProperty)]
        UIColor Mp_applicationPrimaryColor { get; }

        // +(UIColor *)mp_lightEffectColor;
        [Static]
        [Export("mp_lightEffectColor")]
        [Verify(MethodToProperty)]
        UIColor Mp_lightEffectColor { get; }

        // +(UIColor *)mp_extraLightEffectColor;
        [Static]
        [Export("mp_extraLightEffectColor")]
        [Verify(MethodToProperty)]
        UIColor Mp_extraLightEffectColor { get; }

        // +(UIColor *)mp_darkEffectColor;
        [Static]
        [Export("mp_darkEffectColor")]
        [Verify(MethodToProperty)]
        UIColor Mp_darkEffectColor { get; }

        // -(UIColor *)colorWithSaturationComponent:(CGFloat)saturation;
        [Export("colorWithSaturationComponent:")]
        UIColor ColorWithSaturationComponent(nfloat saturation);
    }

    // @interface MPAverageColor (UIImage)
    [Category]
    [BaseType(typeof(UIImage))]
    interface UIImage_MPAverageColor
    {
        // -(UIColor *)mp_averageColor;
        [Export("mp_averageColor")]
        [Verify(MethodToProperty)]
        UIColor Mp_averageColor { get; }

        // -(UIColor *)mp_importantColor;
        [Export("mp_importantColor")]
        [Verify(MethodToProperty)]
        UIColor Mp_importantColor { get; }
    }

    // @interface MPImageEffects (UIImage)
    [Category]
    [BaseType(typeof(UIImage))]
    interface UIImage_MPImageEffects
    {
        // -(UIImage *)mp_applyLightEffect;
        [Export("mp_applyLightEffect")]
        [Verify(MethodToProperty)]
        UIImage Mp_applyLightEffect { get; }

        // -(UIImage *)mp_applyExtraLightEffect;
        [Export("mp_applyExtraLightEffect")]
        [Verify(MethodToProperty)]
        UIImage Mp_applyExtraLightEffect { get; }

        // -(UIImage *)mp_applyDarkEffect;
        [Export("mp_applyDarkEffect")]
        [Verify(MethodToProperty)]
        UIImage Mp_applyDarkEffect { get; }

        // -(UIImage *)mp_applyTintEffectWithColor:(UIColor *)tintColor;
        [Export("mp_applyTintEffectWithColor:")]
        UIImage Mp_applyTintEffectWithColor(UIColor tintColor);

        // -(UIImage *)mp_applyBlurWithRadius:(CGFloat)blurRadius tintColor:(UIColor *)tintColor saturationDeltaFactor:(CGFloat)saturationDeltaFactor maskImage:(UIImage *)maskImage;
        [Export("mp_applyBlurWithRadius:tintColor:saturationDeltaFactor:maskImage:")]
        UIImage Mp_applyBlurWithRadius(nfloat blurRadius, UIColor tintColor, nfloat saturationDeltaFactor, UIImage maskImage);
    }

    // @interface MPHelpers (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_MPHelpers
    {
        // -(UIImage *)mp_snapshotImage;
        [Export("mp_snapshotImage")]
        [Verify(MethodToProperty)]
        UIImage Mp_snapshotImage { get; }

        // -(UIImage *)mp_snapshotForBlur;
        [Export("mp_snapshotForBlur")]
        [Verify(MethodToProperty)]
        UIImage Mp_snapshotForBlur { get; }

        // -(int)mp_fingerprintVersion;
        [Export("mp_fingerprintVersion")]
        [Verify(MethodToProperty)]
        int Mp_fingerprintVersion { get; }
    }
*/

}

