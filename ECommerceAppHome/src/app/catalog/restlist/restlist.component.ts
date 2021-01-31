import { Component, OnInit } from '@angular/core';
import {RestProductHubService}  from '../rest-product-hub.service';


@Component({
  selector: 'app-restlist',
  templateUrl: './restlist.component.html',
  styleUrls: ['./restlist.component.css']
})
export class RestlistComponent implements OnInit {

  constructor( private svc:RestProductHubService) { }
  data:any;

  ngOnInit(): void {

    this.svc.getAllProducts().subscribe(
      products=>
              {
                this.data=products;
                console.log(this.data);
              },
      error=>
              {console.log(error)}
      );
  }
  
  }