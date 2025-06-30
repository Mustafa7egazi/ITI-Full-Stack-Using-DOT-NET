import { Home } from './../Home/home';
import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-navigator',
  imports: [CommonModule],
  templateUrl: './navigator.html',
  styleUrl: './navigator.css',
})
export class Navigator {
  flagName: string = '';

  @Output() onChangeComponent = new EventEmitter<string>();


  Home(){
    this.flagName = 'home';
    this.onChangeComponent.emit(this.flagName);

  }
  Movies(){
    this.flagName = 'movies';
    this.onChangeComponent.emit(this.flagName);

  }
  Input(){
    this.flagName = 'input';
    this.onChangeComponent.emit(this.flagName);

  }
}
