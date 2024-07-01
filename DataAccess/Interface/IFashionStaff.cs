using FashionStaff.Domain.DTOs;
using FashionStaff.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStaff.DataAccess.Interface
{
    public interface IFashionStaff
    {
        Task<Staff> Addstaff(FashionStaffDTO newstaff);
        Task<string> Delete(int id);
        Task<Staff> Update(int id);
        Task<string> GetAllStaff();
        Task<Staff> GetStaffById();

    }
}
