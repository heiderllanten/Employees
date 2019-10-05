import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root',
})
export class EmployeeService {

    private apiUrl = 'http://localhost:51049/api/Employees';  // URL to web api

    constructor(private http: HttpClient, ) { }

    getEmployees(id: number) {
        return this.http.get<Employee[]>(this.apiUrl + ((id) ? '?id=' + id : ''));
    }
}