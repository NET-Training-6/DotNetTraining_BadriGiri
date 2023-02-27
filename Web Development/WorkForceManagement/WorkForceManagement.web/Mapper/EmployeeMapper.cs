﻿using WorkForceManagement.web.Models;
using WorkForceManagement.web.ViewModels;

namespace WorkForceManagement.web.Mapper;

public static class EmployeeMapper
{
    public static Employee MapToModel(this EmployeeViewModel employeeViewModel)
    {
        var employee = new Employee
        {
            ID = employeeViewModel.ID,
            Name = employeeViewModel.Name,
            Address = employeeViewModel.Address,
            Contact = employeeViewModel.Contact,
            DepartmentId = employeeViewModel.Department,
           // Designation = employeeViewModel.Designation,
            Dob = employeeViewModel.Dob,
            Gender = employeeViewModel.Gender,
            JoinDate = employeeViewModel.JoinDate,
            ProfileImagePath = employeeViewModel.ProfileImagePath
        };
        return employee;
    }

    public static EmployeeViewModel MapToViewModel(this Employee employee)
    {
        var employeeViewModel = new EmployeeViewModel
        {
            ID = employee.ID,
            Name = employee.Name,
            Address = employee.Address,
            Contact = employee.Contact,
            DepartmentName = employee.Department?.Name??"n/a",
           // Designation = employee.Designation,
            Dob = employee.Dob,
            Gender = employee.Gender,
            JoinDate = employee.JoinDate,
            ProfileImagePath = employee.ProfileImagePath
        };

        return employeeViewModel;
    }

    public static List<EmployeeViewModel> MapToViewModel(this List<Employee> employees)
    {
        var employeeViewModels = employees.Select(emp => MapToViewModel(emp)).ToList();
        return employeeViewModels;
    }

}
