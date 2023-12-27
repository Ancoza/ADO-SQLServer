using System;

namespace HR_ADO_SQLServer.Data
{
    public class Employee
    {
        public int employee_id {  get; set; }
        public string first_name {  get; set; }
        public string last_name { get; set;}
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime hire_date { get; set; }
        public int job_id {  get; set; }
        public decimal salary { get; set; }
        public int manager_id { get; set; }
        public int department_id { get; set; }
    }
}
