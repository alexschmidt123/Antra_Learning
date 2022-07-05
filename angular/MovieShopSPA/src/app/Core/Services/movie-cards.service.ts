import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MovieCard } from 'src/app/Shared/Models/movie-card';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieCardsService {

  constructor(private http:HttpClient) { }

  getTopGrossingMovies(pageNumber:number):Observable<MovieCard[]>{
    return this.http.get<MovieCard[]>('https://localhost:7194/api/Movies/top-grossing/Page/' + pageNumber );
  }

  getTopRatedMovies(pageNumber:number):Observable<MovieCard[]>{
    return this.http.get<MovieCard[]>('https://localhost:7194/api/Movies/top-rated/Page/' + pageNumber );
  }

  getMovieDetails(id:number){}
  getMoviesByGenre(genreId:number){

  }
}
