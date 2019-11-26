import { Component, OnInit } from '@angular/core';
import { UsersigninserviceService } from 'src/app/Service/usersigninservice.service';
import { MentorsignupserviceService } from 'src/app/Service/mentorsignupservice.service';
import { Usersignupmodel } from 'src/app/Model/usersignupmodel';
import { Mentorsignupmodel } from 'src/app/Model/mentorsignupmodel';
import { Skillmodel } from 'src/app/Model/skillmodel';
import { SkillserviceService } from 'src/app/Service/skillservice.service';

@Component({
  selector: 'app-admindashboard',
  templateUrl: './admindashboard.component.html',
  styleUrls: ['./admindashboard.component.css']
})
export class AdmindashboardComponent implements OnInit {
  item:Usersignupmodel;
  list:Usersignupmodel[];

  item1:Mentorsignupmodel;
  list1:Mentorsignupmodel[];

item2:Skillmodel;
list2:Skillmodel[];

  val1="";
  msg:string;

  constructor(private service:UsersigninserviceService,private service1:MentorsignupserviceService, private service2:SkillserviceService) { }

  ngOnInit() {
  }
  User(){
    this.val1="User";
    this.service.GetAll().subscribe(k=>this.list=k)
  }
  Mentor(){
     this.val1="Mentor"
     this.service1.GetAll().subscribe(data=>this.list1=data)
   }
   Skill(){
     this.val1="Skill"
     this.service2.GetAll().subscribe(data=>this.list2=data)
   }
 DeleteUser(uid:string)
 {
  this.service.Delete(uid).subscribe(k=>k=this.msg)
 }
DeleteMentor(uid:string)
  {
   this.service1.Delete(uid).subscribe(k=>k=this.msg)
  }
  DeleteSkill(uid:string)
  {
   this.service2.Delete(uid).subscribe(k=>k=this.msg)
  }

  check(){
    if(this.val1=="User"){
      return 1;
    }
    else if(this.val1=="Mentor"){
      return 2;
    }
    else if(this.val1=="Skill"){
      return 3;
    }
    else return 4;
  }
}


