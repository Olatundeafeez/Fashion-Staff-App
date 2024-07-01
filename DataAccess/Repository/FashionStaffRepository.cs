using FashionStaff.DataAccess.DataContext;
using FashionStaff.DataAccess.Interface;
using FashionStaff.Domain.DTOs;
using FashionStaff.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStaff.DataAccess.Repository
{
    public class FashionStaffRepository : IFashionStaff
    {
        public async Task<Staff> Addstaff(FashionStaffDTO newstaff)
        {
            
            using (var database = new StaffContext())
            {
                try
                {
                    var checkDb = await database.staff.AnyAsync(X => X.Name == newstaff.Name);
                    if (checkDb)
                    {
                        throw new Exception("user does not exist");
                    }
                    var createAStaff = new Staff()

                    {
                        Name = newstaff.Name,
                        Age = newstaff.Age,
                        Description = newstaff.Description,
                    };
                }
                catch
                {
                    

                }

            }

        }

        public Task<string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAllStaff()
        {
            throw new NotImplementedException();
        }

        public Task<Staff> GetStaffById()
        {
            throw new NotImplementedException();
        }

        public Task<Staff> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
