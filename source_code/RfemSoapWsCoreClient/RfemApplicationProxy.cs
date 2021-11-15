//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dlubal.WS.Rfem6.Application
{
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.dlubal.com/rfem.xsd")]
    public enum application_types
    {
        
        /// <remarks/>
        DLUBAL_CENTER,
        
        /// <remarks/>
        REPORT_VIEWER,
        
        /// <remarks/>
        RFEM6,
        
        /// <remarks/>
        RSECTION,
        
        /// <remarks/>
        RSTAB9,
        
        /// <remarks/>
        WEB_SECTIONS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.dlubal.com/rfem.xsd")]
    public partial class application_information : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string nameField;
        
        private application_types typeField;
        
        private string versionField;
        
        private string language_nameField;
        
        private string language_idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public application_types type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string language_name
        {
            get
            {
                return this.language_nameField;
            }
            set
            {
                this.language_nameField = value;
                this.RaisePropertyChanged("language_name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string language_id
        {
            get
            {
                return this.language_idField;
            }
            set
            {
                this.language_idField = value;
                this.RaisePropertyChanged("language_id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="close_application", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class close_applicationRequest
    {
        
        public close_applicationRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="close_applicationResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class close_applicationResponse
    {
        
        public close_applicationResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="close_model", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class close_modelRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int index;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool save_changes;
        
        public close_modelRequest()
        {
        }
        
        public close_modelRequest(int index, bool save_changes)
        {
            this.index = index;
            this.save_changes = save_changes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="close_modelResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class close_modelResponse
    {
        
        public close_modelResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_active_model", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_active_modelRequest
    {
        
        public get_active_modelRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_active_modelResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_active_modelResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value;
        
        public get_active_modelResponse()
        {
        }
        
        public get_active_modelResponse(string value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_information", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_informationRequest
    {
        
        public get_informationRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_informationResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_informationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Dlubal.WS.Rfem6.Application.application_information value;
        
        public get_informationResponse()
        {
        }
        
        public get_informationResponse(Dlubal.WS.Rfem6.Application.application_information value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_model_list", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_model_listRequest
    {
        
        public get_model_listRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_model_listResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_model_listResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] value;
        
        public get_model_listResponse()
        {
        }
        
        public get_model_listResponse(string[] value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_model", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_modelRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int index;
        
        public get_modelRequest()
        {
        }
        
        public get_modelRequest(int index)
        {
            this.index = index;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_modelResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class get_modelResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value;
        
        public get_modelResponse()
        {
        }
        
        public get_modelResponse(string value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="new_model", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class new_modelRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string model_name;
        
        public new_modelRequest()
        {
        }
        
        public new_modelRequest(string model_name)
        {
            this.model_name = model_name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="new_modelResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class new_modelResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value;
        
        public new_modelResponse()
        {
        }
        
        public new_modelResponse(string value)
        {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="open_model", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class open_modelRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string model_path;
        
        public open_modelRequest()
        {
        }
        
        public open_modelRequest(string model_path)
        {
            this.model_path = model_path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="open_modelResponse", WrapperNamespace="http://www.dlubal.com/rfem.xsd", IsWrapped=true)]
    public partial class open_modelResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.dlubal.com/rfem.xsd", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value;
        
        public open_modelResponse()
        {
        }
        
        public open_modelResponse(string value)
        {
            this.value = value;
        }
    }
}
