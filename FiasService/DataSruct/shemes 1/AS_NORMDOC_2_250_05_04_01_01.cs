using System.Xml.Serialization;
#region AS_NORMDOC/AS_DNORDOC
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NormativeDocumentes {
    
    private NormativeDocumentesNormativeDocument[] normativeDocumentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NormativeDocument")]
    public NormativeDocumentesNormativeDocument[] NormativeDocument {
        get {
            return this.normativeDocumentField;
        }
        set {
            this.normativeDocumentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class NormativeDocumentesNormativeDocument {
    
    private string nORMDOCIDField;
    private string dOCNAMEField;
    private System.DateTime dOCDATEField;
    private bool dOCDATEFieldSpecified;
    private string dOCNUMField;
    private string dOCTYPEField;
    private string dOCIMGIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NORMDOCID {
        get {
            return this.nORMDOCIDField;
        }
        set {
            this.nORMDOCIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DOCNAME {
        get {
            return this.dOCNAMEField;
        }
        set {
            this.dOCNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
    public System.DateTime DOCDATE {
        get {
            return this.dOCDATEField;
        }
        set {
            this.dOCDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DOCDATESpecified {
        get {
            return this.dOCDATEFieldSpecified;
        }
        set {
            this.dOCDATEFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DOCNUM {
        get {
            return this.dOCNUMField;
        }
        set {
            this.dOCNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string DOCTYPE {
        get {
            return this.dOCTYPEField;
        }
        set {
            this.dOCTYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string DOCIMGID {
        get {
            return this.dOCIMGIDField;
        }
        set {
            this.dOCIMGIDField = value;
        }
    }
}
#endregion