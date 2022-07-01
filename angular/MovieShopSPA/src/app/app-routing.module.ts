import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { GenreComponent } from './Public/genre/genre.component';
import { HomeComponent } from './Public/home/home.component';
//import { ReviewsComponent } from './Public/reviews/reviews.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  { path: 'Movies', loadChildren: () => import("./Public/movies.module").then(mod => mod.MoviesModule) },
  { path: 'Admin', loadChildren: () => import("./Admin/admin.module").then(mod => mod.AdminModule) },
  { path: 'Account', loadChildren: () => import("./Account/account.module").then(mod => mod.AccountModule) },
  { path: 'User', loadChildren: () => import("./User/user.module").then(mod => mod.UserModule) },
  // { path: 'Genres', component: GenreComponent },
  // { path: 'Reviews', component: ReviewsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
