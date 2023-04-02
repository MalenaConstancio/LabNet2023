import { Component, OnInit } from '@angular/core';
import { SupplierService } from 'src/app/services/supplier.service';
import { Supplier } from 'src/app/interfaces/supplier';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.scss']
})
export class SuppliersComponent implements OnInit {

  proveedores: Supplier[]=[];
  constructor(private supplierService:SupplierService) { }

  ngOnInit(): void {

    this.supplierService.getSuppliers().subscribe(data=>{
      this.proveedores=data;
    });
  }

}
