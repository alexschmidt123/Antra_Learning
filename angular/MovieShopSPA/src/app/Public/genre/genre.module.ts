import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GenreRoutingModule } from './genre-routing.module';
import { GenreComponent } from './genre.component';
import { AddGenreComponent } from './add-genre/add-genre.component';
import { FormsModule, NgForm } from '@angular/forms';
import { MoviesByGenreComponent } from './movies-by-genre/movies-by-genre.component';

@NgModule({
  declarations: [
    GenreComponent,
    AddGenreComponent,
    MoviesByGenreComponent
  ],
  imports: [
    CommonModule,
    GenreRoutingModule,
    FormsModule
  ]
})
export class GenreModule { }