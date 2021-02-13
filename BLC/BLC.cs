using System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Entities.Entities;


namespace BLC
{
    public class BLC
    {
        public string connStr = "";
        public List<Employee> GetAllEmployees()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Employee> oList = oDALC.GetAllEmployees();
            oList.RemoveAll(x => x.SALARY < 2000);
            oList.RemoveAll(x => x.AGE < 20 || x.AGE > 40);
            return oList;
        }
        public List<Person> GetAllPerson()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Person> oList = oDALC.GetAllPerson();
            return oList;
        }


        public void Edit_Person(Person i_Person)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Person(i_Person);
        }
        public void Delete_Employee(Params_Delete_Employee i_Params_Delete_Employee)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Employee(i_Params_Delete_Employee);
        }



        public void Edit_Employee(Employee i_Employee)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Employee(i_Employee);
        }

        public List<Employee> Get_Highest_Paid_Employee(Params_Delete_Department i_Params_Delete_Department)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Employee> oList = oDALC.Get_Highest_Paid_Employee(i_Params_Delete_Department);
            //oList = oList.OrderBy(x => x.NAME).ToList();
            //oList.RemoveAll(x => x.ADDRESS == "Tripoli");
            return oList;
        }

        public List<Employee> Get_Youngest_Employee(Params_Delete_Department i_Params_Delete_Department)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Employee> oList = oDALC.Get_Youngest_Employee(i_Params_Delete_Department);
            //oList = oList.OrderBy(x => x.NAME).ToList();
            //oList.RemoveAll(x => x.ADDRESS == "Tripoli");
            return oList;
        }


        //-------------------------------------------------

        public List<Department> GetAllDepartments()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Department> oList = oDALC.GetAllDepartments();

            return oList;
        }


        public void Delete_Department(Params_Delete_Department i_Params_Delete_Department)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Department(i_Params_Delete_Department);
        }



        public void Edit_Department(Department i_Department)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Department(i_Department);
        }

        //-------------------------------------------------
        public List<Manager> GetAllManagersOfDepartment(Params_Delete_Department i_Params_Delete_Department)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Manager> oList = oDALC.GetAllManagersOfDepartment(i_Params_Delete_Department);
            //oList = oList.OrderBy(x => x.NAME).ToList();
            //oList.RemoveAll(x => x.ADDRESS == "Tripoli");
            return oList;
        }


        public void Delete_Manager(Params_Delete_Manager i_Params_Delete_Manager)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Manager(i_Params_Delete_Manager);
        }



        public void Edit_Manager(Manager i_Manager)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Edit_Manager(i_Manager);
        }

        //-------------------------------------------------

    }
}
