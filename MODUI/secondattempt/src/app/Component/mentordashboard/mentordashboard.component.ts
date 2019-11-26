import { Component, OnInit } from '@angular/core';
import { Trainingmodel } from 'src/app/Model/trainingmodel';
import { TrainingserviceService } from 'src/app/Service/trainingservice.service';

@Component({
  selector: 'app-mentordashboard',
  templateUrl: './mentordashboard.component.html',
  styleUrls: ['./mentordashboard.component.css']
})
export class MentordashboardComponent implements OnInit {
  item:Trainingmodel;
  list:Trainingmodel[];


  val1="";
  msg:string;

  constructor(private service:TrainingserviceService) { }

  ngOnInit() {
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

  CurrentTraining(){
     this.val1="CurrentTraining";
     this.service.CurrentTraining(localStorage.getItem('mid')).subscribe(k=>this.list=k)
  }

   CompletedTraining(){
    this.val1="CompletedTraining";
    this.service.CompletedTraining(localStorage.getItem('mid')).subscribe(k=>this.list=k)
   }

  check(){

    if(this.val1=="AllTraining"){
      return 1;
    }

    if(this.val1=="CurrentTraining"){
      return 2;
    }

    else if(this.val1=="CompletedTraining"){
      return 3;
    }
    
    else return 4;
  }
}
