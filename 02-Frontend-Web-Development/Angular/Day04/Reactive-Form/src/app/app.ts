import { Component, Input } from '@angular/core';
import { FormPage } from "../components/form-page/form-page";
import { DetailsPage } from "../components/details-page/details-page";

@Component({
  selector: 'app-root',
  imports: [FormPage, DetailsPage],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Reactive-Form';

  currentUser:any;

 @Input() isLogedOut!: boolean;

  logout(status:boolean) {
    this.isLogedOut = status;
  }

  login(passedStatusAndUser:any) {
    this.isLogedOut = !passedStatusAndUser.status;
    this.currentUser = passedStatusAndUser.user;
  }
}
