import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';

@Component({
  selector: 'app-details-page',
  imports: [],
  templateUrl: './details-page.html',
  styleUrl: './details-page.css'
})
export class DetailsPage  {
  
  isLogedOut: boolean = false;

  @Input()user:any;

  @Output() onLogout = new EventEmitter<boolean>();

logout(){
  this.isLogedOut = true;
  this.onLogout.emit(this.isLogedOut);
}
}
