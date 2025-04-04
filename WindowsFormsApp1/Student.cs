using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private int idNum;
        private string name;
        

        public void SetIdNum(int idNum) {  
            this.idNum = idNum; 
        }

        public int GetIdNum() { 
            return this.idNum; 
        }

        

        public void SetName(string name) { 
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }







        /// <summary>
        /// Gets or Sets the ID number of a student
        /// </summary>
        public int IdNumber {

            get {
                return idNum;
            }

            set { 
                idNum = value;
            }


        }


        /// <summary>
        /// Gets or Sets the Name of a student
        /// </summary>
        public String Name {

            get { return name; }

            set {  name = value; }
        }







        public override String ToString()
                {
                    return "ID Number: " + IdNumber + 
                           "\nName: " + Name;
            
                }

    }
}
