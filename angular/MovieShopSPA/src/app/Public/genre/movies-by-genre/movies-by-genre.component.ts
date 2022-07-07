import { Component, OnInit } from '@angular/core';
import { GenreService } from 'src/app/Core/Services/genre.service';
import { ActivatedRoute } from '@angular/router';
import { MovieCard } from 'src/app/Shared/Models/movie-card';
import { Genre } from 'src/app/Shared/Models/genre';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-movies-by-genre',
  templateUrl: './movies-by-genre.component.html',
  styleUrls: ['./movies-by-genre.component.css']
})
export class MoviesByGenreComponent implements OnInit {
  movies!: MovieCard[];
  id!: number;
  genre!:Genre;
  constructor(private genreService: GenreService, private route: ActivatedRoute) {
    this.id = parseInt(this.route.snapshot.params['id']);
  }

  ngOnInit(): void {
    this.genreService.getMoviesByGenre(this.id).subscribe(m => {
      this.movies = m;
      console.table(this.movies);
    });
  }

  getGenreById(id:number){
    this.genreService.getGenreById(id).subscribe(g=> {
      this.id = id;
      console.table(this.genre);
    })
  }



}
