import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PartsModule } from './parts/parts.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    PartsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
