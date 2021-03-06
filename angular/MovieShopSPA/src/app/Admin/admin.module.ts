import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { CreateMovieComponent } from './create-movie/create-movie.component';
import { CreateCastComponent } from './create-cast/create-cast.component';
import { TopPurchasesComponent } from './top-purchases/top-purchases.component';
import { FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    CreateMovieComponent,
    CreateCastComponent,
    TopPurchasesComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule
  ]
})
export class AdminModule { }
