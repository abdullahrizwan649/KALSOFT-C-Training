using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
public class Student
    {
        public string name, reg_no;
        public int id;

        Student(string c_name,string c_reg_no,int c_id)
        {
            name = c_name;
            reg_no = c_reg_no;
            id = c_id;
        }

        public void display()
        {

        }

    }
}
