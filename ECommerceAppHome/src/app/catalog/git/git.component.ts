import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import {User} from '../user.model';
import {GitHubService} from '../github.service';
import { TmplAstText } from '@angular/compiler';

@Component({
  selector: 'app-git',
  templateUrl: './git.component.html',
  styleUrls: ['./git.component.css']
})
export class GitComponent implements OnInit {

  userName:string="ravitambade";
  data:object;
  user:User;
  loading:boolean=false;

  constructor( private svc:GitHubService) { }

  ngOnInit(): void {
  }

  makeRequest():void{
    this.loading=true;

    //Blocking Call
    //this.data=this.svc.getUser(this.userName)

    //Dynamic Progrmming
    //Functional Programming
    //Non Blocking call
    //Reactive Programming
            // programmer is writing all possbile 
            //reactiove functions as callback

    this.svc.getUser(this.userName).subscribe(
                                              usr=>
                                                      {
                                                        this.user=usr;
                                                        this.data=usr;
                                                        console.log(this.user.company);
                                                        this.loading=true;
                                                      },
                                              error=>
                                                      {console.log(error)}
                                              );
    //invoke function of your service

  }

}
