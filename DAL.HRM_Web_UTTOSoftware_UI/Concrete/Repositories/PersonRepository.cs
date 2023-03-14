using DAL.HRM_Web_UTTOSoftware.Abstract;
using DAL.HRM_Web_UTTOSoftware.Base.EntityFramework;
using DAL.HRM_Web_UTTOSoftware.Concrete.Context;
using ENTITIES.HRM_Web_UTTOSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HRM_Web_UTTOSoftware.Concrete.Repositories
{
    public class PersonRepository : EFRepositoryBase<Person, HRMContextDB>, IPersonDAL
    {
        public PersonRepository(HRMContextDB context) : base(context)
        {
        }
    }
}
