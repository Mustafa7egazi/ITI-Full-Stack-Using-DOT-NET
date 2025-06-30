import { Component } from '@angular/core';
import { Header } from './header/header';
import { Banner } from './banner/banner';
import { Cta } from './cta/cta';
import { Categories } from './categories/categories';
import { Features } from './features/features';
import { Footer } from './footer/footer';
import { MostPlay } from './most-play/most-play';
import { Trending } from './trending/trending';

@Component({
  selector: 'app-home',
  imports: [Header , Banner , Cta , Categories , Features , Footer , MostPlay , Trending],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {

}
