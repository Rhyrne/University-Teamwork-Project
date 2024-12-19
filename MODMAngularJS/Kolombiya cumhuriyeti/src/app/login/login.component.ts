import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiService } from 'app/services/api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  loginData = {
    username: '',
    password: ''
  };
 

  constructor(private services: ApiService, private router: Router) {
    
  }

  // Form gönderimi için kullanılan onSubmit metodu
  onSubmit() {
    this.services.login(this.loginData).subscribe(
      (response) => {
        console.log('Login successful', response);
        localStorage.setItem('token', response.token); // JWT token'ı saklama
        this.router.navigate(['/dashboard']); // Başarılı girişten sonra yönlendirme
      },
      (error) => {
        console.error('Login failed', error);
      }
    );
  }
}
