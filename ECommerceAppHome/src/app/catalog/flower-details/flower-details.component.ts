import { Component,Input, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-flower-details',
  templateUrl: './flower-details.component.html',
  styleUrls: ['./flower-details.component.css']
})
export class FlowerDetailsComponent implements OnInit,OnDestroy {


 @Input() id:number;
 @Input() title:string;
 @Input() description:string;
 @Input() unitPrice:Number;
 @Input() quantity:Number;
 @Input() imageUrl:string;
 @Input() likes:number;
 @Input() comment:string;


  constructor() { }

  ngOnInit(): void {
  }
  ngOnDestroy():void{

  }
  onCounterUpdate(data:any){
    this.likes=data.count;
  }

}
