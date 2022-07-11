import { Cast } from "./cast";
import { Genre } from "./genre";
import { Trailer } from "./trailer";

export interface MovieDetails {
    id:number;
    title:string;
    posterUrl:string;
    backdropUrl:string;
    rating:number;
    overview:string;
    tagline:string;
    budget:number;
    revenue:number;
    imdbUrl:string;
    tmdbUrl:string;
    releaseDate:Date;
    runtime:number;
    price:number;
    genres:Genre[];
    casts:Cast[];
    trailers:Trailer[];
}