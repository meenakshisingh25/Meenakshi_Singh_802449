import { Component, OnInit } from '@angular/core';
import { UsersigninserviceService } from 'src/app/Service/usersigninservice.service';
import { Usersignupmodel } from 'src/app/Model/usersignupmodel';
import { Router } from '@angular/router';

@Component({
  selector: 'app-usersignincomponent',
  templateUrl: './usersignincomponent.component.html',
  styleUrls: ['./usersignincomponent.component.css']
})
export class UsersignincomponentComponent implements OnInit {
  item:Usersignupmodel;
  list:Usersignupmodel[];
  msg:string;
  Confuser_Password:string;
  constructor( private service:UsersigninserviceService , private router:Router) {
    this.item= new Usersignupmodel();
   }

  ngOnInit() {
  }
  public Add(){
    this.service.Add(this.item).subscribe(k=>this.msg=k)
    this.router.navigate(['/login']);
  }

}

