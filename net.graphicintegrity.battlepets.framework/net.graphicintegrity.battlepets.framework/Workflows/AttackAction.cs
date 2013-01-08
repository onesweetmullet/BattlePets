using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class AttackAction
    {
        private static string GetPetAttackMessage(int playerPetID, int opponentPetID, int petSkillID, int damageAmount,
            string effectiveString)
        {
            string _playerPetName = Workflows.Pet.GetPetName(playerPetID);
            string _opponentPetName = Workflows.Pet.GetPetName(opponentPetID);
            string _skillName = Workflows.PetSkill.GetPetSkillName(petSkillID);

            return _playerPetName + " attacked " + _opponentPetName + " with "
                + _skillName + " for " + damageAmount + " damage. It was " + effectiveString;
        }

        private static int GetAttackEffective(int effectiveAgainstPetTypeID, 
            int notEffectiveAgainstPetTypeID, int opponentPetTypeID)
        {
            // if the player's pet type is not effective against the 
            // opponent's pet type, return a 0
            if (notEffectiveAgainstPetTypeID == opponentPetTypeID)
            {
                return 0;
            }

            // if it is effective, return a 2
            if (effectiveAgainstPetTypeID == opponentPetTypeID)
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

        public static string Attack(int playerID, int petInstanceID, int petSkillID,
            int opponentPetID, int opponentPetLevel)
        {
            // get the pet's level
            int _petInstanceLevel = Workflows.PetInstance.GetPetInstanceLevel(petInstanceID);

            // get the minValue from petSkillID
            int _petSkillDamageMinimum = Workflows.PetSkill.GetPetSkillDamageMinimum(petSkillID) + _petInstanceLevel;

            // get the maxValue from petSkillID
            int _petSkillDamageMaximum = Workflows.PetSkill.GetPetSkillDamageMaximum(petSkillID) + _petInstanceLevel;

            // get the player's petID
            int _playerPetID = Workflows.PetInstance.GetPetID(petInstanceID);

            // get the player's petTypeID
            int _playerPetTypeID = Workflows.Pet.GetPetTypeID(_playerPetID);
                        
            // get the player's effectiveAgainstPetTypeID
            int _effectiveAgainstPetTypeID = Workflows.PetType.GetEffectiveAgainstPetTypeID(_playerPetID);

            // get the player's notEffectiveAgainstPetTypeID
            int _notEffectiveAgainstPetTypeID = Workflows.PetType.GetNotEffectiveAgainstPetTypeID(_playerPetID);

            // get the opponent's petTypeID
            int _oppenentPetTypeID = Workflows.Pet.GetPetTypeID(opponentPetID);

            // determine if the attack will be effective
            int _effective = GetAttackEffective(_effectiveAgainstPetTypeID, _notEffectiveAgainstPetTypeID, _oppenentPetTypeID);

            // get the effective string
            string _effectiveString = GetAttackEffectiveString(_effective);

            // get the value of the attack
            int _damageAmount = Utilities.RNG.GetRandomNumber(_petSkillDamageMinimum, _petSkillDamageMaximum);

            // get the remaining health for the petInstance
            int _remainingHealth = Workflows.PetInstance.GetPetRemainingHealth(petInstanceID, _damageAmount);

            return GetPetAttackMessage(_playerPetID, opponentPetID, petSkillID, _damageAmount, _effectiveString);
        }
    }
}
