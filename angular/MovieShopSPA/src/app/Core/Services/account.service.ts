import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Login } from 'src/app/Shared/Models/login';
import { Register } from 'src/app/Shared/Models/register';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(private http:HttpClient) { }

  Login(login:Login):Observable<boolean>{
    return this.http.post('https://localhost:7194/api/Account/login', login).pipe(map((response:any) => {
      if (response){
        localStorage.setItem('token', response.token);
        return true;
      }
      return false;
    }))
  }

  Logout(){
    localStorage.removeItem('token');
  }

  Register(registration:Register):Observable<boolean>{
    return this.http.post<boolean>('https://localhost:7194/api/Account/register', registration);
  }

}