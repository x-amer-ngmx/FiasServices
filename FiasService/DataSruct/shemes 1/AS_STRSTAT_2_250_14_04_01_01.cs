using System.Xml.Serialization;

#region  AS_STRSTAT
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class StructureStatuses {
    
    private StructureStatusesStructureStatus[] structureStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StructureStatus")]
    public StructureStatusesStructureStatus[] StructureStatus {
        get {
            return this.structureStatusField;
        }
        set {
            this.structureStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class StructureStatusesStructureStatus {
    
    private string sTRSTATIDField;
    private string nAMEField;
    private string sHORTNAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string STRSTATID {
        get {
            return this.sTRSTATIDField;
        }
        set {
            this.sTRSTATIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NAME {
        get {
            return this.nAMEField;
        }
        set {
            this.nAMEField = value;
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
}
#endregion
