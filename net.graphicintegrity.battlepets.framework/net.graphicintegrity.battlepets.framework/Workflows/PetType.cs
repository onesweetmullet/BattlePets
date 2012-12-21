using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class PetType : Model.PetType
    {
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
    }
}
