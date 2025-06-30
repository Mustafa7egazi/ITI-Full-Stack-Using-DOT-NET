import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from "../components/header/header";
import { Banner } from "../components/banner/banner";
import { Features } from "../components/features/features";
import { Trending } from "../components/trending/trending";
import { MostPlay } from "../components/most-play/most-play";
import { Categories } from "../components/categories/categories";
import { Cta } from "../components/cta/cta";
import { Footer } from "../components/footer/footer";

@Component({
  selector: 'app-root',
  imports: [Header, Banner, Features, Trending, MostPlay, Categories, Cta, Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'GamingZone';
}
