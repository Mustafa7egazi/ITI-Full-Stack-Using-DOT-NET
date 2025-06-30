import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-input-captalize',
  imports: [FormsModule],
  templateUrl: './input-captalize.html',
  styleUrl: './input-captalize.css',
})
export class InputCaptalize {
  inputText: string = '';

  onInput(event: Event): void {
    const input = event.target as HTMLInputElement;
    this.inputText = input.value.toUpperCase();
  }
}
