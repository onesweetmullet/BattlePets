using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class Player : Model.Player
    {
        public static void UpdatePlayer(string playerUserName, string playerName)
        {
            Model.Player _player = new Model.Player();
            _player.PlayerID = 1;
            _player.PlayerUsername = playerUserName;
            _player.PlayerName = playerName;
            _player.PlayerCreated = new DateTime(1970,1,1);
            _player.PlayerLastActive = DateTime.Now;
            
            SetPlayer(_player);
        }

        public static void UpdatePlayerActive(string playerUserName, int active)
        {
            SetPlayerActive(playerUserName, active);
        }
    }
}
