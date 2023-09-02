import { Component, Input, OnChanges, OnInit, ViewChild } from '@angular/core';

@Component({
  templateUrl: './testing.component.html',
  selector: 'test-component'
})


export class TestingComponent implements OnInit {

  default = "Default Text";
  header = "Hello, World";

  update(value:string) {
    console.log(`update: ${value}`);
    this.header = value;
  }

  ngOnInit() {
    console.log("Init fired");
  }

}
