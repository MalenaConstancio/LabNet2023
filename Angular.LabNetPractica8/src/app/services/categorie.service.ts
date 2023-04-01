import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Categorie } from '../interfaces/categorie';

@Injectable({
  providedIn: 'root'
})
export class CategorieService {

  categorias: Categorie[]=[];

  constructor(private http: HttpClient) {}

  getCategories(): Observable<Categorie[]>{
    return this.http.get<Categorie[]>('https://localhost:44362/api/Categories');
  }

}
