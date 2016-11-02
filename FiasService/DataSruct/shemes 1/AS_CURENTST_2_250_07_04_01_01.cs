using System.Xml.Serialization;
#region AS_CURENTST
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class CurrentStatuses {
    
    private CurrentStatusesCurrentStatus[] currentStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CurrentStatus")]
    public CurrentStatusesCurrentStatus[] CurrentStatus {
        get {
            return this.currentStatusField;
        }
        set {
            this.currentStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CurrentStatusesCurrentStatus {
    
    private string cURENTSTIDField;
    
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CURENTSTID {
        get {
            return this.cURENTSTIDField;
        }
        set {
            this.cURENTSTIDField = value;
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