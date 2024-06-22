using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSub.Model
{

    public class JsonModel
    {
        public Responsecontext responseContext { get; set; }
        public Playabilitystatus playabilityStatus { get; set; }
        public Streamingdata streamingData { get; set; }
        public Playbacktracking playbackTracking { get; set; }
        public Captions captions { get; set; }
        public Videodetails videoDetails { get; set; }
        public Annotation[] annotations { get; set; }
        public Playerconfig playerConfig { get; set; }
        public Storyboards storyboards { get; set; }
        public Microformat microformat { get; set; }
        public Cards cards { get; set; }
        public string trackingParams { get; set; }
        public Attestation attestation { get; set; }
        public Endscreen endscreen { get; set; }
        public Adplacement[] adPlacements { get; set; }
        public string adBreakHeartbeatParams { get; set; }
        public Frameworkupdates frameworkUpdates { get; set; }
    }

    public class Responsecontext
    {
        public Servicetrackingparam[] serviceTrackingParams { get; set; }
        public float maxAgeSeconds { get; set; }
        public Mainappwebresponsecontext mainAppWebResponseContext { get; set; }
        public Webresponsecontextextensiondata webResponseContextExtensionData { get; set; }
    }

    public class Mainappwebresponsecontext
    {
        public bool loggedOut { get; set; }
        public string trackingParam { get; set; }
    }

    public class Webresponsecontextextensiondata
    {
        public bool hasDecorated { get; set; }
    }

    public class Servicetrackingparam
    {
        public string service { get; set; }
        public Param[] _params { get; set; }
    }

    public class Param
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Playabilitystatus
    {
        public string status { get; set; }
        public bool playableInEmbed { get; set; }
        public Miniplayer miniplayer { get; set; }
        public string contextParams { get; set; }
    }

    public class Miniplayer
    {
        public Miniplayerrenderer miniplayerRenderer { get; set; }
    }

    public class Miniplayerrenderer
    {
        public string playbackMode { get; set; }
    }

    public class Streamingdata
    {
        public string expiresInSeconds { get; set; }
        public Format[] formats { get; set; }
        public Adaptiveformat[] adaptiveFormats { get; set; }
        public string serverAbrStreamingUrl { get; set; }
    }

    public class Format
    {
        public float itag { get; set; }
        public string url { get; set; }
        public string mimeType { get; set; }
        public float bitrate { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public string lastModified { get; set; }
        public string contentLength { get; set; }
        public string quality { get; set; }
        public float fps { get; set; }
        public string qualityLabel { get; set; }
        public string projectionType { get; set; }
        public float averageBitrate { get; set; }
        public string audioQuality { get; set; }
        public string approxDurationMs { get; set; }
        public string audioSampleRate { get; set; }
        public float audioChannels { get; set; }
    }

    public class Adaptiveformat
    {
        public float itag { get; set; }
        public string url { get; set; }
        public string mimeType { get; set; }
        public float bitrate { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public Initrange initRange { get; set; }
        public Indexrange indexRange { get; set; }
        public string lastModified { get; set; }
        public string contentLength { get; set; }
        public string quality { get; set; }
        public float fps { get; set; }
        public string qualityLabel { get; set; }
        public string projectionType { get; set; }
        public float averageBitrate { get; set; }
        public string approxDurationMs { get; set; }
        public Colorinfo colorInfo { get; set; }
        public bool highReplication { get; set; }
        public string audioQuality { get; set; }
        public string audioSampleRate { get; set; }
        public float audioChannels { get; set; }
        public float loudnessDb { get; set; }
    }

    public class Initrange
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Indexrange
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Colorinfo
    {
        public string primaries { get; set; }
        public string transferCharacteristics { get; set; }
        public string matrixCoefficients { get; set; }
    }

    public class Playbacktracking
    {
        public Videostatsplaybackurl videostatsPlaybackUrl { get; set; }
        public Videostatsdelayplayurl videostatsDelayplayUrl { get; set; }
        public Videostatswatchtimeurl videostatsWatchtimeUrl { get; set; }
        public Ptrackingurl ptrackingUrl { get; set; }
        public Qoeurl qoeUrl { get; set; }
        public Atrurl atrUrl { get; set; }
        public int[] videostatsScheduledFlushWalltimeSeconds { get; set; }
        public float videostatsDefaultFlushIntervalSeconds { get; set; }
    }

    public class Videostatsplaybackurl
    {
        public string baseUrl { get; set; }
    }

    public class Videostatsdelayplayurl
    {
        public string baseUrl { get; set; }
    }

    public class Videostatswatchtimeurl
    {
        public string baseUrl { get; set; }
    }

    public class Ptrackingurl
    {
        public string baseUrl { get; set; }
    }

    public class Qoeurl
    {
        public string baseUrl { get; set; }
    }

    public class Atrurl
    {
        public string baseUrl { get; set; }
        public float elapsedMediaTimeSeconds { get; set; }
    }

    public class Captions
    {
        public Playercaptionstracklistrenderer playerCaptionsTracklistRenderer { get; set; }
    }

    public class Playercaptionstracklistrenderer
    {
        public Captiontrack[] captionTracks { get; set; }
        public Audiotrack[] audioTracks { get; set; }
        public Translationlanguage[] translationLanguages { get; set; }
        public float defaultAudioTrackIndex { get; set; }
    }

    public class Captiontrack
    {
        public string baseUrl { get; set; }
        public Name name { get; set; }
        public string vssId { get; set; }
        public string languageCode { get; set; }
        public string kind { get; set; }
        public bool isTranslatable { get; set; }
        public string trackName { get; set; }
    }

    public class Name
    {
        public string simpleText { get; set; }
    }

    public class Audiotrack
    {
        public int[] captionTrackIndices { get; set; }
    }

    public class Translationlanguage
    {
        public string languageCode { get; set; }
        public Languagename languageName { get; set; }
    }

    public class Languagename
    {
        public string simpleText { get; set; }
    }

    public class Videodetails
    {
        public string videoId { get; set; }
        public string title { get; set; }
        public string lengthSeconds { get; set; }
        public string[] keywords { get; set; }
        public string channelId { get; set; }
        public bool isOwnerViewing { get; set; }
        public string shortDescription { get; set; }
        public bool isCrawlable { get; set; }
        public Thumbnail thumbnail { get; set; }
        public bool allowRatings { get; set; }
        public string viewCount { get; set; }
        public string author { get; set; }
        public bool isPrivate { get; set; }
        public bool isUnpluggedCorpus { get; set; }
        public bool isLiveContent { get; set; }
    }

    public class Thumbnail
    {
        public Thumbnail1[] thumbnails { get; set; }
    }

    public class Thumbnail1
    {
        public string url { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Playerconfig
    {
        public Audioconfig audioConfig { get; set; }
        public Streamselectionconfig streamSelectionConfig { get; set; }
        public Mediacommonconfig mediaCommonConfig { get; set; }
        public Webplayerconfig webPlayerConfig { get; set; }
    }

    public class Audioconfig
    {
        public float loudnessDb { get; set; }
        public float perceptualLoudnessDb { get; set; }
        public bool enablePerFormatLoudness { get; set; }
    }

    public class Streamselectionconfig
    {
        public string maxBitrate { get; set; }
    }

    public class Mediacommonconfig
    {
        public Dynamicreadaheadconfig dynamicReadaheadConfig { get; set; }
        public Mediaustreamerrequestconfig mediaUstreamerRequestConfig { get; set; }
        public bool useServerDrivenAbr { get; set; }
        public Serverplaybackstartconfig serverPlaybackStartConfig { get; set; }
    }

    public class Dynamicreadaheadconfig
    {
        public float maxReadAheadMediaTimeMs { get; set; }
        public float minReadAheadMediaTimeMs { get; set; }
        public float readAheadGrowthRateMs { get; set; }
    }

    public class Mediaustreamerrequestconfig
    {
        public string videoPlaybackUstreamerConfig { get; set; }
    }

    public class Serverplaybackstartconfig
    {
        public bool enable { get; set; }
        public Playbackstartpolicy playbackStartPolicy { get; set; }
    }

    public class Playbackstartpolicy
    {
        public Startminreadaheadpolicy[] startMinReadaheadPolicy { get; set; }
    }

    public class Startminreadaheadpolicy
    {
        public float minReadaheadMs { get; set; }
    }

    public class Webplayerconfig
    {
        public bool useCobaltTvosDash { get; set; }
        public Webplayeractionsporting webPlayerActionsPorting { get; set; }
    }

    public class Webplayeractionsporting
    {
        public Getsharepanelcommand getSharePanelCommand { get; set; }
        public Subscribecommand subscribeCommand { get; set; }
        public Unsubscribecommand unsubscribeCommand { get; set; }
        public Addtowatchlatercommand addToWatchLaterCommand { get; set; }
        public Removefromwatchlatercommand removeFromWatchLaterCommand { get; set; }
    }

    public class Getsharepanelcommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata commandMetadata { get; set; }
        public Webplayershareentityserviceendpoint webPlayerShareEntityServiceEndpoint { get; set; }
    }

    public class Commandmetadata
    {
        public Webcommandmetadata webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Webplayershareentityserviceendpoint
    {
        public string serializedShareEntity { get; set; }
    }

    public class Subscribecommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata1 commandMetadata { get; set; }
        public Subscribeendpoint subscribeEndpoint { get; set; }
    }

    public class Commandmetadata1
    {
        public Webcommandmetadata1 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata1
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Subscribeendpoint
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Unsubscribecommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata2 commandMetadata { get; set; }
        public Unsubscribeendpoint unsubscribeEndpoint { get; set; }
    }

    public class Commandmetadata2
    {
        public Webcommandmetadata2 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata2
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Unsubscribeendpoint
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Addtowatchlatercommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata3 commandMetadata { get; set; }
        public Playlisteditendpoint playlistEditEndpoint { get; set; }
    }

    public class Commandmetadata3
    {
        public Webcommandmetadata3 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata3
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Playlisteditendpoint
    {
        public string playlistId { get; set; }
        public Action[] actions { get; set; }
    }

    public class Action
    {
        public string addedVideoId { get; set; }
        public string action { get; set; }
    }

    public class Removefromwatchlatercommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata4 commandMetadata { get; set; }
        public Playlisteditendpoint1 playlistEditEndpoint { get; set; }
    }

    public class Commandmetadata4
    {
        public Webcommandmetadata4 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata4
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Playlisteditendpoint1
    {
        public string playlistId { get; set; }
        public Action1[] actions { get; set; }
    }

    public class Action1
    {
        public string action { get; set; }
        public string removedVideoId { get; set; }
    }

    public class Storyboards
    {
        public Playerstoryboardspecrenderer playerStoryboardSpecRenderer { get; set; }
    }

    public class Playerstoryboardspecrenderer
    {
        public string spec { get; set; }
        public float recommendedLevel { get; set; }
        public float highResolutionRecommendedLevel { get; set; }
    }

    public class Microformat
    {
        public Playermicroformatrenderer playerMicroformatRenderer { get; set; }
    }

    public class Playermicroformatrenderer
    {
        public Thumbnail2 thumbnail { get; set; }
        public Embed embed { get; set; }
        public Title title { get; set; }
        public Description description { get; set; }
        public string lengthSeconds { get; set; }
        public string ownerProfileUrl { get; set; }
        public string externalChannelId { get; set; }
        public bool isFamilySafe { get; set; }
        public string[] availableCountries { get; set; }
        public bool isUnlisted { get; set; }
        public bool hasYpcMetadata { get; set; }
        public string viewCount { get; set; }
        public string category { get; set; }
        public DateTime publishDate { get; set; }
        public string ownerChannelName { get; set; }
        public DateTime uploadDate { get; set; }
        public bool isShortsEligible { get; set; }
    }

    public class Thumbnail2
    {
        public Thumbnail3[] thumbnails { get; set; }
    }

    public class Thumbnail3
    {
        public string url { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Embed
    {
        public string iframeUrl { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Title
    {
        public string simpleText { get; set; }
    }

    public class Description
    {
        public string simpleText { get; set; }
    }

    public class Cards
    {
        public Cardcollectionrenderer cardCollectionRenderer { get; set; }
    }

    public class Cardcollectionrenderer
    {
        public Card[] cards { get; set; }
        public Headertext headerText { get; set; }
        public Icon icon { get; set; }
        public Closebutton closeButton { get; set; }
        public string trackingParams { get; set; }
        public bool allowTeaserDismiss { get; set; }
        public bool logIconVisibilityUpdates { get; set; }
    }

    public class Headertext
    {
        public string simpleText { get; set; }
    }

    public class Icon
    {
        public Infocardiconrenderer infoCardIconRenderer { get; set; }
    }

    public class Infocardiconrenderer
    {
        public string trackingParams { get; set; }
    }

    public class Closebutton
    {
        public Infocardiconrenderer1 infoCardIconRenderer { get; set; }
    }

    public class Infocardiconrenderer1
    {
        public string trackingParams { get; set; }
    }

    public class Card
    {
        public Cardrenderer cardRenderer { get; set; }
    }

    public class Cardrenderer
    {
        public Teaser teaser { get; set; }
        public Cuerange[] cueRanges { get; set; }
        public string trackingParams { get; set; }
    }

    public class Teaser
    {
        public Simplecardteaserrenderer simpleCardTeaserRenderer { get; set; }
    }

    public class Simplecardteaserrenderer
    {
        public Message message { get; set; }
        public string trackingParams { get; set; }
        public bool prominent { get; set; }
        public bool logVisibilityUpdates { get; set; }
        public Ontapcommand onTapCommand { get; set; }
    }

    public class Message
    {
        public string simpleText { get; set; }
    }

    public class Ontapcommand
    {
        public string clickTrackingParams { get; set; }
        public Changeengagementpanelvisibilityaction changeEngagementPanelVisibilityAction { get; set; }
    }

    public class Changeengagementpanelvisibilityaction
    {
        public string targetId { get; set; }
        public string visibility { get; set; }
    }

    public class Cuerange
    {
        public string startCardActiveMs { get; set; }
        public string endCardActiveMs { get; set; }
        public string teaserDurationMs { get; set; }
        public string iconAfterTeaserMs { get; set; }
    }

    public class Attestation
    {
        public Playerattestationrenderer playerAttestationRenderer { get; set; }
    }

    public class Playerattestationrenderer
    {
        public string challenge { get; set; }
        public Botguarddata botguardData { get; set; }
    }

    public class Botguarddata
    {
        public string program { get; set; }
        public Interpretersafeurl interpreterSafeUrl { get; set; }
        public float serverEnvironment { get; set; }
    }

    public class Interpretersafeurl
    {
        public string privateDoNotAccessOrElseTrustedResourceUrlWrappedValue { get; set; }
    }

    public class Endscreen
    {
        public Endscreenrenderer endscreenRenderer { get; set; }
    }

    public class Endscreenrenderer
    {
        public Element[] elements { get; set; }
        public string startMs { get; set; }
        public string trackingParams { get; set; }
    }

    public class Element
    {
        public Endscreenelementrenderer endscreenElementRenderer { get; set; }
    }

    public class Endscreenelementrenderer
    {
        public string style { get; set; }
        public Image image { get; set; }
        public Icon1 icon { get; set; }
        public float left { get; set; }
        public float width { get; set; }
        public float top { get; set; }
        public float aspectRatio { get; set; }
        public string startMs { get; set; }
        public string endMs { get; set; }
        public Title1 title { get; set; }
        public Metadata metadata { get; set; }
        public Calltoaction callToAction { get; set; }
        public Dismiss dismiss { get; set; }
        public Endpoint endpoint { get; set; }
        public Hovercardbutton hovercardButton { get; set; }
        public string trackingParams { get; set; }
        public bool isSubscribe { get; set; }
        public string id { get; set; }
    }

    public class Image
    {
        public Thumbnail4[] thumbnails { get; set; }
    }

    public class Thumbnail4
    {
        public string url { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Icon1
    {
        public Thumbnail5[] thumbnails { get; set; }
    }

    public class Thumbnail5
    {
        public string url { get; set; }
    }

    public class Title1
    {
        public Accessibility accessibility { get; set; }
        public string simpleText { get; set; }
    }

    public class Accessibility
    {
        public Accessibilitydata accessibilityData { get; set; }
    }

    public class Accessibilitydata
    {
        public string label { get; set; }
    }

    public class Metadata
    {
        public string simpleText { get; set; }
    }

    public class Calltoaction
    {
        public string simpleText { get; set; }
    }

    public class Dismiss
    {
        public string simpleText { get; set; }
    }

    public class Endpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata5 commandMetadata { get; set; }
        public Browseendpoint browseEndpoint { get; set; }
    }

    public class Commandmetadata5
    {
        public Webcommandmetadata5 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata5
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public float rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint
    {
        public string browseId { get; set; }
    }

    public class Hovercardbutton
    {
        public Subscribebuttonrenderer subscribeButtonRenderer { get; set; }
    }

    public class Subscribebuttonrenderer
    {
        public Buttontext buttonText { get; set; }
        public bool subscribed { get; set; }
        public bool enabled { get; set; }
        public string type { get; set; }
        public string channelId { get; set; }
        public bool showPreferences { get; set; }
        public Subscribedbuttontext subscribedButtonText { get; set; }
        public Unsubscribedbuttontext unsubscribedButtonText { get; set; }
        public string trackingParams { get; set; }
        public Unsubscribebuttontext unsubscribeButtonText { get; set; }
        public Serviceendpoint[] serviceEndpoints { get; set; }
        public Subscribeaccessibility subscribeAccessibility { get; set; }
        public Unsubscribeaccessibility unsubscribeAccessibility { get; set; }
        public Signinendpoint signInEndpoint { get; set; }
    }

    public class Buttontext
    {
        public Run[] runs { get; set; }
    }

    public class Run
    {
        public string text { get; set; }
    }

    public class Subscribedbuttontext
    {
        public Run1[] runs { get; set; }
    }

    public class Run1
    {
        public string text { get; set; }
    }

    public class Unsubscribedbuttontext
    {
        public Run2[] runs { get; set; }
    }

    public class Run2
    {
        public string text { get; set; }
    }

    public class Unsubscribebuttontext
    {
        public Run3[] runs { get; set; }
    }

    public class Run3
    {
        public string text { get; set; }
    }

    public class Subscribeaccessibility
    {
        public Accessibilitydata1 accessibilityData { get; set; }
    }

    public class Accessibilitydata1
    {
        public string label { get; set; }
    }

    public class Unsubscribeaccessibility
    {
        public Accessibilitydata2 accessibilityData { get; set; }
    }

    public class Accessibilitydata2
    {
        public string label { get; set; }
    }

    public class Signinendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata6 commandMetadata { get; set; }
    }

    public class Commandmetadata6
    {
        public Webcommandmetadata6 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata6
    {
        public string url { get; set; }
    }

    public class Serviceendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata7 commandMetadata { get; set; }
        public Subscribeendpoint1 subscribeEndpoint { get; set; }
        public Signalserviceendpoint signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata7
    {
        public Webcommandmetadata7 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata7
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Subscribeendpoint1
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Signalserviceendpoint
    {
        public string signal { get; set; }
        public Action2[] actions { get; set; }
    }

    public class Action2
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction openPopupAction { get; set; }
    }

    public class Openpopupaction
    {
        public Popup popup { get; set; }
        public string popupType { get; set; }
    }

    public class Popup
    {
        public Confirmdialogrenderer confirmDialogRenderer { get; set; }
    }

    public class Confirmdialogrenderer
    {
        public string trackingParams { get; set; }
        public Dialogmessage[] dialogMessages { get; set; }
        public Confirmbutton confirmButton { get; set; }
        public Cancelbutton cancelButton { get; set; }
        public bool primaryIsCancel { get; set; }
    }

    public class Confirmbutton
    {
        public Buttonrenderer buttonRenderer { get; set; }
    }

    public class Buttonrenderer
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text text { get; set; }
        public Serviceendpoint1 serviceEndpoint { get; set; }
        public Accessibility1 accessibility { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text
    {
        public Run4[] runs { get; set; }
    }

    public class Run4
    {
        public string text { get; set; }
    }

    public class Serviceendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata8 commandMetadata { get; set; }
        public Unsubscribeendpoint1 unsubscribeEndpoint { get; set; }
    }

    public class Commandmetadata8
    {
        public Webcommandmetadata8 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata8
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Unsubscribeendpoint1
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Accessibility1
    {
        public string label { get; set; }
    }

    public class Cancelbutton
    {
        public Buttonrenderer1 buttonRenderer { get; set; }
    }

    public class Buttonrenderer1
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text1 text { get; set; }
        public Accessibility2 accessibility { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text1
    {
        public Run5[] runs { get; set; }
    }

    public class Run5
    {
        public string text { get; set; }
    }

    public class Accessibility2
    {
        public string label { get; set; }
    }

    public class Dialogmessage
    {
        public Run6[] runs { get; set; }
    }

    public class Run6
    {
        public string text { get; set; }
    }

    public class Frameworkupdates
    {
        public Entitybatchupdate entityBatchUpdate { get; set; }
    }

    public class Entitybatchupdate
    {
        public Mutation[] mutations { get; set; }
        public Timestamp timestamp { get; set; }
    }

    public class Timestamp
    {
        public string seconds { get; set; }
        public float nanos { get; set; }
    }

    public class Mutation
    {
        public string entityKey { get; set; }
        public string type { get; set; }
        public Payload payload { get; set; }
    }

    public class Payload
    {
        public Offlineabilityentity offlineabilityEntity { get; set; }
    }

    public class Offlineabilityentity
    {
        public string key { get; set; }
        public string addToOfflineButtonState { get; set; }
    }

    public class Annotation
    {
        public Playerannotationsexpandedrenderer playerAnnotationsExpandedRenderer { get; set; }
    }

    public class Playerannotationsexpandedrenderer
    {
        public Featuredchannel featuredChannel { get; set; }
        public bool allowSwipeDismiss { get; set; }
        public string annotationId { get; set; }
    }

    public class Featuredchannel
    {
        public string startTimeMs { get; set; }
        public string endTimeMs { get; set; }
        public Watermark watermark { get; set; }
        public string trackingParams { get; set; }
        public Navigationendpoint navigationEndpoint { get; set; }
        public string channelName { get; set; }
        public Subscribebutton subscribeButton { get; set; }
    }

    public class Watermark
    {
        public Thumbnail6[] thumbnails { get; set; }
    }

    public class Thumbnail6
    {
        public string url { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }

    public class Navigationendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata9 commandMetadata { get; set; }
        public Browseendpoint1 browseEndpoint { get; set; }
    }

    public class Commandmetadata9
    {
        public Webcommandmetadata9 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata9
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public float rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint1
    {
        public string browseId { get; set; }
    }

    public class Subscribebutton
    {
        public Subscribebuttonrenderer1 subscribeButtonRenderer { get; set; }
    }

    public class Subscribebuttonrenderer1
    {
        public Buttontext1 buttonText { get; set; }
        public bool subscribed { get; set; }
        public bool enabled { get; set; }
        public string type { get; set; }
        public string channelId { get; set; }
        public bool showPreferences { get; set; }
        public Subscribedbuttontext1 subscribedButtonText { get; set; }
        public Unsubscribedbuttontext1 unsubscribedButtonText { get; set; }
        public string trackingParams { get; set; }
        public Unsubscribebuttontext1 unsubscribeButtonText { get; set; }
        public Serviceendpoint2[] serviceEndpoints { get; set; }
        public Subscribeaccessibility1 subscribeAccessibility { get; set; }
        public Unsubscribeaccessibility1 unsubscribeAccessibility { get; set; }
        public Signinendpoint1 signInEndpoint { get; set; }
    }

    public class Buttontext1
    {
        public Run7[] runs { get; set; }
    }

    public class Run7
    {
        public string text { get; set; }
    }

    public class Subscribedbuttontext1
    {
        public Run8[] runs { get; set; }
    }

    public class Run8
    {
        public string text { get; set; }
    }

    public class Unsubscribedbuttontext1
    {
        public Run9[] runs { get; set; }
    }

    public class Run9
    {
        public string text { get; set; }
    }

    public class Unsubscribebuttontext1
    {
        public Run10[] runs { get; set; }
    }

    public class Run10
    {
        public string text { get; set; }
    }

    public class Subscribeaccessibility1
    {
        public Accessibilitydata3 accessibilityData { get; set; }
    }

    public class Accessibilitydata3
    {
        public string label { get; set; }
    }

    public class Unsubscribeaccessibility1
    {
        public Accessibilitydata4 accessibilityData { get; set; }
    }

    public class Accessibilitydata4
    {
        public string label { get; set; }
    }

    public class Signinendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata10 commandMetadata { get; set; }
    }

    public class Commandmetadata10
    {
        public Webcommandmetadata10 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata10
    {
        public string url { get; set; }
    }

    public class Serviceendpoint2
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata11 commandMetadata { get; set; }
        public Subscribeendpoint2 subscribeEndpoint { get; set; }
        public Signalserviceendpoint1 signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata11
    {
        public Webcommandmetadata11 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata11
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Subscribeendpoint2
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Signalserviceendpoint1
    {
        public string signal { get; set; }
        public Action3[] actions { get; set; }
    }

    public class Action3
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction1 openPopupAction { get; set; }
    }

    public class Openpopupaction1
    {
        public Popup1 popup { get; set; }
        public string popupType { get; set; }
    }

    public class Popup1
    {
        public Confirmdialogrenderer1 confirmDialogRenderer { get; set; }
    }

    public class Confirmdialogrenderer1
    {
        public string trackingParams { get; set; }
        public Dialogmessage1[] dialogMessages { get; set; }
        public Confirmbutton1 confirmButton { get; set; }
        public Cancelbutton1 cancelButton { get; set; }
        public bool primaryIsCancel { get; set; }
    }

    public class Confirmbutton1
    {
        public Buttonrenderer2 buttonRenderer { get; set; }
    }

    public class Buttonrenderer2
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text2 text { get; set; }
        public Serviceendpoint3 serviceEndpoint { get; set; }
        public Accessibility3 accessibility { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text2
    {
        public Run11[] runs { get; set; }
    }

    public class Run11
    {
        public string text { get; set; }
    }

    public class Serviceendpoint3
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata12 commandMetadata { get; set; }
        public Unsubscribeendpoint2 unsubscribeEndpoint { get; set; }
    }

    public class Commandmetadata12
    {
        public Webcommandmetadata12 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata12
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Unsubscribeendpoint2
    {
        public string[] channelIds { get; set; }
        public string _params { get; set; }
    }

    public class Accessibility3
    {
        public string label { get; set; }
    }

    public class Cancelbutton1
    {
        public Buttonrenderer3 buttonRenderer { get; set; }
    }

    public class Buttonrenderer3
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text3 text { get; set; }
        public Accessibility4 accessibility { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text3
    {
        public Run12[] runs { get; set; }
    }

    public class Run12
    {
        public string text { get; set; }
    }

    public class Accessibility4
    {
        public string label { get; set; }
    }

    public class Dialogmessage1
    {
        public Run13[] runs { get; set; }
    }

    public class Run13
    {
        public string text { get; set; }
    }

    public class Adplacement
    {
        public Adplacementrenderer adPlacementRenderer { get; set; }
    }

    public class Adplacementrenderer
    {
        public Config config { get; set; }
        public Renderer renderer { get; set; }
        public Adslotloggingdata adSlotLoggingData { get; set; }
    }

    public class Config
    {
        public Adplacementconfig adPlacementConfig { get; set; }
    }

    public class Adplacementconfig
    {
        public string kind { get; set; }
        public Adtimeoffset adTimeOffset { get; set; }
        public bool hideCueRangeMarker { get; set; }
    }

    public class Adtimeoffset
    {
        public string offsetStartMilliseconds { get; set; }
        public string offsetEndMilliseconds { get; set; }
    }

    public class Renderer
    {
        public Clientforecastingadrenderer clientForecastingAdRenderer { get; set; }
    }

    public class Clientforecastingadrenderer
    {
        public bool hack { get; set; }
    }

    public class Adslotloggingdata
    {
        public string serializedSlotAdServingDataEntry { get; set; }
    }

}
