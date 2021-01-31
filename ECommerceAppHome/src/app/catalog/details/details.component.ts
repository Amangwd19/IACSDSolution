import {Router, ActivatedRoute} from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  constructor( private  router:Router, private route:ActivatedRoute,) { }

  ngOnInit(): void {

  }

  goToShoppingCart(id:string):void{
    console.log("flower id ="+ id);
    this.router.navigate(['/cart/',id],{relativeTo:this.route});
  }
  goToUpdate(id:string):void{
    console.log("flower id ="+ id);
    this.router.navigate(['/update/',id],{relativeTo:this.route});
  }

  goToRemove(id:string):void{
    console.log("flower id ="+ id);
    this.router.navigate(['/remove/',id],{relativeTo:this.route});
  }
}
