import { Component, OnInit } from '@angular/core';
import { LoginServiceService } from 'src/app/Service/login-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
id;
password;
token:any;
  constructor(public _service:LoginServiceService,private router:Router) { }

  ngOnInit() {
  }
  public Login(){
    this._service.Login(this.id,this.password).subscribe(data=>
      {
        console.log(data)
        localStorage.setItem('msg',data.username)
        if(data.message=="User")
        {        if(data.message=="User")
        {    
          // if(data.active=="True")
          
        alert('Successfull Login as User\n\n');
        localStorage.setItem('mid',this.id)
        this.router.navigate(['/userdashboard']);
        localStorage.setItem('login','yes');
        
      }   
      else{
        this.router.navigate(['/login']);

        alert('Admin Blocked You..Come Back After Sometime!!\n\n');

      }

        }
        else if(data.message=="Mentor")
        {
        alert('Successfull Login as Mentor!!\n\n');
        localStorage.setItem('mid',this.id)
        this.router.navigate(['/mentordashboard']);
        localStorage.setItem('login','yes');

        }

        else if(data.message=="Admin")
        {
        alert('Successfull Login as Admin!!\n\n');
        this.router.navigate(['/admindashboard']);
        localStorage.setItem('login','yes');
        }
        else
        {
        alert('you are entering wrong details!!\n\n');
       // this.router.navigate(['/login']);
        }

      });}
      isLogin(){
        if(localStorage.getItem('login')==="yes")
        return true;
        else
            return false;
      }
      
logoutUser(){
    localStorage.removeItem('login')
    localStorage.removeItem('role')
    localStorage.removeItem('msg')
    this.router.navigate(['/login'])
  }
}

      


