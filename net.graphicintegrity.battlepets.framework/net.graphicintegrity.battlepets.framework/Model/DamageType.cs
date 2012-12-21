using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("DamageTypes")]
    public class DamageTypes
    {
        [XmlElement("DamageType")]
        public List<DamageType> ListDamageType { get; set; }
    }

    public class DamageType
    {
        #region Attributes
        [XmlAttribute("DamageTypeID")]
        public int DamageTypeID { get; set; }

        [XmlAttribute("DamageTypeName")]
        public string DamageTypeName { get; set; }

        [XmlAttribute("DamageTypeDescription")]
        public string DamageTypeDescription { get; set; }        
        #endregion

        protected static DamageType GetDamageType(int damageTypeID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.DAMAGE_TYPES_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(DamageType));

            DamageTypes _damageTypes = (DamageTypes)_ser;

            return _damageTypes.ListDamageType.Find(i => i.DamageTypeID == damageTypeID);
        }

        

    }
}
