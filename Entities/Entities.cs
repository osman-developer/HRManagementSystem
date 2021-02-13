using System;

namespace Entities
{
    public class Entities
    {
        public class Params_Delete_Employee
        {
            public int EMPLOYEE_ID { get; set; }
        }

        public class Params_Delete_Department
        {
            public int DEPARTMENT_ID { get; set; }
        }

        public class Params_Delete_Manager
        {
            public int MANAGER_ID { get; set; }
        }
        public class Employee
        {
            public int EMPLOYEE_ID { get; set; }
            public string FIRST_NAME { get; set; }
            public string LAST_NAME { get; set; }
            public string MOBILE { get; set; }
            public int AGE { get; set; }
            public decimal SALARY { get; set; }
            public int DEPARTMENT_ID { get; set; }

        }
        public class Department
        {
            public int DEPARTMENT_ID { get; set; }

            public string NAME { get; set; }
            public string ADDRESS { get; set; }
            public string MOBILE { get; set; }

        }
        public class Manager
        {
            public int MANAGER_ID { get; set; }
            public string FIRST_NAME { get; set; }

            public string LAST_NAME { get; set; }
            public int DEPARTMENT_ID { get; set; }
        }
       
        public class Person
        {
            public int PERSON_ID { get; set; }
            public string NAME { get; set; }
            public string IMG_URL { get; set; }
        }
    }
}
