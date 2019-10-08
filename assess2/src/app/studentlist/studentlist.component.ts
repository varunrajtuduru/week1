import { Component, OnInit } from '@angular/core';
import {Student} from '../student'
import {StudentserviceService} from '../studentservice.service'
@Component({
  selector: 'app-studentlist',
  templateUrl: './studentlist.component.html',
  styleUrls: ['./studentlist.component.scss']
})
export class StudentlistComponent implements OnInit {
stud:Student[];
studen:Student;
updatediv=false;
  constructor(private st:StudentserviceService) {
    this.stud=this.st.getstudent();
   }


  ngOnInit() {
  }
  edit(index:number)
  {   
    console.log("Index "+index);
     this.updatediv=true; 
     this.studen=this.stud[index];
    this.st.update(this.studen,index);  
   }
  deleteEmployee(index:number)
  {
    this.st.delete(index);
   }

   update()
   {
     this.updatediv=false;
   }

}
