import { Component } from '@angular/core';
import { StudentService } from '../services.service';
import { IStudents } from '../Interfaces/Students';


@Component({
  selector: 'app-students',
  standalone: true,
  imports: [],
  templateUrl: './students.component.html',
  styleUrl: './students.component.css'
})
export class StudentsComponent {
  students: IStudents[] = [];
  constructor(private studentService: StudentService) { }
  ngOnInit() {
    this.studentService.getstudents().subscribe(students => {
      this.students = students;
      console.log(this.students);
    });
  }
}
