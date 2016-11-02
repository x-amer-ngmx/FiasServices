﻿using System.Xml.Serialization;
#region AS_HOUSINT/AS_DHOUSINT
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class HouseIntervals {
    
    private HouseIntervalsHouseInterval[] houseIntervalField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HouseInterval")]
    public HouseIntervalsHouseInterval[] HouseInterval {
        get {
            return this.houseIntervalField;
        }
        set {
            this.houseIntervalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HouseIntervalsHouseInterval {
    
    private string pOSTALCODEField;
    private string iFNSFLField;
    private string tERRIFNSFLField;
    private string iFNSULField;
    private string tERRIFNSULField;
    private string oKATOField;
    private string oKTMOField;
    private System.DateTime uPDATEDATEField;
    private string iNTSTARTField;
    private string iNTENDField;
    private string hOUSEINTIDField;
    private string iNTGUIDField;
    private string aOGUIDField;
    private System.DateTime sTARTDATEField;
    private System.DateTime eNDDATEField;
    private string iNTSTATUSField;
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
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string INTSTART {
        get {
            return this.iNTSTARTField;
        }
        set {
            this.iNTSTARTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string INTEND {
        get {
            return this.iNTENDField;
        }
        set {
            this.iNTENDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string HOUSEINTID {
        get {
            return this.hOUSEINTIDField;
        }
        set {
            this.hOUSEINTIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string INTGUID {
        get {
            return this.iNTGUIDField;
        }
        set {
            this.iNTGUIDField = value;
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
    public string INTSTATUS {
        get {
            return this.iNTSTATUSField;
        }
        set {
            this.iNTSTATUSField = value;
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