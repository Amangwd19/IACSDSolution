import { Component, EventEmitter, Input, OnInit, Output }
       from '@angular/core';

       
@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {

  @Input() count:number;              // custom property
  @Output() update=new EventEmitter();// custom event

  constructor() { }

  ngOnInit(): void {
  }

  increment(){
    this.count ++;
    this.update.emit({count:this.count});
  }

  decrement(){
    this.count --;
    this.update.emit({count:this.count});
  }
}
