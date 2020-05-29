import { NgModule } from '@angular/core';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatCardModule } from '@angular/material/card';


@NgModule({
  imports: [
    MatAutocompleteModule,
    MatCardModule,
  ],
  exports: [
    MatAutocompleteModule,
    MatCardModule,
  ]
})
export class MaterialModule { }
