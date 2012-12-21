using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class PetSkill : Model.PetSkill
    {
        public static int GetPetSkillDamageMinimum(int petSkillID)
        {
            return GetPetSkill(petSkillID).PetSkillDamageMinimum;
        }

        public static int GetPetSkillDamageMaximum(int petSkillID)
        {
            return GetPetSkill(petSkillID).PetSkillDamageMaximum;
        }

        public static string GetPetSkillName(int petSkillID)
        {
            return GetPetSkill(petSkillID).PetSkillName;
        }
    }
}
