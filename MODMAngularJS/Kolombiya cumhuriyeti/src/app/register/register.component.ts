import { Component, OnInit } from '@angular/core';
import { ApiService } from 'app/services/api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  registerData = {
    username: '',
    email: '',
    password: ''
  };

  constructor(private services: ApiService, private router: Router) { }
  onSubmit() {
    this.services.register(this.registerData).subscribe(
      (response) => {
        console.log('Registration successful', response);
        alert('Registration successful!');
        this.router.navigate(['/login']); // Kayıt başarılı olduğunda login sayfasına yönlendirme
      },
      (error) => {
        console.error('Registration failed', error);
        alert('Registration failed. Please try again.');
      }
    );
  }

  ngOnInit(): void {
  }

}
