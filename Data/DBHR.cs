using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HR_ADO_SQLServer.Data
{
    public class DBHR
    {
        string connectionString = "Data Source=localhost;" +
            "Initial Catalog=HR;" +
            "User id=sa;" +
            "Password=123456;";

        public List<Employee> GetEmployees()
        {
            string query = "SELECT * FROM employees";
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.employee_id = reader.GetInt32(0);
                        employee.first_name = reader.GetString(1);
                        employee.last_name = reader.GetString(2);
                        employee.email = reader.GetString(3);
                        employee.phone_number = reader.GetString(4);
                        employee.hire_date = (DateTime)reader.GetDateTime(5);
                        employee.job_id = reader.GetInt32(6);
                        employee.salary = reader.GetDecimal(7);
                        employee.manager_id = reader.GetInt32(8);
                        employee.department_id = reader.GetInt32(9);
                        employees.Add(employee);
                        Console.Write(employee);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return employees;
        }
        
        #region Job
        public List<Job> GetJobs()
        {
            string queryjobs = "Select * from jobs";
            List<Job> jobs = new List<Job>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryjobs, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Job job = new Job();
                        job.job_id = reader.GetInt32(0);
                        job.job_title = reader.GetString(1);
                        job.min_salary = reader.GetDecimal(2);
                        job.max_salary = reader.GetDecimal(3);
                        jobs.Add(job);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return jobs;
        }
        public Job GetJob(int job_id)
        {
            string queryjobs = "Select * from jobs where job_id=@job_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryjobs, connection);
                command.Parameters.AddWithValue("@job_id", job_id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    Job job = new Job();
                    job.job_id = reader.GetInt32(0);
                    job.job_title = reader.GetString(1);
                    job.min_salary = reader.GetDecimal(2);
                    job.max_salary = reader.GetDecimal(3);
                    
                    connection.Close();
                    return job;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return null;
            }
        }
        public void NewJob(string job_title,  decimal min_salary, decimal max_salary)
        {
            string queryNewJobs = "insert into jobs (job_title, min_salary, max_salary) values (@job_title, @min_salary, @max_salary)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryNewJobs, connection);
                command.Parameters.AddWithValue("@job_title", job_title);
                command.Parameters.AddWithValue("@min_salary", min_salary);
                command.Parameters.AddWithValue("@max_salary", max_salary);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void EditJob(string job_title, decimal min_salary, decimal max_salary, int job_id)
        {
            string editquery = "update jobs set job_title=@job_title, min_salary=@min_salary, max_salary=@max_salary where job_id=@job_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(editquery, connection);
                command.Parameters.AddWithValue("@job_title", job_title);
                command.Parameters.AddWithValue("@min_salary", min_salary);
                command.Parameters.AddWithValue("@max_salary", max_salary);
                command.Parameters.AddWithValue("@job_id", job_id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DeleteJobs(int  job_id)
        {
            string queryDeleteJobs = "Delete from jobs where job_id=@job_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryDeleteJobs, connection);
                command.Parameters.AddWithValue("@job_id", job_id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        #endregion
    }
}
