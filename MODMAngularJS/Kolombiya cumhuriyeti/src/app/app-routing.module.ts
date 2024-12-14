import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent }, // Login sayfası
  { path: 'home', component: HomeComponent },  // Ana sayfa
  { path: '', redirectTo: '/login', pathMatch: 'full' }, // Varsayılan rota
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
