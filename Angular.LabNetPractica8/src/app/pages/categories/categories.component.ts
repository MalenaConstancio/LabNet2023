import { Component, OnInit } from '@angular/core';
import { Categorie } from 'src/app/interfaces/categorie';
import { CategorieService } from 'src/app/services/categorie.service';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';


@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})


export class CategoriesComponent implements OnInit {
  
  categorias: Categorie[]=[];
  resultado='';
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

  onSubmit(){
    if (this.frmAgregar.valid)
      this.resultado = "Todos los datos son válidos";
    else
      this.resultado = "Hay datos inválidos en el formulario";
  }

  ngOnInit(): void {
    this.categorieService.getCategories().subscribe(data=>{
      this.categorias=data;
    });
  }

}
