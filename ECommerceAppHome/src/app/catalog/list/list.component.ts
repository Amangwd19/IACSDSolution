import { Component, OnInit } from '@angular/core';
import {Router, ActivatedRoute} from '@angular/router';
import { ProducthubService } from '../producthub.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  flowers:any;

  constructor( private  router:Router, private route:ActivatedRoute,public svc:ProducthubService) { }

  //Component Lifecycle method

  ngOnInit(): void {

    //Blocking
    this.flowers=this.svc.getAllProducts();
  }


  // event handler for button click

  goToProduct(id:string):void{
    console.log("flower id ="+ id);
    this.router.navigate(['./',id],{relativeTo:this.route});
  }


}
