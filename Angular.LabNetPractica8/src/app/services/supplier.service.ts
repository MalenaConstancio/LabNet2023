import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Supplier,SupplierAdd } from '../interfaces/supplier';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  proveedores: Supplier[]=[];

  constructor(private http: HttpClient) { }

  getSuppliers(): Observable<Supplier[]>{
    return this.http.get<Supplier[]>('https://localhost:44362/api/Suppliers');
  }

  getSupplierById(id:Number):Observable<Supplier>{
    return this.http.get<Supplier>('https://localhost:44362/api/Suppliers'+'?Id='+id);
  }

  createSupplier(supplierAdd: SupplierAdd): Observable<SupplierAdd>{
    return this.http.post<SupplierAdd>('https://localhost:44362/api/Suppliers', supplierAdd);
     
  }

  editSupplier(supplierEdit: Supplier): Observable<Supplier>{
    return this.http.put<Supplier>('https://localhost:44362/api/Suppliers', supplierEdit);
  }

  deleteSupplier(id:Number):Observable<Supplier>{
    return this.http.delete<Supplier>('https://localhost:44362/api/Suppliers'+'?Id='+id);
  }

}
