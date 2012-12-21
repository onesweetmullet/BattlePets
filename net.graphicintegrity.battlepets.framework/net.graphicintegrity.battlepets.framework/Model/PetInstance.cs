using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("PetInstances")]
    public class PetInstances
    {
        [XmlElement("PetInstance")]
        public List<PetInstance> ListPetInstance { get; set; }
    }

    public class PetInstance
    {
        [XmlAttribute("PetInstanceID")]
        public int PetInstanceID { get; set; }

        [XmlAttribute("PetID")]
        public int PetID { get; set; }

        [XmlAttribute("PlayerID")]
        public int PlayerID { get; set; }

        [XmlAttribute("PetInstanceLevel")]
        public int PetInstanceLevel { get; set; }

        [XmlAttribute("PetInstanceMaxHealth")]
        public int PetInstanceHealthMax { get; set; }
        
        // modifiers for skills?
        // maybe just add a multiplier for level * maxDamage, level * minDamage?

        protected static PetInstance GetPetInstance(int petInstanceID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PET_INSTANCES_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(PetInstances));

            PetInstances _petInstances = (PetInstances)_ser;

            return _petInstances.ListPetInstance.Find(i => i.PetInstanceID == petInstanceID);
        }
    }
}
