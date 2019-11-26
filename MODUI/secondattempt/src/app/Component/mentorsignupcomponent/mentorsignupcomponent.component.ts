import { Component, OnInit } from '@angular/core';
import { Mentorsignupmodel } from 'src/app/Model/mentorsignupmodel';
import { MentorsignupserviceService } from 'src/app/Service/mentorsignupservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-mentorsignupcomponent',
  templateUrl: './mentorsignupcomponent.component.html',
  styleUrls: ['./mentorsignupcomponent.component.css']
})
export class MentorsignupcomponentComponent implements OnInit {
  item:Mentorsignupmodel;
  list:Mentorsignupmodel[];
  msg:string;
  role:string;
  Confuser:string;
  Confuser_Password:string;
  constructor(private service:MentorsignupserviceService,private router:Router) {
    this.item= new Mentorsignupmodel();
    
   }

  ngOnInit() {
  }
  public Add(){
    this.service.Add(this.item).subscribe(k=>this.msg=k)
    this.router.navigate(['/login']);
  }

}
