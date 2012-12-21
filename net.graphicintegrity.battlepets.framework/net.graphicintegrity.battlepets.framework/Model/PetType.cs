using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("PetTypes")]
    public class PetTypes
    {
        [XmlElement("PetType")]
        public List<PetType> ListPetType { get; set; }
    }

    public class PetType
    {
        #region Attributes
        [XmlAttribute("PetTypeID")]
        public int PetTypeID { get; set; }

        [XmlAttribute("PetTypeName")]
        public string PetTypeName { get; set; }

        [XmlAttribute("PetTypeDescription")]
        public string PetTypeDescription { get; set; }
        
        [XmlAttribute("EffectiveAgainstPetTypeID")]
        public int EffectiveAgainstPetTypeID { get; set; }

        [XmlAttribute("NotEffectiveAgainstPetTypeID")]
        public int NotEffectiveAgainstPetTypeID { get; set; }
        #endregion

        protected static PetType GetPetType(int petTypeID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PET_TYPES_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(PetTypes));

            PetTypes _petTypes = (PetTypes)_ser;

            return _petTypes.ListPetType.Find(i => i.PetTypeID == petTypeID);
        }
    }
}
