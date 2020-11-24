using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTania
{
    class Member
    {
        //DATAMEMBER
        private string nama;
        private int umur;

        //PROPERTISE
        public string Nama { get => nama; set => nama = value; }
        public int Umur { get => umur; set => umur = value; }

        //CONSTRUCTOR
        public Member(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        //METODH
        public void setUmur(int umur)
        {

        }
        public void dispkay()
        {

        }
    }
}
