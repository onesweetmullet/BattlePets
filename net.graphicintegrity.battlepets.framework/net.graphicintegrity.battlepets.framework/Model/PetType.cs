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

        public static PetType GetPetType(int petTypeID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PET_TYPES_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(PetTypes));

            PetTypes _petTypes = (PetTypes)_ser;

            return _petTypes.ListPetType.Find(i => i.PetTypeID == petTypeID);
        }
        
        public static string GetPetTypeName(int petTypeID)
        {
            return GetPetType(petTypeID).PetTypeName;
        }

        public static string GetPetTypeDescription(int petTypeID)
        {
            return GetPetType(petTypeID).PetTypeDescription;
        }

        public static int GetEffectiveAgainstPetTypeID(int petTypeID)
        {
            return GetPetType(petTypeID).EffectiveAgainstPetTypeID;
        }

        public static int GetNotEffectiveAgainstPetTypeID(int petTypeID)
        {
            return GetPetType(petTypeID).NotEffectiveAgainstPetTypeID;
        }

        public static int GetAttackEffective(PetType playerPetType, PetType opponentPetType)
        {
            // if the player's pet type is not effective against the 
            // opponent's pet type, return a 0
            if (playerPetType.NotEffectiveAgainstPetTypeID == opponentPetType.PetTypeID)
            {
                return 0;
            }

            // if it is effective, return a 2
            if (playerPetType.EffectiveAgainstPetTypeID == opponentPetType.PetTypeID)
            {
                return 2;
            }
            else // standard effectiveness... return a 1
            {
                return 1;
            }
        }

        public static string GetAttackEffectiveString(int effective)
        {
            if (effective == 2)
            {
                return Constants.SUPER_EFFECTIVE;
            }
            else if (effective == 0)
            {
                return Constants.NOT_EFFECTIVE;
            }
            else 
            {
                return Constants.EFFECTIVE;
            }
        }
    }
}
