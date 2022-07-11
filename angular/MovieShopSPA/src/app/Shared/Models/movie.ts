import { Genre } from "./genre";

export interface Movie {
    id:number;
    title:string;
    tagline:string;
    overview:string;
    posterUrl:string;
    genres:Genre[];
}