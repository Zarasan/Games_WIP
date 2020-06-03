using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Character_Select_Screen.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Profession { get; set; }
        public int Cash { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }
        public string Avatar { get; set; }
        public Player(string name, string gender, string profession, int cash, int xp, int level, string avatar)
        {
            Name = name;
            Gender = gender;
            Profession = profession;
            Cash = cash;
            Xp = xp;
            Level = level;
            Avatar = avatar;
        }

        public void Save()
        {
            XElement player = new XElement("Player",
                       new XElement("Name", Name),
                       new XElement("Gender", Gender),
                       new XElement("Profession", Profession),
                       new XElement("Money", Cash),
                       new XElement("Experience", Xp),
                       new XElement("Level", Level),
                       new XElement("Avatar", Avatar));
            player.Save("player.xml");
        }
    }
}
