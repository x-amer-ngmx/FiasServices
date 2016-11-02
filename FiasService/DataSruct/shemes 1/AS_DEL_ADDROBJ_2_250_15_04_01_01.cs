﻿using System.Xml.Serialization;

[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class DellAddressObjects {
    
    private AddressObjectsObject[] objectField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Object")]
    public AddressObjectsObject[] Object {
        get {
            return this.objectField;
        }
        set {
            this.objectField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class DellAddressObjectsObject {
    
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
    private System.DateTime uPDATEDATEField;
    private string sHORTNAMEField;
    private string aOLEVELField;
    private string pARENTGUIDField;
    private string aOIDField;
    private string pREVIDField;
    private string nEXTIDField;
    private string cODEField;
    private string pLAINCODEField;
    private string aCTSTATUSField;
    private string cENTSTATUSField;
    private string oPERSTATUSField;
    private string cURRSTATUSField;
    private System.DateTime sTARTDATEField;
    private System.DateTime eNDDATEField;
    private string nORMDOCField;
    private sbyte lIVESTATUSField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AOGUID {
        get {
            return this.aOGUIDField;
        }
        set {
            this.aOGUIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FORMALNAME {
        get {
            return this.fORMALNAMEField;
        }
        set {
            this.fORMALNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string REGIONCODE {
        get {
            return this.rEGIONCODEField;
        }
        set {
            this.rEGIONCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AUTOCODE {
        get {
            return this.aUTOCODEField;
        }
        set {
            this.aUTOCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AREACODE {
        get {
            return this.aREACODEField;
        }
        set {
            this.aREACODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CITYCODE {
        get {
            return this.cITYCODEField;
        }
        set {
            this.cITYCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CTARCODE {
        get {
            return this.cTARCODEField;
        }
        set {
            this.cTARCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PLACECODE {
        get {
            return this.pLACECODEField;
        }
        set {
            this.pLACECODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string STREETCODE {
        get {
            return this.sTREETCODEField;
        }
        set {
            this.sTREETCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EXTRCODE {
        get {
            return this.eXTRCODEField;
        }
        set {
            this.eXTRCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SEXTCODE {
        get {
            return this.sEXTCODEField;
        }
        set {
            this.sEXTCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OFFNAME {
        get {
            return this.oFFNAMEField;
        }
        set {
            this.oFFNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string POSTALCODE {
        get {
            return this.pOSTALCODEField;
        }
        set {
            this.pOSTALCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IFNSFL {
        get {
            return this.iFNSFLField;
        }
        set {
            this.iFNSFLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TERRIFNSFL {
        get {
            return this.tERRIFNSFLField;
        }
        set {
            this.tERRIFNSFLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IFNSUL {
        get {
            return this.iFNSULField;
        }
        set {
            this.iFNSULField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TERRIFNSUL {
        get {
            return this.tERRIFNSULField;
        }
        set {
            this.tERRIFNSULField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OKATO {
        get {
            return this.oKATOField;
        }
        set {
            this.oKATOField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OKTMO {
        get {
            return this.oKTMOField;
        }
        set {
            this.oKTMOField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime UPDATEDATE {
        get {
            return this.uPDATEDATEField;
        }
        set {
            this.uPDATEDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SHORTNAME {
        get {
            return this.sHORTNAMEField;
        }
        set {
            this.sHORTNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string AOLEVEL {
        get {
            return this.aOLEVELField;
        }
        set {
            this.aOLEVELField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PARENTGUID {
        get {
            return this.pARENTGUIDField;
        }
        set {
            this.pARENTGUIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AOID {
        get {
            return this.aOIDField;
        }
        set {
            this.aOIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PREVID {
        get {
            return this.pREVIDField;
        }
        set {
            this.pREVIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NEXTID {
        get {
            return this.nEXTIDField;
        }
        set {
            this.nEXTIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CODE {
        get {
            return this.cODEField;
        }
        set {
            this.cODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PLAINCODE {
        get {
            return this.pLAINCODEField;
        }
        set {
            this.pLAINCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string ACTSTATUS {
        get {
            return this.aCTSTATUSField;
        }
        set {
            this.aCTSTATUSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CENTSTATUS {
        get {
            return this.cENTSTATUSField;
        }
        set {
            this.cENTSTATUSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string OPERSTATUS {
        get {
            return this.oPERSTATUSField;
        }
        set {
            this.oPERSTATUSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CURRSTATUS {
        get {
            return this.cURRSTATUSField;
        }
        set {
            this.cURRSTATUSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime STARTDATE {
        get {
            return this.sTARTDATEField;
        }
        set {
            this.sTARTDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime ENDDATE {
        get {
            return this.eNDDATEField;
        }
        set {
            this.eNDDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NORMDOC {
        get {
            return this.nORMDOCField;
        }
        set {
            this.nORMDOCField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public sbyte LIVESTATUS {
        get {
            return this.lIVESTATUSField;
        }
        set {
            this.lIVESTATUSField = value;
        }
    }
}
