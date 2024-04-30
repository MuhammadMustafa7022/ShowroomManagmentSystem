import { Component } from '@angular/core';
import { DepartmentService } from '../../services/department.service';
// import { response } from 'express';
import { Department } from '../../shared/department.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrl: './department.component.css',
  providers: [DepartmentService]
})
export class DepartmentComponent {

alldepartment:any[] = [];

constructor(public apidepartment:DepartmentService) {}

  ngOnInit(): void {
   this.apidepartment.getDepartment().subscribe((response:any) =>{
   this.alldepartment = response.Response;
   });
  }
  
  
  EditDepartment(SelectedDepartment:Department)
  {
    console.log(SelectedDepartment);
    this.apidepartment.DepartmentData = SelectedDepartment;
  }
  
  DeleteDepartment(Id:number)
  {
    if(confirm('Are You Really Want To Delete This Record?'))
      {
        this.apidepartment.DeleteDepartment(Id).subscribe((response:any)=> {
          alert('Record Deleted...');
          //reload data in list
          this.apidepartment.getDepartment().subscribe((response:any)=>{
            this.alldepartment = response.Response;
          });
        },
        err=>{
          console.log('Record Not Deleted...');
        }
      )
    }
  }


  Submit(form:NgForm)
  {
    if(this.apidepartment.DepartmentData.id == 0)
      {
        this.InsertDepartment(form);
      }
      else
      {
        this.UpdateDepartment(form);
      }
  }



  InsertDepartment(form:NgForm)
  {
    this.apidepartment.SaveDepartment().subscribe(d=> {
      this.ResetForm(form);
      this.refreshdata();
      console.log("save changes");
     });
  }

  UpdateDepartment(form:NgForm)
  {
    this.apidepartment.UpdateDepartment().subscribe(d=>{
      this.ResetForm(form);
      this.refreshdata();
      console.log("save changes");
  });
  }

  ResetForm(form:NgForm)
  {
    form.form.reset();
    this.apidepartment.DepartmentData = new Department();
  }

  refreshdata()
  {
    this.apidepartment.getDepartment().subscribe((response:any) =>{
      this.alldepartment = response.Response;
      });
  }

}
