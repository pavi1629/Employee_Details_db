using AngleSharp.Dom;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Azure.Amqp.Framing;
using Samplecore.Core.IRepository;
using Samplecore.Core.Model;
using Samplecore.Entity;


namespace Samplecore.Repository
{
    // Calling Repository to Interface Repository
    public class EmployeeRepository : IEmployeeRepository
    {

        public PaviContext entity;
        public EmployeeRepository(PaviContext master)
        {
            entity = master;
        }
        #region create

       
        //  create and add the record to the database
        public void CreateEmployeeEntry(employee employees)
        {
            if(employees!=null)
            { 
            // creating object connection to the database
            Employee_Table employe = new Employee_Table();
            {
                employe.Employee_Id = employees.EmployeeId;
                employe.FirstName = employees.FirstName;
                employe.MiddleName = employees.MiddleName;
                employe.LastName = employees.LastName;
                employe.Course = employees.Course;
                employe.Gender = employees.Gender;
                employe.Phone = employees.Phone;
                employe.Address = employees.Address;
                employe.Email = employees.Email;
                employe.Password = employees.Password;
                employe.Retype_Password = employees.Repassword;

                employe.Created_Time_Stamp = DateTime.Now;
                employe.Updated_Time_Stamp = DateTime.Now;

                //Add data to the particular table
                entity.Add(employe);

                //Save the changes
                entity.SaveChanges();
                    }
            }
        }
        #endregion

        #region read

       
        public List<employee> Read()
        {
            //using (var PaviContext = new PaviContext())
            // Return the list of data from the database
            List<employee> models = new List<employee>();
           var data = entity.Employee_Table.Where(a => a.Is_Deleted == false).ToList(); 
            
            foreach (var item in data)
            {
                employee employe_detail = new employee();

                employe_detail.EmployeeId= item.Employee_Id;
                employe_detail.FirstName =item.FirstName;
                employe_detail.MiddleName= item.MiddleName;
                employe_detail.LastName =item.LastName;
                employe_detail.Course = item.Course;
                employe_detail.Gender = item.Gender;
                employe_detail.Phone = item.Phone??0;
                employe_detail.Address = item.Address;
                employe_detail.Email = item.Email;
                employe_detail.Password = item.Password??0;
                employe_detail.Repassword = item.Retype_Password??0;

                models.Add(employe_detail);

            }
            return models;
            
        }
        #endregion

        #region Update

       
        public employee Update(int Employee_id)
        {
            

            employee employe_detail = new employee();
            var data = entity.Employee_Table.Where(x => x.Employee_Id == Employee_id).SingleOrDefault();

            employe_detail.EmployeeId = data.Employee_Id;
            employe_detail.FirstName = data.FirstName;
            employe_detail.MiddleName = data.MiddleName;
            employe_detail.LastName = data.LastName;
            employe_detail.Course = data.Course;
            employe_detail.Gender = data.Gender;
            employe_detail.Phone = data.Phone ?? 0;
            employe_detail.Address = data.Address;
            employe_detail.Email = data.Email;
            employe_detail.Password = data.Password ?? 0;
            employe_detail.Repassword = data.Retype_Password ?? 0;

            //entity.SaveChanges();
            return employe_detail;

        }
        // To specify that this will be invoked when post method is called

        public void Update( employee model)
        {
            // Use of lambda expression to access particular record from a database
            var data = entity.Employee_Table.Where(x => x.Employee_Id == model.EmployeeId).SingleOrDefault();

            // Checking if any such record exist
            if (data != null)
            {

                data.Employee_Id = model.EmployeeId;
                data.FirstName = model.FirstName;
                data.MiddleName = model.MiddleName;
                data.LastName = model.LastName;
                data.Course = model.Course;
                data.Gender = model.Gender;
                data.Phone = model.Phone;
                data.Address = model.Address;
                data.Email = model.Email;
                data.Password = model.Password;
                data.Retype_Password = model.Repassword;          

                //Save the changes
                entity.SaveChanges();

            }
        }
        #endregion

        #region delete

          public void Delete(int Employee_id)
        {
            var data = entity.Employee_Table.Where(x => x.Employee_Id == Employee_id).SingleOrDefault();
            if (data != null)
            {              
                data.Is_Deleted = true;
                entity.SaveChanges();
            }
        }

       


        #endregion
    }
}

