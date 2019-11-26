import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersignincomponentComponent } from './Component/usersignincomponent/usersignincomponent.component';
import { SignupComponent } from './Component/signup/signup.component';
import { SharedsignupModule } from './Component/signup/sharedsignup/sharedsignup.module';
import { HttpClientModule , HttpClient} from '@angular/common/http';
import { MentorsignupcomponentComponent } from './Component/mentorsignupcomponent/mentorsignupcomponent.component';
import { LoginComponent } from './Component/login/login.component';
import { HomeComponent } from './Component/home/home.component';
import { AboutUsComponent } from './Component/about-us/about-us.component';
import { AdmindashboardComponent } from './Component/admindashboard/admindashboard.component';
import { userdashboardcomponent } from './Component/userdashboard/userdashboard.component';
import { MentordashboardComponent } from './Component/mentordashboard/mentordashboard.component';
import { NgbModule, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { PaymentComponent } from './Component/payment/payment.component';


@NgModule({
  declarations: [
    AppComponent,
    UsersignincomponentComponent,
    SignupComponent,
    MentorsignupcomponentComponent,
    LoginComponent,
    HomeComponent,
    AboutUsComponent,
    AdmindashboardComponent,
 userdashboardcomponent,
    MentordashboardComponent,
PaymentComponent,

    ],

  imports: [
    BrowserModule,
    SharedsignupModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [LoginComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
