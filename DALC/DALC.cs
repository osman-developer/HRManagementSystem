using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Entities.Entities;


namespace DALC
{
    public class DALC
    {
        // 1. Define Your Connection String
        public string connStr;
        public List<Employee> GetAllEmployees()
        {
            List<Employee> oList = new List<Employee>();



            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_EMPLOYEES"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Employee oEmployee = new Employee();
                                oEmployee.EMPLOYEE_ID = Convert.ToInt32(reader["EMPLOYEE_ID"]);
                                oEmployee.FIRST_NAME = Convert.ToString(reader["FIRST_NAME"]);
                                oEmployee.LAST_NAME = Convert.ToString(reader["LAST_NAME"]);
                                oEmployee.MOBILE = Convert.ToString(reader["MOBILE"]);
                                oEmployee.AGE = Convert.ToInt32(reader["AGE"]);
                                oEmployee.SALARY = Convert.ToDecimal(reader["SALARY"]);
                                oEmployee.DEPARTMENT_ID = Convert.ToInt32(reader["DEPARTMENT_ID"]);
                                oList.Add(oEmployee);
                            }
                        }
                    }
                }
            }



            return oList;
        }

        public void Delete_Employee(Params_Delete_Employee i_Params_Delete_Employee)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 1. Define Your Connection String


            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_DELETE_EMPLOYEE"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "EMPLOYEE_ID", Value = i_Params_Delete_Employee.EMPLOYEE_ID });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit_Employee(Employee i_Employee)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_EDIT_EMPLOYEE"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "EMPLOYEE_ID", Value = i_Employee.EMPLOYEE_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "FIRST_NAME", Value = i_Employee.FIRST_NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "LAST_NAME", Value = i_Employee.LAST_NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "MOBILE", Value = i_Employee.MOBILE });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "AGE", Value = i_Employee.AGE });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "SALARY", Value = i_Employee.SALARY });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Employee.DEPARTMENT_ID });

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Employee> Get_Highest_Paid_Employee(Params_Delete_Department i_Params_Delete_Department)
        {
            List<Employee> oList = new List<Employee>();



            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_HIGHEST_PAID_EMPLOYEE"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Params_Delete_Department.DEPARTMENT_ID});

                    command.ExecuteNonQuery();
                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Employee oEmployee = new Employee();
                                oEmployee.EMPLOYEE_ID = Convert.ToInt32(reader["EMPLOYEE_ID"]);
                                oEmployee.FIRST_NAME = Convert.ToString(reader["FIRST_NAME"]);
                                oEmployee.LAST_NAME = Convert.ToString(reader["LAST_NAME"]);
                                oEmployee.MOBILE = Convert.ToString(reader["MOBILE"]);
                                oEmployee.AGE = Convert.ToInt32(reader["AGE"]);
                                oEmployee.SALARY = Convert.ToDecimal(reader["SALARY"]);
                                oEmployee.DEPARTMENT_ID = Convert.ToInt32(reader["DEPARTMENT_ID"]);
                                oList.Add(oEmployee);
                            }
                        }
                    }
                }
            }



            return oList;
        }

        public List<Employee> Get_Youngest_Employee(Params_Delete_Department i_Params_Delete_Department)
        {
            List<Employee> oList = new List<Employee>();



            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_YOUNGEST_EMPLOYEE"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Params_Delete_Department.DEPARTMENT_ID});

                    command.ExecuteNonQuery();
                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Employee oEmployee = new Employee();
                                oEmployee.EMPLOYEE_ID = Convert.ToInt32(reader["EMPLOYEE_ID"]);
                                oEmployee.FIRST_NAME = Convert.ToString(reader["FIRST_NAME"]);
                                oEmployee.LAST_NAME = Convert.ToString(reader["LAST_NAME"]);
                                oEmployee.MOBILE = Convert.ToString(reader["MOBILE"]);
                                oEmployee.AGE = Convert.ToInt32(reader["AGE"]);
                                oEmployee.SALARY = Convert.ToDecimal(reader["SALARY"]);
                                oEmployee.DEPARTMENT_ID = Convert.ToInt32(reader["DEPARTMENT_ID"]);
                                oList.Add(oEmployee);
                            }
                        }
                    }
                }
            }



            return oList;
        }

        //----------------------------------------------------

        public List<Department> GetAllDepartments()
        {
            List<Department> oList = new List<Department>();



            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_DEPARTMENT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Department oDepartment = new Department();
                                oDepartment.DEPARTMENT_ID = Convert.ToInt32(reader["DEPARTMENT_ID"]);
                                oDepartment.NAME = Convert.ToString(reader["NAME"]);
                                oDepartment.ADDRESS = Convert.ToString(reader["ADDRESS"]);
                                oDepartment.MOBILE = Convert.ToString(reader["MOBILE"]);
                                oList.Add(oDepartment);
                            }
                        }
                    }
                }
            }



            return oList;
        }

        public void Delete_Department(Params_Delete_Department i_Params_Delete_Department)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 1. Define Your Connection String


            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_DELETE_DEPARTMENT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Params_Delete_Department.DEPARTMENT_ID });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit_Department(Department i_Department)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_EDIT_DEPARTMENT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Department.DEPARTMENT_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "NAME", Value = i_Department.NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "ADDRESS", Value = i_Department.ADDRESS });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "MOBILE", Value = i_Department.MOBILE });
                  
                    command.ExecuteNonQuery();
                }
            }
        }
        //---------------------------------------------------

        public List<Manager> GetAllManagersOfDepartment(Params_Delete_Department i_Params_Delete_Department)
        {
            List<Manager> oList = new List<Manager>();



            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_MANAGERS_OF_DEPARTMENT"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Params_Delete_Department.DEPARTMENT_ID });

                    command.ExecuteNonQuery();
                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Manager oManager= new Manager();
                                oManager.MANAGER_ID = Convert.ToInt32(reader["MANAGER_ID"]);
                                oManager.FIRST_NAME = Convert.ToString(reader["FIRST_NAME"]);
                                oManager.LAST_NAME = Convert.ToString(reader["LAST_NAME"]);
                                oManager.DEPARTMENT_ID = Convert.ToInt32(reader["DEPARTMENT_ID"]);
                                oList.Add(oManager);
                            }
                        }
                    }
                }
            }



            return oList;
        }

        public void Delete_Manager(Params_Delete_Manager i_Params_Delete_Manager)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 1. Define Your Connection String


            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_DELETE_MANAGER"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "MANAGER_ID", Value = i_Params_Delete_Manager.MANAGER_ID });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit_Manager(Manager i_Manager)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_EDIT_MANAGER"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "MANAGER_ID", Value = i_Manager.DEPARTMENT_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "FIRST_NAME", Value = i_Manager.FIRST_NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "LAST_NAME", Value = i_Manager.LAST_NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "DEPARTMENT_ID", Value = i_Manager.DEPARTMENT_ID });

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Person> GetAllPerson()
        {
            List<Person> oList = new List<Person>();



            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_GET_PERSON"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    // 7. Execute the Command (ExecuteReader)
                    // 8. The Reader is a kind of Hand/Cursor pointing to data retrieved by the Command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Person oPerson = new Person();
                                oPerson.PERSON_ID = Convert.ToInt32(reader["PERSON_ID"]);
                                oPerson.NAME = Convert.ToString(reader["NAME"]);
                                oPerson.IMG_URL = Convert.ToString(reader["IMG_URL"]);
                                oList.Add(oPerson);
                            }
                        }
                    }
                }
            }



            return oList;
        }
        public void Edit_Person(Person i_person)
        {
            // You should Always create a complex type (Class) which has properties matching parameters

            // 2. Create Sql Connection Object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the Connection
                oConn.Open();

                //4 . Prepare Sql Command Object
                using (SqlCommand command = new SqlCommand("UP_EDIT_PERSON"))
                {
                    //5. Set the Command Type to Stored Procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    //6. Inform the Command on Wich connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "PERSON_ID", Value = i_person.PERSON_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "NAME", Value = i_person.NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "IMG_URL", Value = i_person.IMG_URL });
                   
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
