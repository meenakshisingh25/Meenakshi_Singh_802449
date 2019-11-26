import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Skillmodel } from '../Model/skillmodel';

@Injectable({
  providedIn: 'root'
})
export class SkillserviceService {
  path:string='http://localhost:5314/api/Skill';

  constructor(private _client:HttpClient) { 

  }
  public GetAll():Observable<Skillmodel[]>{
    return this._client.get<Skillmodel[]>(this.path+'/GetAll');
  }
  public Add(item:Skillmodel):Observable<string>{
    return this._client.post<string>(this.path+'/Add',item);
}
public Delete(id: string):Observable<string>{
  return this._client.delete<string>(this.path+'/Delete/'+id);
}

public GetName(name:string):Observable<Skillmodel>
  {
    return this._client.get<Skillmodel>(this.path+'/GetName/'+name);
  }
}