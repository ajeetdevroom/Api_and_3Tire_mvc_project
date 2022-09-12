import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Student } from '../Model/stuDetails'
import { StudentService } from '../Services/student.service'

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {
d
  public studentdetails: Student[];
  stdModel=new Student('','','','','','');
  
  constructor(private router:Router, private _service:StudentService ) { }

  ngOnInit() {
  }
  OnSubmit()
  {
    debugger;
    this._service.saveStudentDetails(this.stdModel).subscribe((res:any)=>{
      console.log(res);
      this.stdModel.stdAddress='';
      this.stdModel.stdClass='';
      this.stdModel.stdEmail='';
      this.stdModel.stdId='';
      this.stdModel.stdMobile='';
      this.stdModel.stdname='';
    
    });
  }
}
