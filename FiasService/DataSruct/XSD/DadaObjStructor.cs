using System;
using System.Collections.Generic;

namespace FiasService.DadaStructor
{
    #region AS_ACTSTAT

    public partial class ActualStatuses
    {
        private List<ActualStatusesActualStatus> actualStatusField;

        public ActualStatuses()
        {
            this.actualStatusField = new List<ActualStatusesActualStatus>();
        }

        public List<ActualStatusesActualStatus> ActualStatus
        {
            get
            {
                return this.actualStatusField;
            }
            set
            {
                this.actualStatusField = value;
            }
        }
    }

    public partial class ActualStatusesActualStatus
    {
        private int aCTSTATIDField;
        private string nAMEField;

        public int ACTSTATID
        {
            get
            {
                return this.aCTSTATIDField;
            }
            set
            {
                this.aCTSTATIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_ACTSTAT

    #region AS_ADDROBJ/AS_DADDROBJ

    public partial class AddressObjects
    {
        private List<AddressObjectsObject> objectField;

        public AddressObjects()
        {
            this.objectField = new List<AddressObjectsObject>();
        }

        public List<AddressObjectsObject> Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }
    }

    public partial class AddressObjectsObject
    {
        private string aOGUIDField;
        private string fORMALNAMEField;
        private string rEGIONCODEField;
        private string aUTOCODEField;
        private string aREACODEField;
        private string cITYCODEField;
        private string cTARCODEField;
        private string pLACECODEField;
        private string sTREETCODEField;
        private string eXTRCODEField;
        private string sEXTCODEField;
        private string oFFNAMEField;
        private string pOSTALCODEField;
        private string iFNSFLField;
        private string tERRIFNSFLField;
        private string iFNSULField;
        private string tERRIFNSULField;
        private string oKATOField;
        private string oKTMOField;
        private DateTime uPDATEDATEField;
        private string sHORTNAMEField;
        private int aOLEVELField;
        private string pARENTGUIDField;
        private string aOIDField;
        private string pREVIDField;
        private string nEXTIDField;
        private string cODEField;
        private string pLAINCODEField;
        private int aCTSTATUSField;
        private int cENTSTATUSField;
        private int oPERSTATUSField;
        private int cURRSTATUSField;
        private DateTime sTARTDATEField;
        private DateTime eNDDATEField;
        private string nORMDOCField;
        private sbyte lIVESTATUSField;

        public string AOGUID
        {
            get
            {
                return this.aOGUIDField;
            }
            set
            {
                this.aOGUIDField = value;
            }
        }

        public string FORMALNAME
        {
            get
            {
                return this.fORMALNAMEField;
            }
            set
            {
                this.fORMALNAMEField = value;
            }
        }

        public string REGIONCODE
        {
            get
            {
                return this.rEGIONCODEField;
            }
            set
            {
                this.rEGIONCODEField = value;
            }
        }

        public string AUTOCODE
        {
            get
            {
                return this.aUTOCODEField;
            }
            set
            {
                this.aUTOCODEField = value;
            }
        }

        public string AREACODE
        {
            get
            {
                return this.aREACODEField;
            }
            set
            {
                this.aREACODEField = value;
            }
        }

        public string CITYCODE
        {
            get
            {
                return this.cITYCODEField;
            }
            set
            {
                this.cITYCODEField = value;
            }
        }

        public string CTARCODE
        {
            get
            {
                return this.cTARCODEField;
            }
            set
            {
                this.cTARCODEField = value;
            }
        }

        public string PLACECODE
        {
            get
            {
                return this.pLACECODEField;
            }
            set
            {
                this.pLACECODEField = value;
            }
        }

        public string STREETCODE
        {
            get
            {
                return this.sTREETCODEField;
            }
            set
            {
                this.sTREETCODEField = value;
            }
        }

        public string EXTRCODE
        {
            get
            {
                return this.eXTRCODEField;
            }
            set
            {
                this.eXTRCODEField = value;
            }
        }

        public string SEXTCODE
        {
            get
            {
                return this.sEXTCODEField;
            }
            set
            {
                this.sEXTCODEField = value;
            }
        }

        public string OFFNAME
        {
            get
            {
                return this.oFFNAMEField;
            }
            set
            {
                this.oFFNAMEField = value;
            }
        }

        public string POSTALCODE
        {
            get
            {
                return this.pOSTALCODEField;
            }
            set
            {
                this.pOSTALCODEField = value;
            }
        }

        public string IFNSFL
        {
            get
            {
                return this.iFNSFLField;
            }
            set
            {
                this.iFNSFLField = value;
            }
        }

        public string TERRIFNSFL
        {
            get
            {
                return this.tERRIFNSFLField;
            }
            set
            {
                this.tERRIFNSFLField = value;
            }
        }

        public string IFNSUL
        {
            get
            {
                return this.iFNSULField;
            }
            set
            {
                this.iFNSULField = value;
            }
        }

        public string TERRIFNSUL
        {
            get
            {
                return this.tERRIFNSULField;
            }
            set
            {
                this.tERRIFNSULField = value;
            }
        }

        public string OKATO
        {
            get
            {
                return this.oKATOField;
            }
            set
            {
                this.oKATOField = value;
            }
        }

        public string OKTMO
        {
            get
            {
                return this.oKTMOField;
            }
            set
            {
                this.oKTMOField = value;
            }
        }

        public DateTime UPDATEDATE
        {
            get
            {
                return this.uPDATEDATEField;
            }
            set
            {
                this.uPDATEDATEField = value;
            }
        }

        public string SHORTNAME
        {
            get
            {
                return this.sHORTNAMEField;
            }
            set
            {
                this.sHORTNAMEField = value;
            }
        }

        public int AOLEVEL
        {
            get
            {
                return this.aOLEVELField;
            }
            set
            {
                this.aOLEVELField = value;
            }
        }

        public string PARENTGUID
        {
            get
            {
                return this.pARENTGUIDField;
            }
            set
            {
                this.pARENTGUIDField = value;
            }
        }

        public string AOID
        {
            get
            {
                return this.aOIDField;
            }
            set
            {
                this.aOIDField = value;
            }
        }

        public string PREVID
        {
            get
            {
                return this.pREVIDField;
            }
            set
            {
                this.pREVIDField = value;
            }
        }

        public string NEXTID
        {
            get
            {
                return this.nEXTIDField;
            }
            set
            {
                this.nEXTIDField = value;
            }
        }

        public string CODE
        {
            get
            {
                return this.cODEField;
            }
            set
            {
                this.cODEField = value;
            }
        }

        public string PLAINCODE
        {
            get
            {
                return this.pLAINCODEField;
            }
            set
            {
                this.pLAINCODEField = value;
            }
        }

        public int ACTSTATUS
        {
            get
            {
                return this.aCTSTATUSField;
            }
            set
            {
                this.aCTSTATUSField = value;
            }
        }

        public int CENTSTATUS
        {
            get
            {
                return this.cENTSTATUSField;
            }
            set
            {
                this.cENTSTATUSField = value;
            }
        }

        public int OPERSTATUS
        {
            get
            {
                return this.oPERSTATUSField;
            }
            set
            {
                this.oPERSTATUSField = value;
            }
        }

        public int CURRSTATUS
        {
            get
            {
                return this.cURRSTATUSField;
            }
            set
            {
                this.cURRSTATUSField = value;
            }
        }

        public DateTime STARTDATE
        {
            get
            {
                return this.sTARTDATEField;
            }
            set
            {
                this.sTARTDATEField = value;
            }
        }

        public DateTime ENDDATE
        {
            get
            {
                return this.eNDDATEField;
            }
            set
            {
                this.eNDDATEField = value;
            }
        }

        public string NORMDOC
        {
            get
            {
                return this.nORMDOCField;
            }
            set
            {
                this.nORMDOCField = value;
            }
        }

        public sbyte LIVESTATUS
        {
            get
            {
                return this.lIVESTATUSField;
            }
            set
            {
                this.lIVESTATUSField = value;
            }
        }
    }

    #endregion AS_ADDROBJ/AS_DADDROBJ

    #region AS_CENTERS

    public partial class CenterStatuses
    {
        private List<CenterStatusesCenterStatus> centerStatusField;

        public CenterStatuses()
        {
            this.centerStatusField = new List<CenterStatusesCenterStatus>();
        }

        public List<CenterStatusesCenterStatus> CenterStatus
        {
            get
            {
                return this.centerStatusField;
            }
            set
            {
                this.centerStatusField = value;
            }
        }
    }

    public partial class CenterStatusesCenterStatus
    {
        private int cENTERSTIDField;
        private string nAMEField;

        public int CENTERSTID
        {
            get
            {
                return this.cENTERSTIDField;
            }
            set
            {
                this.cENTERSTIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_CENTERS

    #region AS_CURENTST

    public partial class CurrentStatuses
    {
        private List<CurrentStatusesCurrentStatus> currentStatusField;

        public CurrentStatuses()
        {
            this.currentStatusField = new List<CurrentStatusesCurrentStatus>();
        }

        public List<CurrentStatusesCurrentStatus> CurrentStatus
        {
            get
            {
                return this.currentStatusField;
            }
            set
            {
                this.currentStatusField = value;
            }
        }
    }

    public partial class CurrentStatusesCurrentStatus
    {
        private int cURENTSTIDField;
        private string nAMEField;

        public int CURENTSTID
        {
            get
            {
                return this.cURENTSTIDField;
            }
            set
            {
                this.cURENTSTIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_CURENTST

    #region AS_ESTSTAT

    public partial class EstateStatuses
    {
        private List<EstateStatusesEstateStatus> estateStatusField;

        public EstateStatuses()
        {
            this.estateStatusField = new List<EstateStatusesEstateStatus>();
        }

        public List<EstateStatusesEstateStatus> EstateStatus
        {
            get
            {
                return this.estateStatusField;
            }
            set
            {
                this.estateStatusField = value;
            }
        }
    }

    public partial class EstateStatusesEstateStatus
    {
        private int eSTSTATIDField;
        private string nAMEField;
        private string sHORTNAMEField;

        public int ESTSTATID
        {
            get
            {
                return this.eSTSTATIDField;
            }
            set
            {
                this.eSTSTATIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        public string SHORTNAME
        {
            get
            {
                return this.sHORTNAMEField;
            }
            set
            {
                this.sHORTNAMEField = value;
            }
        }
    }

    #endregion AS_ESTSTAT

    #region AS_HOUSE/AS_DHOUSE

    public partial class Houses
    {
        private List<HousesHouse> houseField;

        public Houses()
        {
            this.houseField = new List<HousesHouse>();
        }

        public List<HousesHouse> House
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }
    }

    public partial class HousesHouse
    {
        private string pOSTALCODEField;
        private string iFNSFLField;
        private string tERRIFNSFLField;
        private string iFNSULField;
        private string tERRIFNSULField;
        private string oKATOField;
        private string oKTMOField;
        private DateTime uPDATEDATEField;
        private string hOUSENUMField;
        private int eSTSTATUSField;
        private string bUILDNUMField;
        private string sTRUCNUMField;
        private int sTRSTATUSField;
        private string hOUSEIDField;
        private string hOUSEGUIDField;
        private string aOGUIDField;
        private DateTime sTARTDATEField;
        private DateTime eNDDATEField;
        private int sTATSTATUSField;
        private string nORMDOCField;
        private int cOUNTERField;

        public string POSTALCODE
        {
            get
            {
                return this.pOSTALCODEField;
            }
            set
            {
                this.pOSTALCODEField = value;
            }
        }

        public string IFNSFL
        {
            get
            {
                return this.iFNSFLField;
            }
            set
            {
                this.iFNSFLField = value;
            }
        }

        public string TERRIFNSFL
        {
            get
            {
                return this.tERRIFNSFLField;
            }
            set
            {
                this.tERRIFNSFLField = value;
            }
        }

        public string IFNSUL
        {
            get
            {
                return this.iFNSULField;
            }
            set
            {
                this.iFNSULField = value;
            }
        }

        public string TERRIFNSUL
        {
            get
            {
                return this.tERRIFNSULField;
            }
            set
            {
                this.tERRIFNSULField = value;
            }
        }

        public string OKATO
        {
            get
            {
                return this.oKATOField;
            }
            set
            {
                this.oKATOField = value;
            }
        }

        public string OKTMO
        {
            get
            {
                return this.oKTMOField;
            }
            set
            {
                this.oKTMOField = value;
            }
        }

        public DateTime UPDATEDATE
        {
            get
            {
                return this.uPDATEDATEField;
            }
            set
            {
                this.uPDATEDATEField = value;
            }
        }

        public string HOUSENUM
        {
            get
            {
                return this.hOUSENUMField;
            }
            set
            {
                this.hOUSENUMField = value;
            }
        }

        public int ESTSTATUS
        {
            get
            {
                return this.eSTSTATUSField;
            }
            set
            {
                this.eSTSTATUSField = value;
            }
        }

        public string BUILDNUM
        {
            get
            {
                return this.bUILDNUMField;
            }
            set
            {
                this.bUILDNUMField = value;
            }
        }

        public string STRUCNUM
        {
            get
            {
                return this.sTRUCNUMField;
            }
            set
            {
                this.sTRUCNUMField = value;
            }
        }

        public int STRSTATUS
        {
            get
            {
                return this.sTRSTATUSField;
            }
            set
            {
                this.sTRSTATUSField = value;
            }
        }

        public string HOUSEID
        {
            get
            {
                return this.hOUSEIDField;
            }
            set
            {
                this.hOUSEIDField = value;
            }
        }

        public string HOUSEGUID
        {
            get
            {
                return this.hOUSEGUIDField;
            }
            set
            {
                this.hOUSEGUIDField = value;
            }
        }

        public string AOGUID
        {
            get
            {
                return this.aOGUIDField;
            }
            set
            {
                this.aOGUIDField = value;
            }
        }

        public DateTime STARTDATE
        {
            get
            {
                return this.sTARTDATEField;
            }
            set
            {
                this.sTARTDATEField = value;
            }
        }

        public DateTime ENDDATE
        {
            get
            {
                return this.eNDDATEField;
            }
            set
            {
                this.eNDDATEField = value;
            }
        }

        public int STATSTATUS
        {
            get
            {
                return this.sTATSTATUSField;
            }
            set
            {
                this.sTATSTATUSField = value;
            }
        }

        public string NORMDOC
        {
            get
            {
                return this.nORMDOCField;
            }
            set
            {
                this.nORMDOCField = value;
            }
        }

        public int COUNTER
        {
            get
            {
                return this.cOUNTERField;
            }
            set
            {
                this.cOUNTERField = value;
            }
        }
    }

    #endregion AS_HOUSE/AS_DHOUSE

    #region AS_HOUSINT/AS_DHOUSINT

    public partial class HouseIntervals
    {
        private List<HouseIntervalsHouseInterval> houseIntervalField;

        public HouseIntervals()
        {
            this.houseIntervalField = new List<HouseIntervalsHouseInterval>();
        }

        public List<HouseIntervalsHouseInterval> HouseInterval
        {
            get
            {
                return this.houseIntervalField;
            }
            set
            {
                this.houseIntervalField = value;
            }
        }
    }

    public partial class HouseIntervalsHouseInterval
    {
        private string pOSTALCODEField;
        private string iFNSFLField;
        private string tERRIFNSFLField;
        private string iFNSULField;
        private string tERRIFNSULField;
        private string oKATOField;
        private string oKTMOField;
        private DateTime uPDATEDATEField;
        private int iNTSTARTField;
        private int iNTENDField;
        private string hOUSEINTIDField;
        private string iNTGUIDField;
        private string aOGUIDField;
        private DateTime sTARTDATEField;
        private DateTime eNDDATEField;
        private int iNTSTATUSField;
        private string nORMDOCField;
        private int cOUNTERField;

        public string POSTALCODE
        {
            get
            {
                return this.pOSTALCODEField;
            }
            set
            {
                this.pOSTALCODEField = value;
            }
        }

        public string IFNSFL
        {
            get
            {
                return this.iFNSFLField;
            }
            set
            {
                this.iFNSFLField = value;
            }
        }

        public string TERRIFNSFL
        {
            get
            {
                return this.tERRIFNSFLField;
            }
            set
            {
                this.tERRIFNSFLField = value;
            }
        }

        public string IFNSUL
        {
            get
            {
                return this.iFNSULField;
            }
            set
            {
                this.iFNSULField = value;
            }
        }

        public string TERRIFNSUL
        {
            get
            {
                return this.tERRIFNSULField;
            }
            set
            {
                this.tERRIFNSULField = value;
            }
        }

        public string OKATO
        {
            get
            {
                return this.oKATOField;
            }
            set
            {
                this.oKATOField = value;
            }
        }

        public string OKTMO
        {
            get
            {
                return this.oKTMOField;
            }
            set
            {
                this.oKTMOField = value;
            }
        }

        public DateTime UPDATEDATE
        {
            get
            {
                return this.uPDATEDATEField;
            }
            set
            {
                this.uPDATEDATEField = value;
            }
        }

        public int INTSTART
        {
            get
            {
                return this.iNTSTARTField;
            }
            set
            {
                this.iNTSTARTField = value;
            }
        }

        public int INTEND
        {
            get
            {
                return this.iNTENDField;
            }
            set
            {
                this.iNTENDField = value;
            }
        }

        public string HOUSEINTID
        {
            get
            {
                return this.hOUSEINTIDField;
            }
            set
            {
                this.hOUSEINTIDField = value;
            }
        }

        public string INTGUID
        {
            get
            {
                return this.iNTGUIDField;
            }
            set
            {
                this.iNTGUIDField = value;
            }
        }

        public string AOGUID
        {
            get
            {
                return this.aOGUIDField;
            }
            set
            {
                this.aOGUIDField = value;
            }
        }

        public DateTime STARTDATE
        {
            get
            {
                return this.sTARTDATEField;
            }
            set
            {
                this.sTARTDATEField = value;
            }
        }

        public DateTime ENDDATE
        {
            get
            {
                return this.eNDDATEField;
            }
            set
            {
                this.eNDDATEField = value;
            }
        }

        public int INTSTATUS
        {
            get
            {
                return this.iNTSTATUSField;
            }
            set
            {
                this.iNTSTATUSField = value;
            }
        }

        public string NORMDOC
        {
            get
            {
                return this.nORMDOCField;
            }
            set
            {
                this.nORMDOCField = value;
            }
        }

        public int COUNTER
        {
            get
            {
                return this.cOUNTERField;
            }
            set
            {
                this.cOUNTERField = value;
            }
        }
    }

    #endregion AS_HOUSINT/AS_DHOUSINT

    #region AS_HSTSTAT

    public partial class HouseStateStatusesCollection
    {
        private List<HouseStateStatuses> houseStateStatusField;

        public HouseStateStatusesCollection()
        {
            this.houseStateStatusField = new List<HouseStateStatuses>();
        }

        public List<HouseStateStatuses> HouseStateStatus
        {
            get
            {
                return this.houseStateStatusField;
            }
            set
            {
                this.houseStateStatusField = value;
            }
        }
    }

    public partial class HouseStateStatuses
    {
        private int hOUSESTIDField;
        private string nAMEField;
        internal HouseStateStatuses(int id, string name)
        {
            hOUSESTIDField = id;
            nAMEField = name;
        }

        public int HOUSESTID
        {
            get
            {
                return this.hOUSESTIDField;
            }
            set
            {
                this.hOUSESTIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_HSTSTAT

    #region AS_INTVSTAT

    public partial class IntervalStatuses
    {
        private List<IntervalStatusesIntervalStatus> intervalStatusField;

        public IntervalStatuses()
        {
            this.intervalStatusField = new List<IntervalStatusesIntervalStatus>();
        }

        public List<IntervalStatusesIntervalStatus> IntervalStatus
        {
            get
            {
                return this.intervalStatusField;
            }
            set
            {
                this.intervalStatusField = value;
            }
        }
    }

    public partial class IntervalStatusesIntervalStatus
    {
        private int iNTVSTATIDField;
        private string nAMEField;

        public int INTVSTATID
        {
            get
            {
                return this.iNTVSTATIDField;
            }
            set
            {
                this.iNTVSTATIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_INTVSTAT

    #region AS_LANDMARK/AS_DLANDMRK

    public partial class Landmarks
    {
        private List<LandmarksLandmark> landmarkField;

        public Landmarks()
        {
            this.landmarkField = new List<LandmarksLandmark>();
        }

        public List<LandmarksLandmark> Landmark
        {
            get
            {
                return this.landmarkField;
            }
            set
            {
                this.landmarkField = value;
            }
        }
    }

    public partial class LandmarksLandmark
    {
        private string lOCATIONField;
        private string pOSTALCODEField;
        private string iFNSFLField;
        private string tERRIFNSFLField;
        private string iFNSULField;
        private string tERRIFNSULField;
        private string oKATOField;
        private string oKTMOField;
        private DateTime uPDATEDATEField;
        private string lANDIDField;
        private string lANDGUIDField;
        private string aOGUIDField;
        private DateTime sTARTDATEField;
        private DateTime eNDDATEField;
        private string nORMDOCField;

        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        public string POSTALCODE
        {
            get
            {
                return this.pOSTALCODEField;
            }
            set
            {
                this.pOSTALCODEField = value;
            }
        }

        public string IFNSFL
        {
            get
            {
                return this.iFNSFLField;
            }
            set
            {
                this.iFNSFLField = value;
            }
        }

        public string TERRIFNSFL
        {
            get
            {
                return this.tERRIFNSFLField;
            }
            set
            {
                this.tERRIFNSFLField = value;
            }
        }

        public string IFNSUL
        {
            get
            {
                return this.iFNSULField;
            }
            set
            {
                this.iFNSULField = value;
            }
        }

        public string TERRIFNSUL
        {
            get
            {
                return this.tERRIFNSULField;
            }
            set
            {
                this.tERRIFNSULField = value;
            }
        }

        public string OKATO
        {
            get
            {
                return this.oKATOField;
            }
            set
            {
                this.oKATOField = value;
            }
        }

        public string OKTMO
        {
            get
            {
                return this.oKTMOField;
            }
            set
            {
                this.oKTMOField = value;
            }
        }

        public DateTime UPDATEDATE
        {
            get
            {
                return this.uPDATEDATEField;
            }
            set
            {
                this.uPDATEDATEField = value;
            }
        }

        public string LANDID
        {
            get
            {
                return this.lANDIDField;
            }
            set
            {
                this.lANDIDField = value;
            }
        }

        public string LANDGUID
        {
            get
            {
                return this.lANDGUIDField;
            }
            set
            {
                this.lANDGUIDField = value;
            }
        }

        public string AOGUID
        {
            get
            {
                return this.aOGUIDField;
            }
            set
            {
                this.aOGUIDField = value;
            }
        }

        public DateTime STARTDATE
        {
            get
            {
                return this.sTARTDATEField;
            }
            set
            {
                this.sTARTDATEField = value;
            }
        }

        public DateTime ENDDATE
        {
            get
            {
                return this.eNDDATEField;
            }
            set
            {
                this.eNDDATEField = value;
            }
        }

        public string NORMDOC
        {
            get
            {
                return this.nORMDOCField;
            }
            set
            {
                this.nORMDOCField = value;
            }
        }
    }

    #endregion AS_LANDMARK/AS_DLANDMRK

    #region AS_NDOCTYPE

    public partial class NormativeDocumentTypes
    {
        private List<NormativeDocumentTypesNormativeDocumentType> normativeDocumentTypeField;

        public NormativeDocumentTypes()
        {
            this.normativeDocumentTypeField = new List<NormativeDocumentTypesNormativeDocumentType>();
        }

        public List<NormativeDocumentTypesNormativeDocumentType> NormativeDocumentType
        {
            get
            {
                return this.normativeDocumentTypeField;
            }
            set
            {
                this.normativeDocumentTypeField = value;
            }
        }
    }

    public partial class NormativeDocumentTypesNormativeDocumentType
    {
        private int nDTYPEIDField;
        private string nAMEField;

        public int NDTYPEID
        {
            get
            {
                return this.nDTYPEIDField;
            }
            set
            {
                this.nDTYPEIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_NDOCTYPE

    #region AS_NORMDOC/AS_DNORDOC

    public partial class NormativeDocumentes
    {
        private List<NormativeDocumentesNormativeDocument> normativeDocumentField;

        public NormativeDocumentes()
        {
            this.normativeDocumentField = new List<NormativeDocumentesNormativeDocument>();
        }

        public List<NormativeDocumentesNormativeDocument> NormativeDocument
        {
            get
            {
                return this.normativeDocumentField;
            }
            set
            {
                this.normativeDocumentField = value;
            }
        }
    }

    public partial class NormativeDocumentesNormativeDocument
    {
        private string nORMDOCIDField;
        private string dOCNAMEField;
        private Nullable<DateTime> dOCDATEField;
        private string dOCNUMField;
        private int dOCTYPEField;
        private int dOCIMGIDField;

        public string NORMDOCID
        {
            get
            {
                return this.nORMDOCIDField;
            }
            set
            {
                this.nORMDOCIDField = value;
            }
        }

        public string DOCNAME
        {
            get
            {
                return this.dOCNAMEField;
            }
            set
            {
                this.dOCNAMEField = value;
            }
        }

        public DateTime DOCDATE
        {
            get
            {
                if (this.dOCDATEField.HasValue)
                {
                    return this.dOCDATEField.Value;
                }
                else
                {
                    return default(System.DateTime);
                }
            }
            set
            {
                this.dOCDATEField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DOCDATESpecified
        {
            get
            {
                return this.dOCDATEField.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this.dOCDATEField = null;
                }
            }
        }

        public string DOCNUM
        {
            get
            {
                return this.dOCNUMField;
            }
            set
            {
                this.dOCNUMField = value;
            }
        }

        public int DOCTYPE
        {
            get
            {
                return this.dOCTYPEField;
            }
            set
            {
                this.dOCTYPEField = value;
            }
        }

        public int DOCIMGID
        {
            get
            {
                return this.dOCIMGIDField;
            }
            set
            {
                this.dOCIMGIDField = value;
            }
        }
    }

    #endregion AS_NORMDOC/AS_DNORDOC

    #region AS_OPERSTAT

    public partial class OperationStatuses
    {
        private List<OperationStatusesOperationStatus> operationStatusField;

        public OperationStatuses()
        {
            this.operationStatusField = new List<OperationStatusesOperationStatus>();
        }

        public List<OperationStatusesOperationStatus> OperationStatus
        {
            get
            {
                return this.operationStatusField;
            }
            set
            {
                this.operationStatusField = value;
            }
        }
    }

    public partial class OperationStatusesOperationStatus
    {
        private int oPERSTATIDField;
        private string nAMEField;

        public int OPERSTATID
        {
            get
            {
                return this.oPERSTATIDField;
            }
            set
            {
                this.oPERSTATIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    #endregion AS_OPERSTAT

    #region AS_SOCRBASE

    public partial class AddressObjectTypes
    {
        private List<AddressObjectTypesAddressObjectType> addressObjectTypeField;

        public AddressObjectTypes()
        {
            this.addressObjectTypeField = new List<AddressObjectTypesAddressObjectType>();
        }

        public List<AddressObjectTypesAddressObjectType> AddressObjectType
        {
            get
            {
                return this.addressObjectTypeField;
            }
            set
            {
                this.addressObjectTypeField = value;
            }
        }
    }

    public partial class AddressObjectTypesAddressObjectType
    {
        private int lEVELField;
        private string sCNAMEField;
        private string sOCRNAMEField;
        private string kOD_T_STField;

        public int LEVEL
        {
            get
            {
                return this.lEVELField;
            }
            set
            {
                this.lEVELField = value;
            }
        }

        public string SCNAME
        {
            get
            {
                return this.sCNAMEField;
            }
            set
            {
                this.sCNAMEField = value;
            }
        }

        public string SOCRNAME
        {
            get
            {
                return this.sOCRNAMEField;
            }
            set
            {
                this.sOCRNAMEField = value;
            }
        }

        public string KOD_T_ST
        {
            get
            {
                return this.kOD_T_STField;
            }
            set
            {
                this.kOD_T_STField = value;
            }
        }
    }

    #endregion AS_SOCRBASE

    #region AS_STRSTAT

    public partial class StructureStatuses
    {
        private List<StructureStatusesStructureStatus> structureStatusField;

        public StructureStatuses()
        {
            this.structureStatusField = new List<StructureStatusesStructureStatus>();
        }

        public List<StructureStatusesStructureStatus> StructureStatus
        {
            get
            {
                return this.structureStatusField;
            }
            set
            {
                this.structureStatusField = value;
            }
        }
    }

    public partial class StructureStatusesStructureStatus
    {
        private int sTRSTATIDField;
        private string nAMEField;
        private string sHORTNAMEField;

        public int STRSTATID
        {
            get
            {
                return this.sTRSTATIDField;
            }
            set
            {
                this.sTRSTATIDField = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        public string SHORTNAME
        {
            get
            {
                return this.sHORTNAMEField;
            }
            set
            {
                this.sHORTNAMEField = value;
            }
        }
    }

    #endregion AS_STRSTAT
}