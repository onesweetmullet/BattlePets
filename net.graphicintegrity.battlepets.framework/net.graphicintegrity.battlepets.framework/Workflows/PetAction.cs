using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public static class PetAction
    {
        public static int PetAttack(int playerID, int petInstanceID, int petSkillID, int opponentPetID, int opponentPetLevel)
        {
            return Model.Pet.Attack(playerID, petInstanceID, petSkillID, opponentPetID, opponentPetLevel);
        }
    }
}
