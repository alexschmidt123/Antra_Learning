import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MoviesRoutingModule } from './movies-routing.module';
import { MovieDetailsComponent } from './movie-details/movie-details.component';
import { CastDetailsComponent } from './cast-details/cast-details.component';
import { HomeComponent } from './home/home.component';
import { MovieComponent } from './movie-details/movie.component';
import { GenreComponent } from './genre/genre.component';
import { ReviewsComponent } from './reviews/reviews.component';


@NgModule({
  declarations: [
    HomeComponent,
    MovieComponent,
    GenreComponent,
    ReviewsComponent
  ],
  imports: [
    CommonModule,
    MoviesRoutingModule
  ]
})
export class MoviesModule { }
