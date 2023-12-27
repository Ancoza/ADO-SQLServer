
namespace HR_ADO_SQLServer.Models
{
    public class Dependent
    {
        public int dependent_id {  get; set; }
        public string firs_name { get; set; }
        public string last_name { get; set; }   
        public string relationship { get; set; }
        public int employee_id { get; set; }
    }
}
