import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Usersignupmodel } from '../Model/usersignupmodel';

import { Observable } from 'rxjs';
import { Mentorsignupmodel } from '../Model/mentorsignupmodel';

@Injectable({
  providedIn: 'root'
})
export class UsersigninserviceService {
  path:string='http://localhost:5308/api/User';


  constructor(private _client:HttpClient) { }
  public Add(item:Usersignupmodel):Observable<string>{
    return this._client.post<string>(this.path+'/Add',item);
  }
  public GetAll():Observable<Usersignupmodel[]>{
    return this._client.get<Usersignupmodel[]>(this.path+'/GetAll');
  }
    public Delete(uid: string):Observable<string>{
      return this._client.delete<string>(this.path+'/Delete/'+uid);

  }
  public SearchMentor(tech:string,time:string):Observable<Mentorsignupmodel[]>
    {
      return this._client.get<Mentorsignupmodel[]>(this.path+'/SearchMentor/'+tech+'/'+time);
    }
}
