import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ScaleOnHoverDirective } from '../../Directives/scale-on-hover';

@Component({
  selector: 'app-movie-card',
  standalone: true,
  imports: [CommonModule , ScaleOnHoverDirective],
  templateUrl: './movie-card-component.html', 
  styleUrl: './movie-card-component.css',
})
export class MovieCardComponent {
  @Input() movie: any;
  @Output() remove = new EventEmitter<void>();

  onRemoveMovie(): void {
    this.remove.emit();
  }
}
