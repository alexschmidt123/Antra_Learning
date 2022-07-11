import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/Core/Services/admin.service';
import { Location } from '@angular/common';
import { NgForm, FormsModule } from '@angular/forms';
import { MovieCard } from 'src/app/Shared/Models/movie-card';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-movie',
  templateUrl: './create-movie.component.html',
  styleUrls: ['./create-movie.component.css']
})
export class CreateMovieComponent implements OnInit {
  title:string='';
  posterUrl:string='';
  failed:boolean=false;
  tnc:boolean=false
  flag:boolean=false
  movieCard: MovieCard={id:0,title:'',posterUrl:''}
  constructor(private adminService:AdminService, private _router:Router,private location:Location) { }

  ngOnInit(): void {
  }
  addMovie(movieForm:NgForm){
    this.movieCard.title = movieForm.value.title;
    this.movieCard.posterUrl = movieForm.value.posterUrl;
    console.log(this.movieCard.title);
    console.log(this.movieCard.posterUrl);
    this.adminService.createMovie(this.movieCard).subscribe(m=>{this.flag=true;});
  }

  resetForm(movieForm:NgForm){
    movieForm.resetForm();
  }

  cancel() {
    this.location.back(); // <-- go back to previous location on cancel
  }
}
