using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys
{
    internal class ReadElemnt
    {
        public int Id_kabinet;
        public string Name_kabinet;
        public int State_kabinet;
        public ReadElemnt()
        {
        }

        public ReadElemnt(int Id_kabinet, string Name_kabinet, int State_kabinet)
        {
            this.Id_kabinet = Id_kabinet;
            this.Name_kabinet = Name_kabinet;
            this.State_kabinet = State_kabinet;
        }
        public int getId_kabinet()
        {
            return Id_kabinet;
        }
        public string getName_kabinet()
        {
            return Name_kabinet;
        }
        public int getState_kabinet()
        {
            return State_kabinet;
        }
    }
}
