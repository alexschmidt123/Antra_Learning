import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/Shared/Models/user';
import { AccountService } from '../../Services/account.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  isAdmin:boolean = false;
  isLoggedIn:boolean = false;
  currentUser:User;
  constructor(private accountService:AccountService, private _router:Router) { }

  ngOnInit(): void {
    this.accountService.isLoggedIn.subscribe(data => {
      this.isLoggedIn = data;
    });
    this.accountService.currentUser.subscribe(data => {
      this.currentUser = data;
      //this.isAdmin = data.isAdmin.value;
      console.log(this.currentUser);
      //console.log(this.isAdmin);
    });
    this.accountService.isAdmin.subscribe(data=>{
      this.isAdmin = data;
      console.log(this.isAdmin);
    });
  }

  Logout(){
    this.accountService.Logout();
    this._router.navigateByUrl('/');
  }

}