import { Component } from '@angular/core';
import { Department } from '../../../models/department.model';
import { DepartmentService } from '../../services/department.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-department-list',
  imports: [CommonModule],
  templateUrl: './department-list.component.html',
  styleUrl: './department-list.component.css'
})
export class DepartmentListComponent {
  departments : Department[] = [];

  constructor(
    private departmentService : DepartmentService
  ){}

  ngOnInit(): void{
    this.loadDepartments();
  }

  loadDepartments(): void{
    this.departmentService.getAllDepartments().subscribe({
      next: (department)=>{
        this.departments = department;
      },
      error: (err)=>{
        console.error('Error loading departments:', err);
      }
    });
  }


}
