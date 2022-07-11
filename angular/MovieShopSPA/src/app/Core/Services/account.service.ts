import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { Login } from 'src/app/Shared/Models/login';
import { Register } from 'src/app/Shared/Models/register';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from 'src/app/Shared/Models/user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  private currentUserSubject = new BehaviorSubject<any>({} as any);
  public currentUser = this.currentUserSubject.asObservable();

  private isLoggedInSubject = new BehaviorSubject<boolean>(false);
  public isLoggedIn = this.isLoggedInSubject.asObservable();

  private isAdminSubject = new BehaviorSubject<boolean>(false);
  public isAdmin = this.isAdminSubject.asObservable();

  jwtHelper = new JwtHelperService();

  constructor(private http:HttpClient) { }

  Login(login:Login):Observable<boolean>{
    return this.http.post('https://localhost:7194/api/Account/login', login).pipe(map((response:any) => {
      if (response){
        localStorage.setItem('token', response.token);
        this.populateUserInfoFromToken();
        return true;
      }
      return false;
    }))
  }

  Logout(){
    localStorage.removeItem('token');
    this.currentUserSubject.next({} as User);
    this.isLoggedInSubject.next(false);
    this.isAdminSubject.next(false);
  }

  Register(registration:Register):Observable<boolean>{
    return this.http.post<boolean>('https://localhost:7194/api/Account/register', registration);
  }

  populateUserInfoFromToken(){
    var tokenValue = localStorage.getItem('token');

    if(tokenValue && !this.jwtHelper.isTokenExpired(tokenValue)){
      const decodedToken = this.jwtHelper.decodeToken(tokenValue);

      this.currentUserSubject.next(decodedToken);
      this.isLoggedInSubject.next(true);
      this.isAdminSubject.next(decodedToken.isAdmin);
    };
  }

}