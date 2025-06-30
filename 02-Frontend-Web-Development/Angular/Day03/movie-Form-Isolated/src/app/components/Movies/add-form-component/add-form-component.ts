import { Component, Output, EventEmitter, Input } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-movie-form',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-form-component.html', 
  styleUrl: './add-form-component.css',
})
export class AddMovieFormComponent {
  @Input() categories: string[] = [];
  @Output() movieAdded = new EventEmitter<any>();

  newMovieName: string = '';
  newMovieDescription: string = '';
  newMovieAuthor: string = '';
  newMovieRate: number | null = null;
  newMovieImageUrl: string = '';
  newMovieCategory: string = '';

  onSubmit(movieForm: NgForm): void {
    if (movieForm.valid) {
      const newMovie = {
        name: this.newMovieName,
        description: this.newMovieDescription,
        author: this.newMovieAuthor,
        rate: this.newMovieRate,
        imageUrl: this.newMovieImageUrl,
        category: this.newMovieCategory,
      };
      this.movieAdded.emit(newMovie);
      this.resetForm(movieForm);
    } else {
      alert('Please fill in all required fields.');
    }
  }

  resetForm(movieForm: NgForm): void {
    movieForm.resetForm();
    this.newMovieName = '';
    this.newMovieDescription = '';
    this.newMovieAuthor = '';
    this.newMovieRate = null;
    this.newMovieImageUrl = '';
    this.newMovieCategory = '';
  }
}
