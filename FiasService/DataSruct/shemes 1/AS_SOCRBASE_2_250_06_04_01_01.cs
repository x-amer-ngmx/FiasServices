using System.Xml.Serialization;
#region AS_SOCRBASE
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class AddressObjectTypes {
    
    private AddressObjectTypesAddressObjectType[] addressObjectTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AddressObjectType")]
    public AddressObjectTypesAddressObjectType[] AddressObjectType {
        get {
            return this.addressObjectTypeField;
        }
        set {
            this.addressObjectTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class AddressObjectTypesAddressObjectType {
    
    private string lEVELField;
    private string sCNAMEField;
    private string sOCRNAMEField;
    private string kOD_T_STField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string LEVEL {
        get {
            return this.lEVELField;
        }
        set {
            this.lEVELField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SCNAME {
        get {
            return this.sCNAMEField;
        }
        set {
            this.sCNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SOCRNAME {
        get {
            return this.sOCRNAMEField;
        }
        set {
            this.sOCRNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string KOD_T_ST {
        get {
            return this.kOD_T_STField;
        }
        set {
            this.kOD_T_STField = value;
        }
    }
}
#endregion