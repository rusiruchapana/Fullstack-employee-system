import { Component } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from '../../../models/employee.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-employee-list',
  imports: [CommonModule],
  templateUrl: './employee-list.component.html',
  styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent {

  employees: Employee[] = [];


  constructor(
    private emplyeeService : EmployeeService
  ){}

  ngOnInit(): void {
    this.loadEmployees();
  }

  loadEmployees(): void{
    this.emplyeeService.getEmployees().subscribe({
      next: (employees)=>{
          this.employees = employees;
      },
      error: (err)=>{
          console.error('Error loading employees:', err);
      }
    });
  }








}
