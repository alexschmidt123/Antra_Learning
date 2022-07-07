import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MoviesRoutingModule } from './movies-routing.module';
import { HomeComponent } from './home/home.component';
import { MovieComponent } from './movie-details/movie.component';
import { ReviewsComponent } from './reviews/reviews.component';
import { GenreModule } from './genre/genre.module';


@NgModule({
  declarations: [
    HomeComponent,
    MovieComponent,
    ReviewsComponent
  ],
  imports: [
    CommonModule,
    MoviesRoutingModule,
    GenreModule
  ]
})
export class MoviesModule { }
