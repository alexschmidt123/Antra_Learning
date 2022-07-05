import { Component, OnInit } from '@angular/core';
import { MovieCardsService } from 'src/app/Core/Services/movie-cards.service';
import { MovieCard } from 'src/app/Shared/Models/movie-card';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  Grossingmovies!: MovieCard[];
  Ratedmovies!: MovieCard[];
  constructor(private movieService: MovieCardsService) { }

  public Grossingvisible:boolean =false;

  public Ratedvisible:boolean =true;

  public pageNumber:number = 1;

  ngOnInit(): void {
      this.movieService.getTopGrossingMovies(this.pageNumber).subscribe(m => {
        this.Grossingmovies = m;
        console.table(this.Grossingmovies);
      });
      this.movieService.getTopRatedMovies(this.pageNumber).subscribe(m => {
        this.Ratedmovies = m;
        console.table(this.Ratedmovies);
      });
  }

  ShowTopGrossing(){
    this.Grossingvisible = true;
    this.Ratedvisible = false;
  }

  ShowTopRated(){
    this.Ratedvisible = true;
    this.Grossingvisible = false;
  }

  IncreasePageNumber(){
    this.pageNumber += 1;
  }

  DecreasePageNumber(){
    this.pageNumber -= 1;
  }

}
