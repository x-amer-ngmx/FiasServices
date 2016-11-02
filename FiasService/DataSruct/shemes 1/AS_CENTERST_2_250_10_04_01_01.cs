using System.Xml.Serialization;
#region AS_CENTERS
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CenterStatuses {
    
    private CenterStatusesCenterStatus[] centerStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CenterStatus")]
    public CenterStatusesCenterStatus[] CenterStatus {
        get {
            return this.centerStatusField;
        }
        set {
            this.centerStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CenterStatusesCenterStatus {
    
    private string cENTERSTIDField;
    
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CENTERSTID {
        get {
            return this.cENTERSTIDField;
        }
        set {
            this.cENTERSTIDField = value;
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
}
#endregion