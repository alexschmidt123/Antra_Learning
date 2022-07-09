import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/Shared/Models/login';
import { AccountService } from 'src/app/Core/Services/account.service';
import { NgForm, FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  flag:boolean=false;
  failed:boolean=false;
  email:string;
  password:string;
  user:Login = {
    email: "",
    password: ""
  };

  constructor(private loginService:AccountService, private _router:Router) { }

  ngOnInit(): void {
  }

  loginUser(loginForm:NgForm){
    this.user.email = loginForm.value.email;
    this.user.password = loginForm.value.password;
    this.loginService.Login(this.user).subscribe(data => {
      if (data){
        this.flag = true;
        setTimeout(() => {
          this._router.navigateByUrl('/');
        }, 1000); 
      } else {
        this.failed = true;
      };
    });
  }

}