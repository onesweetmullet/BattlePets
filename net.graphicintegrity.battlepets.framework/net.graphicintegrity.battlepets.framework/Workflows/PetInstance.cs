using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class PetInstance : Model.PetInstance
    {
        public static int GetPetInstanceLevel(int petInstanceID)
        {
            return GetPetInstance(petInstanceID).PetInstanceLevel;
        }

        public static int GetPetID(int petInstanceID)
        {
            return GetPetInstance(petInstanceID).PetID;
        }

        public static int GetPetRemainingHealth(int petInstanceID, int incomingHealthChange)
        {
            Model.PetInstance _petInstance = GetPetInstance(petInstanceID);

            int _newPetInstanceCurrentHealth = _petInstance.PetInstanceCurrentHealth - incomingHealthChange;

            if (_newPetInstanceCurrentHealth < 0)
            {
                _newPetInstanceCurrentHealth = 0;
            }

            _petInstance.PetInstanceCurrentHealth = _newPetInstanceCurrentHealth;
            
            // set up to save
            Dictionary<string, string> _d = new Dictionary<string, string>();
            _d.Add("PetInstanceCurrentHealth", _petInstance.PetInstanceCurrentHealth.ToString());
            UpdatePetInstance(petInstanceID, _d);

            return _petInstance.PetInstanceCurrentHealth;
        }

        public static void UpdatePetInstance(int petInstanceID, Dictionary<string,string> d)
        {
            // load the xml
            XElement _xml = GetXElement(Constants.PET_INSTANCES_XML);

            var _query = Utilities.Xml.GetMatchByID(_xml, "PetInstance", "PetInstanceID", petInstanceID);

            if (_query.Count() > 0)
            {
                foreach (XElement _item in _query)
                {
                    Utilities.Xml.UpdateXML(d, _item, Constants.PET_INSTANCES_XML, _xml);
                }
            }
        }

        private static XElement GetXElement(string xmlPath)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(xmlPath));
            return _xml;
        }
    }
}
