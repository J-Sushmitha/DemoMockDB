﻿using DemoMockDB.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoMockDB.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property  
        private readonly AppDbContext _appDbContext;
        #endregion

        #region Constructor  
        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        public async Task<string> GetEmployeebyId(int EmpID)
        {
            var name = await _appDbContext.Employees.Where(c => c.Id == EmpID).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var emp = await _appDbContext.Employees.FirstOrDefaultAsync(c => c.Id == EmpID);
            return emp;
        }
    }
}
