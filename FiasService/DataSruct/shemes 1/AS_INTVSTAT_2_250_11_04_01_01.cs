using System.Xml.Serialization;
#region AS_INTVSTAT
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class IntervalStatuses {
    
    private IntervalStatusesIntervalStatus[] intervalStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IntervalStatus")]
    public IntervalStatusesIntervalStatus[] IntervalStatus {
        get {
            return this.intervalStatusField;
        }
        set {
            this.intervalStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class IntervalStatusesIntervalStatus {
    
    private string iNTVSTATIDField;
    
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string INTVSTATID {
        get {
            return this.iNTVSTATIDField;
        }
        set {
            this.iNTVSTATIDField = value;
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