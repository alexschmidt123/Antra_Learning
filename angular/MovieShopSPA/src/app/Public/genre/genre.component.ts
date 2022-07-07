import { Component, OnInit } from '@angular/core';
import { GenreService } from 'src/app/Core/Services/genre.service';
import { Genre } from 'src/app/Shared/Models/genre';
import { MovieCard } from 'src/app/Shared/Models/movie-card';

@Component({
  selector: 'app-genre',
  templateUrl: './genre.component.html',
  styleUrls: ['./genre.component.css']
})
export class GenreComponent implements OnInit {
  moviesByGenre!: MovieCard[];
  genres!:Genre[];
  deleteFlag:boolean = false;

  constructor(private genreService:GenreService) { }

  ngOnInit(): void {
    this.genreService.getAllGenres().subscribe(g => {
      this.genres = g;
      console.table(this.genres);
    });
  }
  getMoviesByGenre(id:number){
    this.genreService.getMoviesByGenre(id).subscribe(m=> {
      this. moviesByGenre =m;
      console.table(this.moviesByGenre);
    })
  }
  deleteGenre(id:number){
    this.genreService.deleteGenre(id).subscribe(p => {
      this.deleteFlag = true;
    })
  }
}
