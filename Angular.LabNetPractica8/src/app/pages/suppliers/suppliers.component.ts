import { Component, OnInit } from '@angular/core';
import { SupplierService } from 'src/app/services/supplier.service';
import { Supplier,SupplierAdd } from 'src/app/interfaces/supplier';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';

import Swal from 'sweetalert2';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.scss']
})
export class SuppliersComponent implements OnInit {

  proveedores: Supplier[]=[];

  proveedor ={
    IdProveedor:0,
    NombreProveedor:'',
    CiudadProveedor:'',
    TelefonoProveedor:''
  }

  frmAgregar!:FormGroup;
  frmEditar!:FormGroup;
  frmEliminar!:FormGroup;

  constructor(private supplierService:SupplierService,private fb:FormBuilder) { 
    this.frmAgregar=this.fb.group({
      NombreProveedor:['',[Validators.required,Validators.maxLength(30)]],
      CiudadProveedor:['',[Validators.required,Validators.maxLength(15)]],
      TelefonoProveedor:['',[Validators.required,Validators.maxLength(24)]]
    })
    this.frmEditar=this.fb.group({
      IdProveedor:['',Validators.required],
      NombreProveedor:['',[Validators.required,Validators.maxLength(30)]],
      CiudadProveedor:['',[Validators.required,Validators.maxLength(15)]],
      TelefonoProveedor:['',[Validators.required,Validators.maxLength(24)]]
    })
    this.frmEliminar=this.fb.group({
      IdProveedor:['',Validators.required]
    })
    
  }

  getSuppliers(){
    this.supplierService.getSuppliers().subscribe({
      next:Response=> this.proveedores=Response,
      error: err=> Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Error en el servidor!',
      })
    });
  }

  addSupplier(){
    this.supplierService.createSupplier({
      NombreProveedor:this.frmAgregar.value.NombreProveedor,
      CiudadProveedor:this.frmAgregar.value.CiudadProveedor,
      TelefonoProveedor:this.frmAgregar.value.TelefonoProveedor
    }).subscribe({next:()=> {this.getSuppliers()},
    error: err=>{
      Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Error en el servidor!',
      });
      this.limpiarCamposAgregar();
    },
    complete:()=>{
      Swal.fire({
        icon: 'success',
        title: 'Operación exitosa',
        text: this.frmAgregar.value.NombreProveedor+' ha sido agregado',
      });
      this.limpiarCamposAgregar();
     
    }
  });
  }

  editSupplier(){

    let nombre:string = this.proveedor.NombreProveedor
    let ciudad:string= this.proveedor.CiudadProveedor
    let telefono:string=this.proveedor.TelefonoProveedor
    
    if(this.frmEditar.value.NombreProveedor!=''){
      nombre=this.frmEditar.value.NombreProveedor
    }
    if(this.frmEditar.value.CiudadProveedor!=''){
      ciudad=this.frmEditar.value.CiudadProveedor
    }
    if(this.frmEditar.value.TelefonoProveedor!=''){
      telefono=this.frmEditar.value.TelefonoProveedor
    }

    const proveedorEdit :Supplier={
      IdProveedor:this.proveedor.IdProveedor,
      NombreProveedor:nombre,
      CiudadProveedor:ciudad,
      TelefonoProveedor:telefono
      }

    this.supplierService.editSupplier(
      proveedorEdit
    ).subscribe({next:()=> {this.getSuppliers()},
    error: err=>{
      Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Error en el servidor!',
      });
      this.limpiarCamposAgregar();
    },
    complete:()=>{
      Swal.fire({
        icon: 'success',
        title: 'Operación exitosa',
        text: this.frmEditar.value.NombreProveedor+' ha sido modificado',
      });
      this.limpiarCamposAgregar();
     
    }
  });
  }

  deleteSupplier(Id:Number){
    this.supplierService.deleteSupplier(this.proveedor.IdProveedor).subscribe({
    next:()=>{this.getSuppliers()},
  error: err=>{
    Swal.fire({
      icon: 'error',
      title: 'Operación inválida',
      text: 'No se pueden eliminar Proveedores con Productos asignados',
    });
  },
  complete:()=>{
    Swal.fire({
      icon: 'success',
      title: 'Operación exitosa',
      text: 'El Proveedor ha sido eliminada',
    });
  }
  });
  }

  traeProveedor(id:Number){
    this.supplierService.getSupplierById(id).subscribe(
      data=> this.proveedor = { IdProveedor:data.IdProveedor , NombreProveedor:data.NombreProveedor, 
        CiudadProveedor:data.CiudadProveedor,TelefonoProveedor:data.TelefonoProveedor})
    }

  limpiarCamposAgregar(){
    this.frmAgregar.get('NombreProveedor')?.reset('');
    this.frmAgregar.get('DescripcionProveedor')?.reset('');
    this.frmAgregar.get('CiudadProveedor')?.reset('');
    this.frmAgregar.get('TelefonoProveedor')?.reset('');
  }

  ngOnInit(): void {

    this.getSuppliers();
  }

}
