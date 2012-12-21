using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class Pet : Model.Pet
    {
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
    }
}
