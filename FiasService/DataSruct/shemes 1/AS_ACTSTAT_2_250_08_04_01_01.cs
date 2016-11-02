using System.Xml.Serialization;

#region AS_ACTSTAT
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(IsNullable=false)]
public partial class ActualStatuses {
    
    private ActualStatusesActualStatus[] actualStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActualStatus")]
    public ActualStatusesActualStatus[] ActualStatus {
        get {
            return this.actualStatusField;
        }
        set {
            this.actualStatusField = value;
        }
    }
}


[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class ActualStatusesActualStatus {
    
    private string aCTSTATIDField;
    
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string ACTSTATID {
        get {
            return this.aCTSTATIDField;
        }
        set {
            this.aCTSTATIDField = value;
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
