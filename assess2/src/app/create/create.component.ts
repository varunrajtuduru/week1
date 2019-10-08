import { Component, OnInit } from '@angular/core';
import { Student } from '../student';
import {StudentserviceService} from '../studentservice.service';
import {Router} from '@angular/router'

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
  studen=new Student;
  constructor(private es:StudentserviceService,private route:Router) { }



  ngOnInit() {
  }
  saveStudent():void{
    this.es.save(this.studen);
    this.route.navigate(['studentlist'])
  }

}
