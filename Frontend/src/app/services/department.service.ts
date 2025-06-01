import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Department } from '../../models/department.model';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  private apiUrl = "http://localhost:5146/api/Department";
  constructor(private http: HttpClient) { }

  getAllDepartments(): Observable<Department[]>{
    return this.http.get<Department[]>(this.apiUrl);
  }



}
