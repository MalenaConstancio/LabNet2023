import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Supplier } from '../interfaces/supplier';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  proveedores: Supplier[]=[];

  constructor(private http: HttpClient) { }

  getSuppliers(): Observable<Supplier[]>{
    return this.http.get<Supplier[]>('https://localhost:44362/api/Suppliers');
  }
}
