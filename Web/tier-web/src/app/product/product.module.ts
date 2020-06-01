import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductIndexComponent } from './product-index/product-index.component';
import { ProductFormComponent } from './product-form/product-form.component';



@NgModule({
  declarations: [ProductIndexComponent, ProductFormComponent],
  imports: [
    CommonModule
  ]
})
export class ProductModule { }
