﻿using System.Xml.Serialization;
#region AS_HOUSE/AS_DHOUSE
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Houses {
    
    private HousesHouse[] houseField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("House")]
    public HousesHouse[] House {
        get {
            return this.houseField;
        }
        set {
            this.houseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HousesHouse {
    
    private string pOSTALCODEField;
    private string iFNSFLField;
    private string tERRIFNSFLField;
    private string iFNSULField;
    private string tERRIFNSULField;
    private string oKATOField;
    private string oKTMOField;
    private System.DateTime uPDATEDATEField;
    private string hOUSENUMField;
    private string eSTSTATUSField;
    private string bUILDNUMField;
    private string sTRUCNUMField;
    private string sTRSTATUSField;
    private string hOUSEIDField;
    private string hOUSEGUIDField;
    private string aOGUIDField;
    private System.DateTime sTARTDATEField;
    private System.DateTime eNDDATEField;
    private string sTATSTATUSField;
    private string nORMDOCField;
    private string cOUNTERField;

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
    public string HOUSENUM {
        get {
            return this.hOUSENUMField;
        }
        set {
            this.hOUSENUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string ESTSTATUS {
        get {
            return this.eSTSTATUSField;
        }
        set {
            this.eSTSTATUSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BUILDNUM {
        get {
            return this.bUILDNUMField;
        }
        set {
            this.bUILDNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string STRUCNUM {
        get {
            return this.sTRUCNUMField;
        }
        set {
            this.sTRUCNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string STRSTATUS {
        get {
            return this.sTRSTATUSField;
        }
        set {
            this.sTRSTATUSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string HOUSEID {
        get {
            return this.hOUSEIDField;
        }
        set {
            this.hOUSEIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string HOUSEGUID {
        get {
            return this.hOUSEGUIDField;
        }
        set {
            this.hOUSEGUIDField = value;
        }
    }
    
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
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string STATSTATUS {
        get {
            return this.sTATSTATUSField;
        }
        set {
            this.sTATSTATUSField = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string COUNTER {
        get {
            return this.cOUNTERField;
        }
        set {
            this.cOUNTERField = value;
        }
    }
}
#endregion