import { Injectable } from '@angular/core';
import { SkillserviceService } from './skillservice.service';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Skillmodel } from '../Model/skillmodel';
import { Trainingmodel } from '../Model/trainingmodel';

@Injectable({
  providedIn: 'root'
})
export class TrainingserviceService {
path:string='http://localhost:5323/api/Training';
  constructor(private _client:HttpClient) { }

  public GetAll():Observable<Trainingmodel[]>{
    return this._client.get<Trainingmodel[]>(this.path+'/GetAll');
  }
  public CompletedTraining(mentor_ID):Observable<Trainingmodel[]>{
    return this._client.get<Trainingmodel[]>(this.path+'/CompleteTraining/'+mentor_ID);
  }

  public CurrentTraining(mentor_ID):Observable<Trainingmodel[]>{
    return this._client.get<Trainingmodel[]>(this.path+'/CurrentTraining/'+mentor_ID);
  }

  public UserCompletedTraining(user_ID):Observable<Trainingmodel[]>{
    return this._client.get<Trainingmodel[]>(this.path+'/UserCompleteTraining/'+user_ID);
  }

  public UserCurrentTraining(user_ID):Observable<Trainingmodel[]>{
    return this._client.get<Trainingmodel[]>(this.path+'/UserCurrentTraining/'+user_ID);
  }

  public getName(){
    
  }
}
