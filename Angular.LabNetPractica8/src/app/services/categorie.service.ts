import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Categorie,CategorieAdd } from '../interfaces/categorie';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})

export class CategorieService {

  categorias: Categorie[]=[];

  constructor(private http: HttpClient) {}

  getCategories(): Observable<Categorie[]>{
    return this.http.get<Categorie[]>('https://localhost:44362/api/Categories');
  }

  getCategorieById(id:Number):Observable<Categorie>{
    return this.http.get<Categorie>('https://localhost:44362/api/Categories'+'?Id='+id);
  }

  createCategorie(categorieAdd: CategorieAdd): Observable<CategorieAdd>{
    return this.http.post<CategorieAdd>('https://localhost:44362/api/Categories', categorieAdd);
     
  }

  editCategorie(categorieEdit: Categorie): Observable<Categorie>{
    return this.http.put<Categorie>('https://localhost:44362/api/Categories', categorieEdit);
  }

  deleteCategorie(id:Number):Observable<Categorie>{
    return this.http.delete<Categorie>('https://localhost:44362/api/Categories'+'?Id='+id);
  }

}
