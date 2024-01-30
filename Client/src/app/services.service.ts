import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IStudents } from './Interfaces/Students';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  private apiurl = "http://localhost:5192/api/Students";
  constructor(private http: HttpClient) { }

  getstudents(): Observable<IStudents[]> {
    return this.http.get<IStudents[]>(this.apiurl)
  }
}
