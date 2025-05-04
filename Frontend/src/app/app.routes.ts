import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { DepartmentListComponent } from './components/department-list/department-list.component';

export const routes: Routes = [
    {path:'', component: HomeComponent},
    {path:'employees', component: EmployeeListComponent},
    {path:'departments', component:DepartmentListComponent},
    {path:'**', redirectTo: ''} 
];
