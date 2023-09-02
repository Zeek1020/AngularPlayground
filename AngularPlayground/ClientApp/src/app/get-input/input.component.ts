import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-get-input',
  templateUrl: './input.component.html',
})
export class InputComponent {
  @Input() MyInput: string = "";
  @Output() submitEvent = new EventEmitter<string>();

  submit(value: string) {
    console.log("submitted: " + value);
    this.submitEvent.emit(value);
  }

}
