using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
