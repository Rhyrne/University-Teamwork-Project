import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },  // Ana sayfa için boş path kullanılır
  { path: '**', redirectTo: '' }  // Hatalı URL’leri ana sayfaya yönlendirmek için
  // Burada rotalarını tanımla
];



@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
