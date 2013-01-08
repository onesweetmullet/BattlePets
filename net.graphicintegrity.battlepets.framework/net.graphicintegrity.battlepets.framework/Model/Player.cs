using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("Players")]
    public class Players
    {
        [XmlElement("Player")]
        public List<Player> ListPlayer { get; set; }
    }

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

        [XmlAttribute("Active")]
        public int Active { get; set; }
        #endregion

        protected static Player GetPlayer(int playerID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PLAYERS_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(Players));

            Players _players = (Players)_ser;

            return _players.ListPlayer.Find(i => i.PlayerID == playerID);
        }

        protected static Player GetPlayer(string playerUserName)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PLAYERS_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(Players));

            Players _players = (Players)_ser;

            return _players.ListPlayer.Find(i => i.PlayerUsername.ToLower() == playerUserName.ToLower());
        }

        protected static void Add(Model.Player player, XElement xml)
        {
            int _maxID = Utilities.Xml.GetMaxID(xml, "Player", "PlayerID");

            XElement _item = new XElement("Player");
            _item.SetAttributeValue("PlayerID", _maxID + 1);
            _item.SetAttributeValue("PlayerUserName", player.PlayerUsername);
            _item.SetAttributeValue("PlayerName", player.PlayerName);
            _item.SetAttributeValue("PlayerCreated", player.PlayerCreated);
            _item.SetAttributeValue("PlayerLastActive", player.PlayerLastActive);
            _item.SetAttributeValue("Active", 1);
            xml.Add(_item);
        }

        protected static void Update(Model.Player player, Dictionary<string, string> d)
        {
            d.Add("PlayerName", player.PlayerName);
            d.Add("PlayerCreated", player.PlayerCreated.ToLongDateString());
            d.Add("PlayerLastActive", player.PlayerLastActive.ToLongDateString());
        }

        protected static void SetPlayer(Model.Player player)
        {
            Dictionary<string, string> _d = new Dictionary<string,string>();
                        
            // load the xml
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PLAYERS_XML));
            
            var _query = Utilities.Xml.GetMatchByName(_xml, "Player", "PlayerUserName", player.PlayerUsername);
            
            if (_query.Count() == 0)
            {
                Add(player, _xml);
                _xml.Save(System.IO.Path.GetFullPath(Constants.PLAYERS_XML));
            }
            else
            {
                foreach (XElement _item in _query)
                {
                    Update(player, _d);
                    Utilities.Xml.UpdateXML(_d, _item, Constants.PLAYERS_XML, _xml);
                }
            }
        }

        protected static void SetPlayerActive(string playerUserName, int active)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PLAYERS_XML));

            var _query = Utilities.Xml.GetMatchByName(_xml, "Player", "PlayerUserName", playerUserName);
                        
            foreach (XElement _item in _query)
            {
                Dictionary<string, string> _d = new Dictionary<string, string>();
                _d.Add("Active", active.ToString());
                Utilities.Xml.UpdateXML(_d, _item, Constants.PLAYERS_XML, _xml);
            }
        }
    }
}
