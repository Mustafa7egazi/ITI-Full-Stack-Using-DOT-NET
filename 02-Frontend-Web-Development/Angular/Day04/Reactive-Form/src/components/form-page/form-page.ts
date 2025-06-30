import { JsonPipe } from '@angular/common';
import { Component, EventEmitter, OnInit, Output, Pipe } from '@angular/core';
import { FormGroup, FormControl, Validators, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-form-page',
  imports: [ReactiveFormsModule, JsonPipe],
  templateUrl: './form-page.html',
  styleUrl: './form-page.css',
})
export class FormPage implements OnInit {
  registerForm!: FormGroup;

   registeredUser:any;

  @Output() onLoign = new EventEmitter<{status: boolean , user:any}>();


  registerSubmit(_user:any){
    this.onLoign.emit({status: true, user:  _user});
  }

  constructor() {}

  ngOnInit(): void {
    // Initialize the registerForm with its controls and validators
    this.registerForm = new FormGroup({
      name: new FormControl(null, [
        Validators.required,
        Validators.minLength(3),
        Validators.pattern(/^[a-zA-Z\s]*$/), // Allows letters and spaces
      ]),
      age: new FormControl(null, [
        Validators.required,
        Validators.min(18),
        Validators.pattern(/^[0-9]*$/), // Ensures age is a number
      ]),
      email: new FormControl(null, [Validators.required, Validators.email]),
      address: new FormControl(null, [
        Validators.required,
        Validators.minLength(5),
      ]),
    });
  }

  // Getters for easy access to form controls in the template
  get getName() {
    return this.registerForm.controls['name'];
  }
  get getAge() {
    return this.registerForm.controls['age'];
  }
  get getEmail() {
    return this.registerForm.controls['email'];
  }
  get getAddress() {
    return this.registerForm.controls['address'];
  }

  // Method to handle form submission for the register form
  onRegisterSubmit() {
    if (this.registerForm.status === 'VALID') {
      console.log('Register Form is VALID and submitted!');
      console.log(this.registerForm.value);
      this.registerSubmit(this.registerForm.value);

    } else {
      console.log('Register Form is INVALID. Please fix errors.');
      this.registerForm.markAllAsTouched();
    }
  }
}
