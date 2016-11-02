using System.Xml.Serialization;
#region AS_HSTSTAT
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class HouseStateStatuses {
    
    private HouseStateStatusesHouseStateStatus[] houseStateStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HouseStateStatus")]
    public HouseStateStatusesHouseStateStatus[] HouseStateStatus {
        get {
            return this.houseStateStatusField;
        }
        set {
            this.houseStateStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HouseStateStatusesHouseStateStatus {
    
    private string hOUSESTIDField;
    
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string HOUSESTID {
        get {
            return this.hOUSESTIDField;
        }
        set {
            this.hOUSESTIDField = value;
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