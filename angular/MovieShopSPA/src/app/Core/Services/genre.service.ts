import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genre } from 'src/app/Shared/Models/genre';
import { MovieCard } from 'src/app/Shared/Models/movie-card';

@Injectable({
  providedIn: 'root'
})
export class GenreService {
  getGenreById(genreId: number):Observable<Genre> {
    return this.http.get<Genre>('https://localhost:7194/api/Genres/'+ genreId);
  }

  constructor(private http:HttpClient) { }
  
  getAllGenres():Observable<Genre[]>{
    return this.http.get<Genre[]>('https://localhost:7194/api/Genres');
  }

  addGenre(genre:Genre){
    return this.http.post('https://localhost:7194/api/Genres/Add', genre);
  }
  getMoviesByGenre(genreId:number):Observable<MovieCard[]>{
    return this.http.get<MovieCard[]>('https://localhost:7194/api/Genres/'+genreId+'/Movies');
  }
  deleteGenre(genreId:number){
    return this.http.delete('https://localhost:7194/api/Genres/Delete/'+genreId);
  }
}
