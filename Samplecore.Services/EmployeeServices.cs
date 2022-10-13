using Samplecore.Core.IRepository;
using Samplecore.Core.Iservices;
using Samplecore.Core.Model;
using Samplecore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplecore.Services
{
    //  Access the EmployeeServices into Interface Employeeservice
    public class EmployeeServices : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        #region Create

        
        public void CreateEmployeeEntry(employee employees)
        {
            _employeeRepository.CreateEmployeeEntry(employees);
        }
        #endregion

        #region Read

       
        public List<employee> Read()
        {
            return _employeeRepository.Read();
        }
        #endregion

        #region update

        
        public employee Update(int Employee_id)
        {
            return _employeeRepository.Update(Employee_id);
        }
        public void Update( employee model)
        {
            _employeeRepository.Update( model);
        }
        #endregion

        #region Delete

        public void Delete(int Employee_id)

        {
            _employeeRepository.Delete(Employee_id);
        }
        #endregion
    }
}

