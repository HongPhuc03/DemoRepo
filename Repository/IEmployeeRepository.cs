﻿using DemoModel.Models;

namespace DemoModel.Repository
{
    public interface IEmployeeRepository
    { 
IEnumerable<Employee> GetEmployees (Guid companyId, bool trackChanges); 
Employee GetEmployee(Guid companyId, Guid id, bool trackChanges); 
void CreateEmployeeForCompany(Guid companyId, Employee employee); 
void DeleteEmployee(Employee employee);
    }
}
