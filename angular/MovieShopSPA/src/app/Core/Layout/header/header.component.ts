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

  isLoggedIn:boolean = false;
  currentUser:User;
  constructor(private accountService:AccountService, private _router:Router) { }

  ngOnInit(): void {
    this.accountService.isLoggedIn.subscribe(data => {
      this.isLoggedIn = data;
    });
    this.accountService.currentUser.subscribe(data => {
      this.currentUser = data;
    });
  }

  Logout(){
    this.accountService.Logout();
    this._router.navigateByUrl('/');
  }

}