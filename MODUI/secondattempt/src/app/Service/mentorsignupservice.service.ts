import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Mentorsignupmodel } from '../Model/mentorsignupmodel';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MentorsignupserviceService {
  path:string='http://localhost:5308/api/Mentor';

  constructor(private _client:HttpClient) { }
  public Add(item:Mentorsignupmodel):Observable<string>{
    return this._client.post<string>(this.path+'/Add',item);}

    public GetAll():Observable<Mentorsignupmodel[]>{
      return this._client.get<Mentorsignupmodel[]>(this.path+'/GetAll');
    }
    public Delete(mid: string):Observable<string>{
      return this._client.delete<string>(this.path+'/Delete/'+mid);
  }
}
