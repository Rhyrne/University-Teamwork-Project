import { Component } from '@angular/core';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent {
  activeTab: 'login' | 'register' = 'login';
  email: string = '';
  password: string = '';
  confirmPassword: string = '';

  constructor() {}

  switchTab(tab: 'login' | 'register') {
    this.activeTab = tab;
  }

  onLogin() {
    // Giriş işlemleri
  }

  onRegister() {
    // Kayıt işlemleri
    if (this.password !== this.confirmPassword) {
      alert('Passwords do not match!');
      return;
    }
  }
}
