using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTania
{
    public class Tim
    {
        //DATAMEMBER
        private string nama;
        private string member;

        //CONSTRUCTOR
        public Tim(string nama, string member)
        {
            Nama = nama;
            Member = member;
        }

        //PROPERTISE
        public string Nama { get => nama; set => nama = value; }
        public string Member { get => member; set => member = value; }

        //METODH
        public void setMember()
        {

        }
        public void displayFullMember()
        {

        }
        public void displayTrainee()
        {

        }
        public string getNama()
        {

        }
        public void setNama()
        {

        }

    }
}
