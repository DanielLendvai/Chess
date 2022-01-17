import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Dolgozo } from './dolgozo.model';
import { Observable } from  'rxjs';
import { HttpHeaders } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json',
    Authorization: 'my-auth-token'
  })
};

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private REST_API_SERVER = "http://localhost:3000";

  constructor(private httpClient: HttpClient) { }

  dolgozok(): Observable<Dolgozo[]>
  {
    return this.httpClient.get<Dolgozo[]>("api/dolgozok.php");
  }

  login(uid: string, pwd: string): Observable<Dolgozo>
  {
      return this.httpClient.post<Dolgozo>('api/login.php', { uid: uid, pwd: pwd }, httpOptions).pipe();
  }

  logoff(): void
  {
      this.httpClient.get('api/logout');
  }
}
