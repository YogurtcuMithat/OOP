using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Character
    {
        public string CharacterName { get; set; }
        public int Damage { get; set; }
        public  int  Armor { get; set; }
        protected void Walk()
        {
            MessageBox.Show("Yüründü aslan");
        }
    }
}
