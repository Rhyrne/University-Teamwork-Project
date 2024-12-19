import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private http: HttpClient) { }

  private baseUrl = 'http://example.com/api';

  register(data: { username: string; email: string; password: string }): Observable<any> {
    return this.http.post(`${this.baseUrl}/register`, data);}

  login(data: { username: string; password: string }): Observable<any> {
    return this.http.post(`${this.baseUrl}/login`, data);
  }

  isAuthenticated(): boolean {
    
    return !!localStorage.getItem('token');
  }

  logout() {
    
    localStorage.removeItem('token');
  }

 //kullanıcı listeleme
  getUsers(): Observable<any> {
    return this.http.get(`${this.baseUrl}/users`);
  }
  //kullanıcı ekleme
  addUser(data: any): Observable<any> {
    return this.http.post(`${this.baseUrl}/users`, data);
  }

}
