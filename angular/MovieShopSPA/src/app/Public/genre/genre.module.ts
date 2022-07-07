import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GenreRoutingModule } from './genre-routing.module';
import { GenreComponent } from './genre.component';
import { AddGenreComponent } from './add-genre/add-genre.component';
import {MoviesByGenreComponent } from './movies-by-genre/movies-by-genre.component';
import { FormsModule} from '@angular/forms';

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