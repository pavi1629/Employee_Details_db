using Samplecore.Core.Model;
using Samplecore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplecore.Core.Iservices
{
    //Inteface of Iservices
   public interface IEmployeeService
    {
        public void CreateEmployeeEntry(employee employees);
        public List<employee> Read();
        public employee Update(int Employee_id);
        public void Update( employee model);
        public void Delete(int Employee_id);

    }
}
