import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SignupComponent } from '../signup.component';
import { UsersignincomponentComponent } from '../../usersignincomponent/usersignincomponent.component';
import { MentorsignupcomponentComponent } from '../../mentorsignupcomponent/mentorsignupcomponent.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path:'signup',component:SignupComponent,children:[
        {path:'usersignin',component:UsersignincomponentComponent},
        {path:'mentorsignup', component:MentorsignupcomponentComponent}
      ]},
      
    ]
  )
  ]
})
export class SharedsignupModule { }
