﻿using System.Xml.Serialization;
#region AS_LANDMRK/AS_DLANDMRK
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Landmarks {
    
    private LandmarksLandmark[] landmarkField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Landmark")]
    public LandmarksLandmark[] Landmark {
        get {
            return this.landmarkField;
        }
        set {
            this.landmarkField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class LandmarksLandmark {
    
    private string lOCATIONField;
    private string pOSTALCODEField;
    private string iFNSFLField;
    private string tERRIFNSFLField;
    private string iFNSULField;
    private string tERRIFNSULField;
    private string oKATOField;
    private string oKTMOField;
    private System.DateTime uPDATEDATEField;
    private string lANDIDField;
    private string lANDGUIDField;
    private string aOGUIDField;
    private System.DateTime sTARTDATEField;
    private System.DateTime eNDDATEField;
    private string nORMDOCField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LOCATION {
        get {
            return this.lOCATIONField;
        }
        set {
            this.lOCATIONField = value;
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
    public string LANDID {
        get {
            return this.lANDIDField;
        }
        set {
            this.lANDIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LANDGUID {
        get {
            return this.lANDGUIDField;
        }
        set {
            this.lANDGUIDField = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NORMDOC {
        get {
            return this.nORMDOCField;
        }
        set {
            this.nORMDOCField = value;
        }
    }
}
#endregion