import { Component } from '@angular/core';
import { DepartmentService } from '../../services/department.service';
import { response } from 'express';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrl: './department.component.css',
  providers: [DepartmentService]
})
export class DepartmentComponent {

  alldepartment:any[] = [];

constructor(private apidepartment:DepartmentService) {}

  ngOnInit(): void {
   this.apidepartment.getDepartment().subscribe((response:any) =>{
    console.log(response);
    this.alldepartment = response;
   } )

  }
  

}
