import { Component, OnInit } from '@angular/core';
import {ProducthubService} from '../producthub.service';

@Component({
  selector: 'app-flowers-list',
  templateUrl: './flowers-list.component.html',
  styleUrls: ['./flowers-list.component.css']
})
export class FlowersListComponent implements OnInit {

  flowers:any;

  constructor(private svc:ProducthubService) { }

  ngOnInit(): void {


  /*  this.flowers=[
        { id:1, title:"Gerbera",description:"Wedding best Flower",unitPrice:66,quantity:4500,likes:5260,imageUrl:"/assets/images/gerbera.jpg", comment:"Too Good"},
        { id:2, title:"Rose",description:"Valentine best Flower",unitPrice:5,quantity:4500,likes:1560,imageUrl:"/assets/images/rose.jpg", comment:"Beautiful"},
        { id:3, title:"Louts",description:"Worship best Flower",unitPrice:56,quantity:4500,likes:8760,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
        { id:4, title:"Marigold",description:"Festival best Flower",unitPrice:78,quantity:4500,likes:67,imageUrl:"/assets/images/marigold.jpg",comment:"Beautiful"},
        { id:5, title:"Jasmine",description:"Smelling flower best Flower",unitPrice:45,quantity:4500,likes:564,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
        { id:6, title:"Lily",description:"Decorative best Flower",unitPrice:445,quantity:4500,likes:440,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
        { id:7, title:"Orchid",description:"Five Hotel best Flower",unitPrice:15,quantity:4500,likes:440,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
        { id:8, title:"Tulip",description:"Kashmir Mogal Garden best Flower",unitPrice:145,quantity:450,likes:555,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
    ]*/

    this.flowers=this.svc.getAllProducts();
      
  }
}
