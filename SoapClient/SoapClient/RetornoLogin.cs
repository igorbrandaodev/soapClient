//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 

namespace SoapClient
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public partial class RetornoLogin
    {

        private string erroExecucaoField;

        private string pmLoggedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string erroExecucao
        {
            get
            {
                return this.erroExecucaoField;
            }
            set
            {
                this.erroExecucaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string pmLogged
        {
            get
            {
                return this.pmLoggedField;
            }
            set
            {
                this.pmLoggedField = value;
            }
        }

        public static implicit operator RetornoLogin(string v)
        {
            throw new NotImplementedException();
        }
    }
}
