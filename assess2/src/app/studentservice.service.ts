import { Injectable } from '@angular/core';
import {Student} from './student'
@Injectable({
  providedIn: 'root'
})
export class StudentserviceService {
  stud:Student[]=[
    {department:1,name:'engineering',groupname:'research and development',modifieddate:new Date()},
    {department:2,name:'tool design',groupname:'research and development',modifieddate:new Date()}
  ]

  constructor() { }
  getstudent(){
    return this.stud;
  }
  save(emp:Student)
  {
    this.stud.push(emp)
    emp.modifieddate=new Date();
  }

  update(emp:Student,index:number)
  {
     this.stud[index]=emp;
     emp.modifieddate=new Date();

      }
  delete(index :number)
  {
    this.stud.splice(index,1);
  }


}
