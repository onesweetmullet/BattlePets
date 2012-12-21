using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("PetSkills")]
    public class PetSkills
    {
        [XmlElement("PetSkill")]
        public List<PetSkill> ListPetSkill { get; set; }
    }

    public class PetSkill
    {
        #region Properties
        [XmlAttribute("PetSkillID")]
        public int PetSkillID { get; set; }

        [XmlAttribute("PetID")]
        public int PetID { get; set; }

        [XmlAttribute("DamageTypeID")]
        public int DamageTypeID { get; set; }

        [XmlAttribute("PetSkillName")]
        public string PetSkillName { get; set; }

        [XmlAttribute("PetSkillDescription")]
        public string PetSkillDescription { get; set; }

        [XmlAttribute("PetSkillDamageMinimum")]
        public int PetSkillDamageMinimum { get; set; }

        [XmlAttribute("PetSkillDamageMaximum")]
        public int PetSkillDamageMaximum { get; set; }

        [XmlAttribute("PetSkillMissChance")]
        public int PetSkillMissChance { get; set; }
        #endregion

        // glancing blow chance

        // dodge chance

        protected static PetSkill GetPetSkill(int petSkillID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PET_SKILLS_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(PetSkills));

            PetSkills _petSkills = (PetSkills)_ser;

            return _petSkills.ListPetSkill.Find(i => i.PetSkillID == petSkillID);
        }        
    }
}
