using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    public class Player
    {
        #region Attributes
        [XmlAttribute("PlayerID")]
        public int PlayerID { get; set; }

        [XmlAttribute("PlayerUsername")]
        public string PlayerUsername { get; set; }

        [XmlAttribute("PlayerName")]
        public string PlayerName { get; set; }

        [XmlAttribute("PlayerCreated")]
        public DateTime PlayerCreated { get; set; }

        [XmlAttribute("PlayerLastActive")]
        public DateTime PlayerLastActive { get; set; }
        #endregion


    }
}
