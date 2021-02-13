using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLC;
using DALC;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static Entities.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        
        private IConfiguration MyConfig;
        public DataController(IConfiguration config)
        {
         
            this.MyConfig = config;
        }

        [HttpPost]
        [Route("Edit_Person")]
        public void Edit_Person(Person i_person)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Person(i_person);
        }


        [HttpGet]
        [Route("GetAllEmployees")]
        public List<Employee> GetAllEmployees()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllEmployees();
        }
        [HttpGet]
        [Route("GetAllPerson")]
        public List<Person> GetAllPerson()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllPerson();
        }
        //-------------------------------------------------

        [HttpPost]
        [Route("Delete_Employee")]
        public void Delete_Employee(Params_Delete_Employee i_Params_Delete_Employee)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Delete_Employee(i_Params_Delete_Employee);
        }


        [HttpPost]
        [Route("Edit_Employee")]
        public void Edit_Employee(Employee i_Employee)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Employee(i_Employee);
        }

        [HttpPost]
        [Route("Get_Highest_Paid_Employee")]
        public List<Employee> Get_Highest_Paid_Employee(Params_Delete_Department i_Params_Delete_Department)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.Get_Highest_Paid_Employee(i_Params_Delete_Department);
        }

        [HttpPost]
        [Route("Get_Youngest_Employee")]
        public List<Employee> Get_Youngest_Employee(Params_Delete_Department i_Params_Delete_Department)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.Get_Youngest_Employee(i_Params_Delete_Department);
        }


        //-------------------------------------------------
        [HttpPost]
        [Route("Edit_Department")]
        public void Edit_Department(Department i_Department)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Department(i_Department);
        }


        [HttpGet]
        [Route("GetAllDepartments")]
        public List<Department> GetAllDepartments()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllDepartments();
        }


        [HttpPost]
        [Route("Delete_Department")]
        public void Delete_Department(Params_Delete_Department i_Params_Delete_Department)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Delete_Department(i_Params_Delete_Department);
        }

        //-------------------------------------------------
        [HttpPost]
        [Route("Edit_Manager")]
        public void Edit_Manager(Manager i_Manager)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Edit_Manager(i_Manager);
        }


        [HttpPost]
        [Route("GetAllManagersOfDepartment")]
        public List<Manager> GetAllManagersOfDepartment(Params_Delete_Department i_Params_Delete_Department)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            return oBLC.GetAllManagersOfDepartment(i_Params_Delete_Department);
        }


        [HttpPost]
        [Route("Delete_Manager")]
        public void Delete_Manager(Params_Delete_Manager i_Params_Delete_Manager)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = this.MyConfig["AppSettings:MyDBConnection"];
            oBLC.Delete_Manager(i_Params_Delete_Manager);
        }

        //-------------------------------------------------

    }
}