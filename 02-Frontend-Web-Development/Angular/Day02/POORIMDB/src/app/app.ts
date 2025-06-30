import { Component } from '@angular/core';
import { MovieManagerComponent } from "../components/movie-manager/movie-manager";


@Component({
  selector: 'app-root',
  imports: [ MovieManagerComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'POORIMDB';
}
