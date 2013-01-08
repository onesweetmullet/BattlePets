using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BattlePetsWebApp.Models
{
    public class PetAttackModel
    {
        [Display(Name = "PlayerID")]
        public string PlayerID { get; set; }

        [Display(Name = "PetSkillID")]
        public string PetSkillID { get; set; }

        [Display(Name = "PetInstanceID")]
        public string PetskillID { get; set; }

        [Display(Name = "OpponentPetID")]
        public string OpponentPetID { get; set; }

        [Display(Name = "OpponentPetLevel")]
        public string OpponentPetLevel { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }
    }
}