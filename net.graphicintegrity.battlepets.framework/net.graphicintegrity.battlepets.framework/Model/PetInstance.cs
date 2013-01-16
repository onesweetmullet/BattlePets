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
        #region Attributes
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

        [XmlAttribute("PetInstanceCurrentHealth")]
        public int PetInstanceCurrentHealth { get; set; }
        #endregion

        // modifiers for skills?
        // maybe just add a multiplier for level * maxDamage, level * minDamage?
                
        protected static PetInstance GetPetInstance(int petInstanceID)
        {
            PetInstance _petInstance = new PetInstance();

            string _query = "SELECT * FROM PetInstance WHERE PetInstanceID = " + petInstanceID;
            List<List<string>> _listResults = DataAccessLayer.DataBase.GetResults(_query,
                System.IO.Path.GetFullPath(Constants.DATABASE_PATH));

            foreach (List<string> _list in _listResults)
            {
                _petInstance.PetInstanceID = int.Parse(_list[0]);
                _petInstance.PetID = int.Parse(_list[1]);
                _petInstance.PlayerID = int.Parse(_list[2]);
                _petInstance.PetInstanceLevel = int.Parse(_list[3]);
                _petInstance.PetInstanceHealthMax = int.Parse(_list[4]);
                _petInstance.PetInstanceCurrentHealth = int.Parse(_list[5]);
            }

            return _petInstance;

            //XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PET_INSTANCES_XML));

            //var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(PetInstances));

            //PetInstances _petInstances = (PetInstances)_ser;

            //return _petInstances.ListPetInstance.Find(i => i.PetInstanceID == petInstanceID);
        }
    }
}
