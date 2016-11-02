﻿using System.Xml.Serialization;
#region AS_ESTSTAT
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class EstateStatuses {
    
    private EstateStatusesEstateStatus[] estateStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EstateStatus")]
    public EstateStatusesEstateStatus[] EstateStatus {
        get {
            return this.estateStatusField;
        }
        set {
            this.estateStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class EstateStatusesEstateStatus {
    
    private string eSTSTATIDField;
    private string nAMEField;
    private string sHORTNAMEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string ESTSTATID {
        get {
            return this.eSTSTATIDField;
        }
        set {
            this.eSTSTATIDField = value;
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