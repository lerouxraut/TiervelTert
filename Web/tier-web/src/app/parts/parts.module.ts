import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PartViewerComponent } from './part-viewer/part-viewer.component';
import { StlModelViewerModule } from 'angular-stl-model-viewer';


@NgModule({
  declarations: [PartViewerComponent],
  imports: [
    StlModelViewerModule,
    CommonModule
  ],
  exports: [
    PartViewerComponent,
  ]
})
export class PartsModule {

}
