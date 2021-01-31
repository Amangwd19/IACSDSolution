 

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProducthubService {
  //collection of flowers
  products=[
    { id:1, title:"Sunflower",description:"Wedding best Flower",unitPrice:66,quantity:4500,likes:5260,imageUrl:"/assets/images/gerbera.jpg", comment:"Too Good"},
    { id:2, title:"Rose",description:"Valentine best Flower",unitPrice:5,quantity:4500,likes:1560,imageUrl:"/assets/images/rose.jpg", comment:"Beautiful"},
    { id:3, title:"Louts",description:"Worship best Flower",unitPrice:56,quantity:4500,likes:8760,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
    { id:4, title:"Marigold",description:"Festival best Flower",unitPrice:78,quantity:4500,likes:67,imageUrl:"/assets/images/marigold.jpg",comment:"Beautiful"},
    { id:5, title:"Jasmine",description:"Smelling flower best Flower",unitPrice:45,quantity:4500,likes:564,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
    { id:6, title:"Lily",description:"Decorative best Flower",unitPrice:445,quantity:4500,likes:440,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
    { id:7, title:"Orchid",description:"Five Hotel best Flower",unitPrice:15,quantity:4500,likes:440,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},
    { id:8, title:"Tulip",description:"Kashmir Mogal Garden best Flower",unitPrice:145,quantity:450,likes:555,imageUrl:"/assets/images/Transflower.jpg",comment:"Beautiful"},


  ]
  constructor() { }

  getAllProducts(): any
  {

    // fetch data from external REST API
    // http request code for REST API
    //
    return this.products;
  }

  getProdutById(id:number):any
  {
    return this.products[id];
  }

  insert(newProduct:any):boolean
  {
    let status=false;
     
     
    //inserting new product into aray.
    return status;
  }


update(newProduct:any){
    //inserting new product into aray.
    
    let status=false;
     
     
    //updating existing product into aray.
    return status;
  }


  delete(id:any){
    //inserting new product into aray.
    
    let status=false; 
    //deletion new product into aray.
    return status;
  }
}
