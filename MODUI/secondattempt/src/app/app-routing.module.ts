import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SignupComponent } from './Component/signup/signup.component';
import { UsersignincomponentComponent } from './Component/usersignincomponent/usersignincomponent.component';
import { LoginComponent } from './Component/login/login.component';
import { HomeComponent } from './Component/home/home.component';
import { AboutUsComponent } from './Component/about-us/about-us.component';
import { AdmindashboardComponent } from './Component/admindashboard/admindashboard.component';
import { userdashboardcomponent} from './Component/userdashboard/userdashboard.component';
import { MentordashboardComponent } from './Component/mentordashboard/mentordashboard.component';
import { PaymentComponent } from './Component/payment/payment.component';


const routes: Routes = [
  {path: '',component:HomeComponent},
  {path: 'home',component:HomeComponent},
  {path: 'aboutus',component:AboutUsComponent},
  {path: 'login',component:LoginComponent},
  {path: 'admindashboard',component:AdmindashboardComponent},
  {path:'userdashboard',component:userdashboardcomponent},
  {path:'mentordashboard', component:MentordashboardComponent},
  {path:'Payment',component:PaymentComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
