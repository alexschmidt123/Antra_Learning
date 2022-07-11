import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateCastComponent } from './create-cast/create-cast.component';
import { CreateMovieComponent } from './create-movie/create-movie.component';
import { TopPurchasesComponent } from './top-purchases/top-purchases.component';

const routes: Routes = [
  { path: 'createMovie', component: CreateMovieComponent },
  { path: 'createCast', component: CreateCastComponent },
  { path: 'topPurchases', component: TopPurchasesComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }