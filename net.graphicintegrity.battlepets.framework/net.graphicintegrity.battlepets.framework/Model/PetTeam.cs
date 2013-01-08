using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("PetTeams")]
    public class PetTeams
    {
        [XmlElement("PetTeam")]
        public List<PetTeam> ListPetTeam { get; set; }
    }

    public class PetTeam
    {
        #region Attributes
        [XmlAttribute("PetTeamID")]
        public int PetTeamID { get; set; }

        [XmlAttribute("PlayerID")]
        public int PlayerID { get; set; }

        [XmlAttribute("PetOneInstanceID")]
        public int PetOneInstanceID { get; set; }

        [XmlAttribute("PetTwoInstanceID")]
        public int PetTwoInstanceID { get; set; }

        [XmlAttribute("PetThreeInstanceID")]
        public int PetThreeInstanceID { get; set; }

        [XmlAttribute("PetFourInstanceID")]
        public int PetFourInstanceID { get; set; }
        #endregion

        protected static PetTeam GetPetTeam(int petTeamID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PET_TEAMS_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(PetTeams));

            PetTeams _petTeams = (PetTeams)_ser;

            return _petTeams.ListPetTeam.Find(i => i.PetTeamID == petTeamID);
        }
    }
}
