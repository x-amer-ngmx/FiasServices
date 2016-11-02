using System.Xml.Serialization;
#region AS_NDOCTYPE
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NormativeDocumentTypes {
    
    private NormativeDocumentTypesNormativeDocumentType[] normativeDocumentTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NormativeDocumentType")]
    public NormativeDocumentTypesNormativeDocumentType[] NormativeDocumentType {
        get {
            return this.normativeDocumentTypeField;
        }
        set {
            this.normativeDocumentTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class NormativeDocumentTypesNormativeDocumentType {
    
    private string nDTYPEIDField;
    
    private string nAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string NDTYPEID {
        get {
            return this.nDTYPEIDField;
        }
        set {
            this.nDTYPEIDField = value;
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