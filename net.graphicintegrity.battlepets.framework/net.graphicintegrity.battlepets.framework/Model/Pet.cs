using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Model
{
    [XmlRoot("Pets")]
    public class Pets
    {
        [XmlElement("Pet")]
        public List<Pet> ListPet { get; set; }
    }

    public class Pet
    {
        #region Attributes
        [XmlAttribute("PetID")]
        public int PetID { get; set; }

        [XmlAttribute("PetName")]
        public string PetName { get; set; }

        [XmlAttribute("PetTypeID")]
        public int PetTypeID { get; set; }

        [XmlAttribute("PetDescription")]
        public string PetDescription { get; set; }
        #endregion

        protected static Pet GetPet(int petID)
        {
            XElement _xml = XElement.Load(System.IO.Path.GetFullPath(Constants.PETS_XML));

            var _ser = Utilities.Serializer.XmlDeserializeFromString(_xml.ToString(), typeof(Pets));

            Pets _pets = (Pets)_ser;

            return _pets.ListPet.Find(i => i.PetID == petID);
        }
    }
}
