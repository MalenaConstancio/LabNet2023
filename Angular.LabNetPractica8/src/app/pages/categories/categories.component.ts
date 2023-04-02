import { Component, OnInit } from '@angular/core';
import { Categorie ,CategorieAdd} from 'src/app/interfaces/categorie';
import { CategorieService } from 'src/app/services/categorie.service';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';

import Swal from 'sweetalert2';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})


export class CategoriesComponent implements OnInit {
  
  categorias: Categorie[]=[];
 
  categoria ={
    IdCategoria:0,
    NombreCategoria:'',
    DescripcionCategoria:''
  }

  frmAgregar!:FormGroup;
  frmEditar!:FormGroup;
  frmEliminar!:FormGroup;

  constructor(
    private categorieService:CategorieService,
    private fb:FormBuilder
    ) { 
        this.frmAgregar=this.fb.group({
          NombreCategoria:['',[Validators.required,Validators.maxLength(15)]],
          DescripcionCategoria:['',Validators.required]
        })
        this.frmEditar=this.fb.group({
          IdCategoria:['',Validators.required],
          NombreCategoria:['',[Validators.required,Validators.maxLength(15)]],
          DescripcionCategoria:['',Validators.required]
        })
        this.frmEliminar=this.fb.group({
          IdCategoria:['',Validators.required]
        })
  }

  getCategories(){
    this.categorieService.getCategories().subscribe({
      next:Response=> this.categorias=Response,
      error: err=> Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Error en el servidor!',
      })
    });
  }

  addCategorie(){
    this.categorieService.createCategorie({
      NombreCategoria:this.frmAgregar.value.NombreCategoria,
      DescripcionCategoria:this.frmAgregar.value.DescripcionCategoria
    }).subscribe({next:()=> {this.getCategories()},
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
        text: this.frmAgregar.value.NombreCategoria+' ha sido agregada',
      });
      this.limpiarCamposAgregar();
     
    }
  });
  }

  editCategorie(){

    let nombre:string = this.categoria.NombreCategoria
    let descripcion:string= this.categoria.DescripcionCategoria
    
    if(this.frmEditar.value.NombreCategoria!=''){
      nombre=this.frmEditar.value.NombreCategoria
    }
    if(this.frmEditar.value.DescripcionCategoria!=''){
      descripcion=this.frmEditar.value.DescripcionCategoria
    }

    const categoriaEdit :Categorie={
      IdCategoria:this.categoria.IdCategoria,
      NombreCategoria:nombre,
      DescripcionCategoria:descripcion}

    this.categorieService.editCategorie(
      categoriaEdit
    ).subscribe({next:()=> {this.getCategories()},
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
        text: this.frmEditar.value.NombreCategoria+' ha sido modificada',
      });
      this.limpiarCamposAgregar();
     
    }
  });
  }


  deleteCategorie(Id:Number){
    this.categorieService.deleteCategorie(this.categoria.IdCategoria).subscribe({
    next:()=>{this.getCategories()},
  error: err=>{
    Swal.fire({
      icon: 'error',
      title: 'Operación inválida',
      text: 'No se pueden eliminar Categorias con Productos asignados',
    });
  },
  complete:()=>{
    Swal.fire({
      icon: 'success',
      title: 'Operación exitosa',
      text: 'La Categoria ha sido eliminada',
    });
  }
  });
  }

  traerCategoria(id:Number){
  this.categorieService.getCategorieById(id).subscribe(
    data=> this.categoria = { IdCategoria:data.IdCategoria , NombreCategoria:data.NombreCategoria, DescripcionCategoria:data.DescripcionCategoria})
  }
  
  limpiarCamposAgregar(){
    this.frmAgregar.get('NombreCategoria')?.reset('');
    this.frmAgregar.get('DescripcionCategoria')?.reset('');
  }

  ngOnInit(): void {
    this.getCategories();
  }

}
