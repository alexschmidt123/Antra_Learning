import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule, NgForm } from '@angular/forms';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { RegisterValidationServiceService } from 'src/app/Core/Custom-Validators/register-validation-service.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  //registration:Register;
  registerForm: FormGroup;
  submitted:boolean=false;
  constructor(private fb:FormBuilder, private customValidator:RegisterValidationServiceService) { }

  ngOnInit(): void {
    this.registerForm = this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.compose([Validators.required, this.customValidator.patternValidator()])],
      confirmPassword: ['', Validators.required],
      dateOfBirth: ['', Validators.required],
    },
    {
      validator: this.customValidator.MatchPassword('Password', 'confirmPassword'),
    });
  }

  get registerFormControl(){
      return this.registerForm.controls;
  }

  onSubmit(){
    this.submitted = true;
    if (this.registerForm.valid){
      alert('Form Submitted Successfully!');
      console.table(this.registerForm.value);
      //this.registerService.Register(this.registerForm);
    }
  }

}
