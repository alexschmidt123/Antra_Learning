import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MovieCard } from 'src/app/Shared/Models/movie-card';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  constructor(private http:HttpClient) { }
  createMovie(movieCard:MovieCard){
    return this.http.post('https://localhost:7194/api/Admin/AddMovie', movieCard);
  }
  createCast(){}
  getTopPurchases(){}
}
