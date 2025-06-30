import { Component } from '@angular/core';
import { Shared } from '../../shared/shared';
import { Login } from '../../components/login/login';
import { Register } from '../../components/register/register';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-account',
  imports: [Shared, RouterOutlet],
  templateUrl: './account.html',
  styleUrl: './account.css',
})
export class Account {}
