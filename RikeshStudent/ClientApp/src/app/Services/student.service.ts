import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Student } from '../Model/stuDetails'


@Injectable()
export class StudentService {

  constructor(private _http:HttpClient) { }

  saveStudentDetails(stdmodel:Student)
  {
    debugger;
    return this._http.post<Student>('https://localhost:44331/api/SudentDetails/SaveStudentDetails',stdmodel)
  }
}
