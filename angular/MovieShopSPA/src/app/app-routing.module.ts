import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminGuardGuard } from './Core/Guards/admin-guard.guard';
import { AuthGuardGuard } from './Core/Guards/auth-guard.guard';
import { HomeComponent } from './Public/home/home.component';
import { ReviewsComponent } from './Public/reviews/reviews.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'Movies', loadChildren: () => import("./Public/movies.module").then(mod => mod.MoviesModule) },
  { path: 'Admin', loadChildren: () => import("./Admin/admin.module").then(mod => mod.AdminModule), canActivateChild: [AdminGuardGuard] },
  { path: 'Account', loadChildren: () => import("./Account/account.module").then(mod => mod.AccountModule) },
  { path: 'User', loadChildren: () => import("./User/user.module").then(mod => mod.UserModule), canActivate: [AuthGuardGuard] },
  { path: 'Genres', loadChildren: () => import("./Public/genre/genre.module").then(mod => mod.GenreModule) },
  { path: 'Reviews', component: ReviewsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }