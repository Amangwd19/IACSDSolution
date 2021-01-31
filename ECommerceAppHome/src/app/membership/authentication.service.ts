import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor() { }


  public validate(name:string, password:string) :boolean
  {
    let status=false;

    //Validate User from calling REST API of .NET Web API application
    
    return status;
  }

  public register(name:string, password:string, location:string, email:string,contanctNumber:string) :boolean
  {
    let status=false;
    //register code of new into  database through calling REST API

    return status;
  }
}

