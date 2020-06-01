import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProduct } from '../Models/IProduct';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  private pruductUrl = 'https://localhost:44301/api/product';  // URL to web api

  constructor(
    private http: HttpClient,
  ) { }

  getHeroes(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(this.pruductUrl);
  }
}
