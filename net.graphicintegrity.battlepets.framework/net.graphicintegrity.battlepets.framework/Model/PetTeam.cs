using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    public class PetTeam
    {
        #region Attributes
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
    }
}
