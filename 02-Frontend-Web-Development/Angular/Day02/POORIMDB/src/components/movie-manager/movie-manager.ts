import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-movie-manager',
  imports: [FormsModule],
  templateUrl: './movie-manager.component.html',
  styleUrls: ['./movie-manager.component.css']
})
export class MovieManagerComponent {
  newMovieName: string = '';
  newMovieDescription: string = '';
  newMovieAuthor: string = '';
  newMovieRate: number | null = null;
  newMovieImageUrl: string = '';
  newMovieCategory: string = '';

  movies: any[] = [];
  filteredMovies: any[] = [];

  selectedCategory: string = '';
  searchQuery: string = '';

  categories: string[] = ['Action', 'Comedy', 'Drama', 'Horror', 'Animation'];

  constructor() {
    this.applyFiltersAndSearch();
  }

  addMovie(movieForm: any): void {
    if (movieForm.valid) {
      const newMovie = {
        name: this.newMovieName,
        description: this.newMovieDescription,
        author: this.newMovieAuthor,
        rate: this.newMovieRate,
        imageUrl: this.newMovieImageUrl,
        category: this.newMovieCategory
      };
      this.movies.push(newMovie);
      this.applyFiltersAndSearch();
      this.resetForm();
      alert('Movie added successfully!');
    } else {
      alert('Please fill in all required fields.');
    }
  }

  removeMovie(index: number): void {
    const movieToRemove = this.filteredMovies[index];
    const originalIndex = this.movies.indexOf(movieToRemove);

    if (originalIndex > -1) {
      this.movies.splice(originalIndex, 1);
      this.applyFiltersAndSearch();
    }
  }

  resetForm(): void {
    this.newMovieName = '';
    this.newMovieDescription = '';
    this.newMovieAuthor = '';
    this.newMovieRate = null;
    this.newMovieImageUrl = '';
    this.newMovieCategory = '';
  }

  applyFiltersAndSearch(): void {
    let tempMovies = [...this.movies];

    if (this.selectedCategory) {
      tempMovies = tempMovies.filter(movie => movie.category === this.selectedCategory);
    }

    if (this.searchQuery) {
      const lowerCaseQuery = this.searchQuery.toLowerCase();
      tempMovies = tempMovies.filter(movie =>
        movie.name.toLowerCase().includes(lowerCaseQuery) ||
        movie.author.toLowerCase().includes(lowerCaseQuery)
      );
    }
    this.filteredMovies = tempMovies;
  }
}
