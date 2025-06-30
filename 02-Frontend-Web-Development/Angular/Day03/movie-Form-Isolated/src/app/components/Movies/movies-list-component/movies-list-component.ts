import {
  Component,
  Input,
  Output,
  EventEmitter,
  OnChanges,
  SimpleChanges,
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MovieCardComponent } from '../movie-card-component/movie-card-component';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [CommonModule, FormsModule, MovieCardComponent],
  templateUrl: './movies-list-component.html', 
  styleUrl: './movies-list-component.css', 
})
export class MovieListComponent implements OnChanges {
  @Input() movies: any[] = [];
  @Input() categories: string[] = [];
  @Output() removeMovieEvent = new EventEmitter<any>(); 

  filteredMovies: any[] = [];
  selectedCategory: string = '';
  searchQuery: string = '';

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['movies']) {
      this.applyFiltersAndSearch();
    }
  }

  applyFiltersAndSearch(): void {
    let tempMovies = [...this.movies];

    if (this.selectedCategory) {
      tempMovies = tempMovies.filter(
        (movie) => movie.category === this.selectedCategory
      );
    }

    if (this.searchQuery) {
      const lowerCaseQuery = this.searchQuery.toLowerCase();
      tempMovies = tempMovies.filter(
        (movie) =>
          movie.name.toLowerCase().includes(lowerCaseQuery) ||
          movie.author.toLowerCase().includes(lowerCaseQuery)
      );
    }
    this.filteredMovies = tempMovies;
  }

  onRemoveMovie(movieToRemove: any): void {
   
    this.removeMovieEvent.emit(movieToRemove);
  }
}
