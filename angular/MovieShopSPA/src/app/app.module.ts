import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoreModule } from './Core/core.module';
import { SharedModule } from './Shared/shared.module';
import { MoviesModule } from './Public/movies.module';
import { HttpClientModule } from '@angular/common/http';
import { GenreModule } from './Public/genre/genre.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    CoreModule,
    SharedModule,
    MoviesModule,
    GenreModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
