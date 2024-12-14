import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  loginForm: FormGroup; // loginForm burada tanımlanıyor

  constructor(private fb: FormBuilder) {
    // Form yapısını oluşturuyoruz
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  // Form gönderimi için kullanılan onSubmit metodu
  onSubmit() {
    if (this.loginForm.valid) {
      console.log('Form Data:', this.loginForm.value);
      alert('Login successful!');
    } else {
      alert('Form is invalid. Please fix the errors and try again.');
    }
  }
}
