import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FooterComponent } from './footer/footer.component';
import { FlopListComponent } from './flop-list/flop-list.component';
import { FlopSuggestionComponent } from './flop-suggestion/flop-suggestion.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    FooterComponent,
    FlopListComponent,
    FlopSuggestionComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
