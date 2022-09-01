using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace Sanmark.ERP.WinUI.Core.Grid
{
    public class FormatRulesStore : IXtraSerializable
    {
        GridFormatRuleCollection formatRules;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(true),
         XtraSerializableProperty(XtraSerializationVisibility.Collection, true, false, true, 1000, XtraSerializationFlags.DefaultValue)]
        public virtual GridFormatRuleCollection FormatRules
        {
            get { return formatRules; }
            set { formatRules = value; }
        }

        public void Save(string xmlFile)
        {
            SaveCore(new XmlXtraSerializer(), xmlFile);
        }
        public void Restore(string xmlFile)
        {
            RestoreCore(new XmlXtraSerializer(), xmlFile);
        }
        void SaveCore(XtraSerializer serializer, object path)
        {
            Stream stream = path as Stream;
            if (stream != null)
                serializer.SerializeObject(this, stream, GetType().Name);
            else
                serializer.SerializeObject(this, path.ToString(), GetType().Name);
        }
        void RestoreCore(XtraSerializer serializer, object path)
        {
            Stream stream = path as Stream;
            if (stream != null)
                serializer.DeserializeObject(this, stream, GetType().Name);
            else
                serializer.DeserializeObject(this, path.ToString(), GetType().Name);
        }

        void XtraClearFormatRules(XtraItemEventArgs e) { FormatRules.Clear(); }
        object XtraCreateFormatRulesItem(XtraItemEventArgs e)
        {
            var rule = new GridFormatRule();
            formatRules.Add(rule);
            return rule;
        }
        #region IXtraSerializable
        public void OnEndDeserializing(string restoredVersion) { }
        public void OnEndSerializing() { }
        public void OnStartDeserializing(LayoutAllowEventArgs e) { }
        public void OnStartSerializing() { }
        #endregion
    }

}
