using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using RikeshServices_API.BAL;
using RikeshServices_API.Model;
using RikeshServices_API.DAL;

namespace RikeshServices_API.BAL
{
      
    public class BusinessLogic
    {
        RikeshServices_API.DAL.DataAccessLayer dal = new RikeshServices_API.DAL.DataAccessLayer();
        public int saveStudentDetails(Student std)
        {
            int res = dal.InsertStudentDetails(std);
            return res;
        }

    }
}
