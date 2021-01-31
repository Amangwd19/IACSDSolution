import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { from, Observable } from 'rxjs';
import{User} from './user.model';

@Injectable({
  providedIn: 'root'
})
export class GitHubService {

  //constructor dependency injection

  constructor(private http:HttpClient) { }
  //step 3
  
  //Asynchronous data arraival

  getUser(name:string):Observable<User>   //any
  {

     let gitUrl:string="https://api.github.com/users/";
      //fetch data from  rest api
      return this.http.get<User>(gitUrl+name); // from rest api
  }
}
