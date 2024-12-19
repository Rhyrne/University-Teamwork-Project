import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule,Routes } from '@angular/router';
import { AppRoutingModule } from './app.routing';
import { ComponentsModule } from './components/components.module';
import { AppComponent } from './app.component';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { HomeComponent } from './home/home.component';
import { NewsComponent } from './news/news.component';
import { BusinessesComponent } from './businesses/businesses.component';
import { JobsComponent } from './jobs/jobs.component';
import { TravelGuideComponent } from './travel-guide/travel-guide.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterceptor } from './services/auth.interceptor';



const routes: Routes = [
  { path: 'login', component: LoginComponent },
  {path: 'register',component: RegisterComponent},
  {path : 'home',component: HomeComponent},
  {path:'news',component: NewsComponent },
  {path: 'jobs',component: JobsComponent},
  {path: 'businesses',component: BusinessesComponent},
  {path: 'travel-guide',component : TravelGuideComponent },
];
@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ComponentsModule,
    RouterModule.forRoot(routes),
    AppRoutingModule,
  ],
  declarations: [
    AppComponent,
    AdminLayoutComponent,
    HomeComponent,
    NewsComponent,
    BusinessesComponent,
    JobsComponent,
    TravelGuideComponent,
    LoginComponent,
    RegisterComponent,

  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
