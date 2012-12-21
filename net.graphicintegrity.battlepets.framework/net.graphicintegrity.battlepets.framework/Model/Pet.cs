using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("Pets")]
    public class Pets
    {
        [XmlElement("Pet")]
        public List<Pet> ListPet { get; set; }
    }

    public class Pet
    {
        #region Attributes
        [XmlAttribute("PetID")]
        public int PetID { get; set; }

        [XmlAttribute("PetName")]
        public string PetName { get; set; }

        [XmlAttribute("PetTypeID")]
        public int PetTypeID { get; set; }

        [XmlAttribute("PetDescription")]
        public string PetDescription { get; set; }
        #endregion

        private static Pet GetPet(int petID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PETS_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(Pets));

            Pets _pets = (Pets)_ser;

            return _pets.ListPet.Find(i => i.PetID == petID);
        }

        public static string GetPetName(int petID)
        {
            return GetPet(petID).PetName;            
        }

        public static string GetPetDescription(int petID)
        {
            return GetPet(petID).PetDescription;
        }

        public static int GetPetTypeID(int petID)
        {
            return GetPet(petID).PetTypeID;
        }

        public static int Attack(int playerID, int petInstanceID, int petSkillID, 
            int opponentPetID, int opponentPetLevel)
        {
            // get the pet's level
            int _petInstanceLevel = Model.PetInstance.GetPetInstanceLevel(petInstanceID);

            // get the minValue from petSkillID
            int _petSkillDamageMinimum = Model.PetSkill.GetPetSkillDamageMinimum(petSkillID) + _petInstanceLevel;
                        
            // get the maxValue from petSkillID
            int _petSkillDamageMaximum = Model.PetSkill.GetPetSkillDamageMaximum(petSkillID) + _petInstanceLevel;

            // get the player's petID
            int _playerPetID = Model.PetInstance.GetPetID(petInstanceID);

            // get the player's petTypeID
            int _playerPetTypeID = GetPetTypeID(_playerPetID); 

            // get the opponent's petTypeID
            int _oppenentPetTypeID = GetPetTypeID(opponentPetID);

            // get the player's petType
            Model.PetType _playerPetType = Model.PetType.GetPetType(_playerPetTypeID);

            // get the opponent's petType
            Model.PetType _opponentPetType = Model.PetType.GetPetType(_oppenentPetTypeID);

            // determine if the attack will be effective
            int _effective = Model.PetType.GetAttackEffective(_playerPetType, _opponentPetType);

            // get the effective string
            string _effectiveString = Model.PetType.GetAttackEffectiveString(_effective);


            // get the value of the attack
            return Utilities.RNG.GetRandomNumber(_petSkillDamageMinimum, _petSkillDamageMaximum);
        }

    }

    
}
