import { Component, OnInit } from '@angular/core';
import { Trainingmodel } from 'src/app/Model/trainingmodel';
import { TrainingserviceService } from 'src/app/Service/trainingservice.service';
import { Mentorsignupmodel } from 'src/app/Model/mentorsignupmodel';
import { Skillmodel } from 'src/app/Model/skillmodel';
import { UsersigninserviceService } from 'src/app/Service/usersigninservice.service';
import { SkillserviceService } from 'src/app/Service/skillservice.service';

@Component({
  selector: 'app-mentordashboard',
  templateUrl: './userdashboard.component.html',
  styleUrls: ['./userdashboard.component.css']
})
export class userdashboardcomponent implements OnInit {
  item:Trainingmodel;
  list:Trainingmodel[];
  item1:Mentorsignupmodel;
  list1:Mentorsignupmodel[];
  list2:Skillmodel[];
  SkillId:string[]=[];
  list3:number[]=[];
  fee:number[]=[];
// .......................................................................
//   item:Mentor;
// list:Mentor[];
// list1:Skill[];

// item1:Training;
// list3:Training[];



userid;

currentdate=new Date();
//.........................................................................
  val1="";
  msg:string;

  technology;
timestart;
count;

  constructor(private service:TrainingserviceService, private service1 : UsersigninserviceService,private service2:SkillserviceService) 
  { 
    this.item= new Trainingmodel();
  }
  public isCollapsed = false;
  ngOnInit() {

    this.service2.GetAll().subscribe(data=>this.list2=data)
  }
  // CurrentTraining()
  // {
  //   this.val1="CurrentTaining";
  //   this.service.
  // }

  

  // AllTraining(){
  //   this.val1="AllTraining";
  //   this.service.GetAll().subscribe(k=>this.list=k)
  // }

  onSubmit(){
    this.service1.SearchMentor(this.technology,this.timestart).subscribe(k=>{
      this.list1=k;
      k.forEach(element => {
        console.log(element)
            this.service2.GetName(element.mentor_Primary_Skill).subscribe(j=>{
                if(j!=null){
                  this.fee.push(j.fee)
                }
                else{
                  this.fee.push(null)
                }})
      });
      if(this.fee!=null){
        this.count= k.length;
      }
      else{
        this.count=0;
      }
    });
  }

 

//*************************************************

  UserCurrentTraining(){

     this.val1="CurrentTraining";
     this.service.CurrentTraining(localStorage.getItem('mid')).subscribe(k=>this.list=k)
  }

   UserCompletedTraining(){
    this.val1="CompletedTraining";
    this.service.CompletedTraining(localStorage.getItem('mid')).subscribe(k=>this.list=k)
   }

  check(){

    // if(this.val1=="AllTraining"){
    //   return 1;
    // }

    if(this.val1=="CurrentTraining"){
      return 1;
    }

    else if(this.val1=="CompletedTraining"){
      return 2;
    }
    
    else return 3;
  }
}
