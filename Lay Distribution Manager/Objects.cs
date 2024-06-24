using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Runtime.Remoting.Lifetime;

namespace Lay_Distribution_Manager
{
    internal class Objects
    {
        public static JsonSerializerSettings json_settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };
        public static List<Language> languages = new List<Language>();
        public static List<Genre> genres = new List<Genre>();
        public static List<GETCONTRACTSItem> getcontracts = new List<GETCONTRACTSItem>();
        public static HttpRequest requestOBJ = new HttpRequest();

        public static CurrentInspection currentInspection = null;
        public static GetCurrentInspectionData currentInspection_DATA = null;

        #region Get Inspection Response
        public class GetInspectionAdditionalCounters
        {
            public double deliveryerrors { get; set; }
            public double indelivery { get; set; }
            public double takedown { get; set; }
            public double removedfromstore { get; set; }
            public double live { get; set; }
            public double pending { get; set; }
            public double inspectorerrors { get; set; }
            public double toinspect { get; set; }
            public double parked { get; set; }
        }
        public class GetInspectionImage
        {
            public string fileId { get; set; }
            public bool isTemp { get; set; }
            public string filename { get; set; }
            public object externalUrl { get; set; }
            public DateTime lastUpdateDate { get; set; }
        }
        public class GetInspectionItem
        {
            public int releaseId { get; set; }
            public string releaseName { get; set; }
            public object releaseUPC { get; set; }
            public int releaseType { get; set; }
            public string labelName { get; set; }
            public GetInspectionRelease release { get; set; }
            public List<GetInspectionStore> stores { get; set; }
            public int totalQuantity { get; set; }
            public double totalNet { get; set; }
            public DateTime lastAddedDate { get; set; }
            public object lastDeliveryDate { get; set; }
            public object artistName { get; set; }
            public int statusCount { get; set; }
        }
        public class GetInspectionRelease
        {
            public DateTime saleStartDate { get; set; }
            public object upc { get; set; }
            public object isrc { get; set; }
            public object trackISRC { get; set; }
            public int artistId { get; set; }
            public string artistName { get; set; }
            public object artistAppleId { get; set; }
            public object artistSpotifyId { get; set; }
            public object artistExternalIds { get; set; }
            public object catalog { get; set; }
            public object version { get; set; }
            public string artistImageId { get; set; }
            public int labelId { get; set; }
            public string labelName { get; set; }
            public DateTime releaseDate { get; set; }
            public DateTime creationDate { get; set; }
            public int primaryMusicStyleId { get; set; }
            public object secondaryMusicStyleId { get; set; }
            public int warningsCount { get; set; }
            public int notesCount { get; set; }
            public int payeeNotesCount { get; set; }
            public object approvedDate { get; set; }
            public object kountStatusId { get; set; }
            public object kountStatusName { get; set; }
            public bool isFullyLocked { get; set; }
            public int releaseId { get; set; }
            public string name { get; set; }
            public int releaseTypeId { get; set; }
            public bool isLockedForDistribution { get; set; }
            public bool isIngested { get; set; }
            public int enterpriseId { get; set; }
            public GetInspectionImage image { get; set; }
        }
        public class GetInspectionReleaseStatus
        {
            public int status { get; set; }
            public string statusText { get; set; }
            public object errorMessage { get; set; }
            public DateTime addedDate { get; set; }
            public object deliveryDate { get; set; }
            public object firstDeliveryDate { get; set; }
            public object dateLive { get; set; }
            public object urlInStore { get; set; }
            public int summarySection { get; set; }
            public bool isError { get; set; }
        }
        public class GetInspection
        {
            public int totalItemsCount { get; set; }
            public int pageNumber { get; set; }
            public int pageSize { get; set; }
            public List<GetInspectionItem> items { get; set; }
            public GetInspectionAdditionalCounters additionalCounters { get; set; }
        }
        public class GetInspectionStore
        {
            public int releaseId { get; set; }
            public int distributorStoreId { get; set; }
            public int albumsCount { get; set; }
            public int singlesCount { get; set; }
            public int epCount { get; set; }
            public int ringtonesCount { get; set; }
            public int videosCount { get; set; }
            public int totalQuantity { get; set; }
            public double totalNet { get; set; }
            public object releasePriceId { get; set; }
            public object trackPriceId { get; set; }
            public GetInspectionReleaseStatus releaseStatus { get; set; }
            public int inProgressCount { get; set; }
            public int inspectionCount { get; set; }
            public int licensingCount { get; set; }
            public int deliveredCount { get; set; }
            public int mayBeLiveCount { get; set; }
            public int liveCount { get; set; }
            public int errorCount { get; set; }
            public int distributedCount { get; set; }
            public int takenDownCount { get; set; }
            public int inTakeDownCount { get; set; }
            public int allCount { get; set; }
        }
        #endregion

        #region Get Current Inspection Data
        public class GetCurrentInspectionDataAcrCloud
        {
            public DateTime timestampUtc { get; set; }
            public List<GetCurrentInspectionDataScan> scans { get; set; }
        }
        public class GetCurrentInspectionDataArtistExternalId
        {
            public string profileId { get; set; }
            public int distributorStoreId { get; set; }
        }
        public class GetCurrentInspectionDataComposerContentsDTO
        {
            public int contributorId { get; set; }
            public int composerId { get; set; }
            public string composerName { get; set; }
            public object share { get; set; }
            public object publisherId { get; set; }
            public string publisherName { get; set; }
            public object publisherAdminId { get; set; }
            public object publisherAdminName { get; set; }
            public object proId { get; set; }
            public int rightsId { get; set; }
            public object proRegistrationId { get; set; }
            public int roleId { get; set; }
        }
        public class GetCurrentInspectionDataFlac
        {
            public string fileId { get; set; }
            public bool isTemp { get; set; }
            public string filename { get; set; }
            public object externalUrl { get; set; }
            public DateTime lastUpdateDate { get; set; }
        }
        public class GetCurrentInspectionDataImage
        {
            public string fileId { get; set; }
            public bool isTemp { get; set; }
            public object filename { get; set; }
            public object externalUrl { get; set; }
            public DateTime lastUpdateDate { get; set; }
        }
        public class GetCurrentInspectionDataRelease
        {
            public int releaseId { get; set; }
            public string name { get; set; }
            public object version { get; set; }
            public int releaseTypeId { get; set; }
            public double upc { get; set; }
            public bool isLockedForDistribution { get; set; }
            public object isIngested { get; set; }
            public int enterpriseId { get; set; }
            public object image { get; set; }
        }
        public class GetCurrentInspectionData
        {
            public string createdBy { get; set; }
            public string createdByEmail { get; set; }
            public string createdByUserId { get; set; }
            public string enterpriseEmail { get; set; }
            public string enterpriseOwnerId { get; set; }
            public string lastPayeePaymentDate { get; set; }
            public double lastPayeePaymentAmount { get; set; }
            public bool isEnterpriseVip { get; set; }
            public bool isEnterpriseWhiteListed { get; set; }
            public object payeeReferrerName { get; set; }
            public object description { get; set; }
            public object descriptionTitle { get; set; }
            public object tags { get; set; }
            public int languageId { get; set; }
            public string copyrightC { get; set; }
            public string copyrightP { get; set; }
            public object recordingLocation { get; set; }
            public object recordingDate { get; set; }
            public object parentalAdvisory { get; set; }
            public object producedBy { get; set; }
            public object mixedBy { get; set; }
            public object masteredBy { get; set; }
            public object masteredDate { get; set; }
            public object productionCredits { get; set; }
            public double totalSales { get; set; }
            public int enterpriseId { get; set; }
            public int payeeOwner { get; set; }
            public bool hasRecordLabel { get; set; }
            public bool previouslyReleased { get; set; }
            public List<object> releasesLocals { get; set; }
            public List<object> contributors { get; set; }
            public List<object> artistLocals { get; set; }
            public List<GetCurrentInspectionDataTrack> tracks { get; set; }
            public string enterpriseImageId { get; set; }
            public object smartContractRegistrationId { get; set; }
            public object smartContractRegistrationStatus { get; set; }
            public bool smartContractRegistrationIsCollection { get; set; }
            public object smartContractRegistrationAddress { get; set; }
            public object smartContractUrl { get; set; }
            public double upc { get; set; }
            public object isrc { get; set; }
            public object trackISRC { get; set; }
            public int artistId { get; set; }
            public string artistName { get; set; }
            public string artistAppleId { get; set; }
            public string artistSpotifyId { get; set; }
            public List<GetCurrentInspectionDataArtistExternalId> artistExternalIds { get; set; }
            public object catalog { get; set; }
            public object version { get; set; }
            public string artistImageId { get; set; }
            public int labelId { get; set; }
            public string labelName { get; set; }
            public DateTime releaseDate { get; set; }
            public DateTime creationDate { get; set; }
            public int primaryMusicStyleId { get; set; }
            public object secondaryMusicStyleId { get; set; }
            public int warningsCount { get; set; }
            public int notesCount { get; set; }
            public int payeeNotesCount { get; set; }
            public object approvedDate { get; set; }
            public object kountStatusId { get; set; }
            public object kountStatusName { get; set; }
            public bool isFullyLocked { get; set; }
            public int releaseId { get; set; }
            public string name { get; set; }
            public int releaseTypeId { get; set; }
            public bool isLockedForDistribution { get; set; }
            public bool isIngested { get; set; }
            public object image { get; set; }
        }
        public class GetCurrentInspectionDataScan
        {
            public int scanStartTimeSeconds { get; set; }
            public List<GetCurrentInspectionDataMatch> matches { get; set; }
            public string error { get; set; }
        }
        public class GetCurrentInspectionDataTrack
        {
            public int enterpriseId { get; set; }
            public int trackId { get; set; }
            public string name { get; set; }
            public string spotifyId { get; set; }
            public int artistId { get; set; }
            public string artistName { get; set; }
            public string artistAppleId { get; set; }
            public string artistSpotifyId { get; set; }
            public List<GetCurrentInspectionDataArtistExternalId> artistExternalIds { get; set; }
            public int labelId { get; set; }
            public string labelName { get; set; }
            public object discNumber { get; set; }
            public int trackLength { get; set; }
            public int channels { get; set; }
            public int sampleRate { get; set; }
            public int bitDepth { get; set; }
            public int bitrate { get; set; }
            public object trackVendorId { get; set; }
            public string isrc { get; set; }
            public object version { get; set; }
            public object copyrightC { get; set; }
            public string copyrightP { get; set; }
            public object description { get; set; }
            public int languageId { get; set; }
            public bool @explicit { get; set; }
            public object lyrics { get; set; }
            public int playingCount { get; set; }
            public int appleId { get; set; }
            public object priceTierId { get; set; }
            public object rdioId { get; set; }
            public object previewStartSeconds { get; set; }
            public double totalSales { get; set; }
            public object image { get; set; }
            public GetCurrentInspectionDataWav wav { get; set; }
            public GetCurrentInspectionDataFlac flac { get; set; }
            public string fileExtension { get; set; }
            public bool isLockedForDistribution { get; set; }
            public int primaryMusicStyleId { get; set; }
            public object secondaryMusicStyleId { get; set; }
            public bool previouslyReleased { get; set; }
            public int trackType { get; set; }
            public object licenseRequestStatus { get; set; }
            public object isAudioValid { get; set; }
            public List<object> tracksLocals { get; set; }
            public List<object> artistLocals { get; set; }
            public List<object> contributors { get; set; }
            public object catalog { get; set; }
            public List<object> compositions { get; set; }
            public List<int> releaseIds { get; set; }
            public List<GetCurrentInspectionDataRelease> releases { get; set; }
            public List<GetCurrentInspectionDataComposerContentsDTO> composerContentsDTO { get; set; }
            public bool isFullyLocked { get; set; }
            public object copyTrackId { get; set; }
            public bool isIngested { get; set; }
            public object isLicensePaid { get; set; }
            public List<object> monetizations { get; set; }
            public GetCurrentInspectionDataAcrCloud acrCloud { get; set; }
        }
        public class GetCurrentInspectionDataWav
        {
            public string fileId { get; set; }
            public bool isTemp { get; set; }
            public string filename { get; set; }
            public object externalUrl { get; set; }
            public DateTime lastUpdateDate { get; set; }
        }
        public class GetCurrentInspectionDataMatch
        {
            public string sources { get; set; }
            public string title { get; set; }
            public string albumTitle { get; set; }
            public List<string> artists { get; set; }
            public string labelName { get; set; }
            public string upc { get; set; }
            public string iscr { get; set; }
            public DateTime releaseDate { get; set; }
            public int score { get; set; }
            public int beginTimeMs { get; set; }
            public int endTimeMs { get; set; }
            public string acrId { get; set; }
        }
        #endregion

        #region Get Contracts
        public class GETCONTRACTSContractPayee
        {
            public int payeeId { get; set; }
            public string companyName { get; set; }
        }
        public class GETCONTRACTSItem
        {
            public int contractId { get; set; }
            public string name { get; set; }
            public int contractTypeId { get; set; }
            public string payorName { get; set; }
            public int userStatementsCount { get; set; }
            public DateTime expirationDate { get; set; }
            public DateTime creationDate { get; set; }
            public bool isActive { get; set; }
            public List<GETCONTRACTSContractPayee> contractPayees { get; set; }
            public int status { get; set; }
            public int contractLevelId { get; set; }
        }
        public class GETCONTRACTS
        {
            public int totalItemsCount { get; set; }
            public int pageNumber { get; set; }
            public int pageSize { get; set; }
            public List<GETCONTRACTSItem> items { get; set; }
            public object additionalCounters { get; set; }
        }

        #endregion


        //Current Inspection
        public class CurrentInspection
        {
            public string name { get; set; }
            public Panel panel { get; set; }
            public GetInspectionItem item { get; set; }
        }

        //SPOTIFY AUTH
        public class SpotifyAUTH
        {
            public string token { get; set; }
            public Int64 timestamp { get; set; }
        }

        //Language
        public class Language
        {
            public int languageId { get; set; }
            public string name { get; set; }
            public string languageCode { get; set; }
            public bool isValidMetadataLanguage { get; set; }
        }

        //Genre
        public class Genre
        {
            public int musicStyleId { get; set; }
            public string name { get; set; }
            public int? parentId { get; set; }
            public int order { get; set; }
        }

        #region ACR_JSON
        public class ACR_JSONAlbum
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        public class ACR_JSONArtist
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        public class ACR_JSONDeezer
        {
            public List<ACR_JSONArtist> artists { get; set; }
            public ACR_JSONAlbum album { get; set; }
            public ACR_JSONTrack track { get; set; }
        }
        public class ACR_JSON
        {
            public ACR_JSONDeezer deezer { get; set; }
            public ACR_JSONSpotify spotify { get; set; }
            public ACR_JSONYoutube youtube { get; set; }
        }
        public class ACR_JSONSpotify
        {
            public List<ACR_JSONArtist> artists { get; set; }
            public ACR_JSONAlbum album { get; set; }
            public ACR_JSONTrack track { get; set; }
        }
        public class ACR_JSONTrack
        {
            public string name { get; set; }
            public string id { get; set; }
        }
        public class ACR_JSONYoutube
        {
            public string vid { get; set; }
        }
        #endregion


    }
}
