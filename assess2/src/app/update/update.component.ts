import { Component, OnInit, Input } from '@angular/core';
import {Student} from '../student';
import {StudentserviceService} from '../studentservice.service'
import {Router} from '@angular/router'


@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {
  Es:Student;
  updatedindex:number;
  @Input()

  rowindex:number;
  constructor(private es:StudentserviceService,private route:Router) { }

  ngOnInit() {
    console.log(this.rowindex)

  }

  updatedata(index:number)
  {
    
  }

}











    
