import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import { environment } from '../../environments/environment.development'
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  private apiUrl = environment.apiUrl;
  constructor(private client:HttpClient) { }

  getDepartment():any
  {
    // return this.client.get(this.url);
    return this.client.get(`${this.apiUrl}/department/GetDepartments`);
  }

  // getDepartment(): Observable<any> {
  //   return this.http.get(`${this.apiUrl}/department/GetDepartments`);

  // }

}
