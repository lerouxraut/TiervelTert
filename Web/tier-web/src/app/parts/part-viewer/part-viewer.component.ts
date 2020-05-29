import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-part-viewer',
  templateUrl: './part-viewer.component.html',
  styleUrls: ['./part-viewer.component.css']
})
export class PartViewerComponent implements OnInit {

public title = 'Parts yo';
public subtitle = 'bmw k75 timing thingy';

  constructor() { }

  ngOnInit(): void {
  }

}
