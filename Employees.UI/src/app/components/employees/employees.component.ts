import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'contractTypeName', 'roleName', 'hourlySalary', 'monthlySalary', 'anualSalary'];
  dataSource: Employee[];
  employeeId: number;

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.getEmployees();
  }

  getEmployees(){
    this.employeeService.getEmployees(this.employeeId).subscribe( (resp: Employee[]) => {
      this.dataSource = resp;
    });
  }

}
