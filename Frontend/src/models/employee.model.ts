import { Department } from "./department.model";


export interface Employee{
    employeeId: number; 
    firstName: string;
    lastName: string;
    email: string; 
    dateOfBirth: Date; 
    hireDate: Date 
    position: string 
    salary: number; 
    departmentId: number;  
    department: Department
}
