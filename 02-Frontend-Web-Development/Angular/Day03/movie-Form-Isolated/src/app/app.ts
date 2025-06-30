// app.component.ts
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddMovieFormComponent } from './components/Movies/add-form-component/add-form-component'; 
import { MovieListComponent } from './components/Movies/movies-list-component/movies-list-component';
import { InputCaptalize } from "./components/Input/input-captalize";
import { Home } from "./components/Home/home";
import { Navigator } from "./components/navigator/navigator";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule,
    AddMovieFormComponent,
    MovieListComponent,
    InputCaptalize,
    Home,
    Navigator
],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {


  // navigating flags

  showMovies: boolean = false;
  showHome: boolean = true;
  ShowInput: boolean = false;

  navigateTo(componentName: string): void {
    this.showMovies = false;
    this.showHome = false;
    this.ShowInput = false;
    console.log('Navigating to:', componentName);

    switch (componentName) {
      case 'movies':
        this.showMovies = true;
        break;
      case 'home':
        this.showHome = true;
        break;
      case 'input':
        this.ShowInput = true;
        break;
      default:
        console.error('Unknown component name:', componentName);
    }
  }


  title = 'movie-app';
  movies: any[] = []; 
  categories: string[] = ['Action', 'Comedy', 'Drama', 'Horror', 'Animation']; 

  onMovieAdded(newMovie: any): void {
    this.movies = [...this.movies, newMovie];
    alert('Movie added successfully!');
  }

  
  onRemoveMovie(movieToRemove: any): void {
    this.movies = this.movies.filter((movie) => movie !== movieToRemove);
  }
}
