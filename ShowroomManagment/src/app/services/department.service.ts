import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import { environment } from '../../environments/environment.development'
import { HttpClient } from '@angular/common/http';
import { Department } from '../shared/department.model';

@Injectable({
  providedIn: 'root'
})

export class DepartmentService { 
  private apiUrl = environment.apiUrl;
  constructor(private client:HttpClient) { }

 DepartmentData:Department = new Department(); // for post data / insert data

  getDepartment():any
  {
    // return this.client.get(this.url);
    return this.client.get(`${this.apiUrl}/Department/GetDepartments`);
  }

  SaveDepartment()
  {
    return this.client.post(`${this.apiUrl}/Department/AddDepartment`,this.DepartmentData);
  }

  UpdateDepartment()
  {
    return this.client.post(`${this.apiUrl}/Department/UpdateDepartment`,this.DepartmentData);
  }

  DeleteDepartment(Id:number)
  {
    return this.client.get(`${this.apiUrl}/Department/DeleteDepartment/${Id}`);
  }

  // getDepartment(): Observable<any> {
  //   return this.http.get(`${this.apiUrl}/department/GetDepartments`);

  // }

}
