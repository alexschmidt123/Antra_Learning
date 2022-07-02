import { Cast } from "./cast";
import { Genre } from "./genre";
import { Trailer } from "./trailer";

export interface MovieDetails {
    Id:number;
    Title:string;
    PosterUrl:string;
    BackdropUrl:string;
    Rating:number;
    Overview:string;
    Tagline:string;
    Budget:number;
    Revenue:number;
    ImdbUrl:string;
    TmdbUrl:string;
    ReleaseDate:Date;
    Runtime:number;
    Price:number;
    Genres:Genre[];
    Casts:Cast[];
    Trailers:Trailer[];
}