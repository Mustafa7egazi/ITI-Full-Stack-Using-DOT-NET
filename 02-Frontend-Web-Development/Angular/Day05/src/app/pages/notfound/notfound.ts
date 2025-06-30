import { Component } from '@angular/core';
import { Shared } from '../../shared/shared';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-notfound',
  imports: [Shared , RouterLink],
  templateUrl: './notfound.html',
  styleUrl: './notfound.css',
})
export class Notfound {}
