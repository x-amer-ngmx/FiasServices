using System.Xml.Serialization;
#region AS_OPERSTAT
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class OperationStatuses {
    
    private OperationStatusesOperationStatus[] operationStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OperationStatus")]
    public OperationStatusesOperationStatus[] OperationStatus {
        get {
            return this.operationStatusField;
        }
        set {
            this.operationStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class OperationStatusesOperationStatus {
    
    private string oPERSTATIDField;
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string OPERSTATID {
        get {
            return this.oPERSTATIDField;
        }
        set {
            this.oPERSTATIDField = value;
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