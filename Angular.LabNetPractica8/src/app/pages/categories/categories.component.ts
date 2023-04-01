import { Component, OnInit } from '@angular/core';
import { Categorie } from 'src/app/interfaces/categorie';
import { CategorieService } from 'src/app/services/categorie.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})


export class CategoriesComponent implements OnInit {
  
  categorias: Categorie[]=[];

  constructor(private categorieService:CategorieService) { }

  ngOnInit(): void {
    this.categorieService.getCategories().subscribe(data=>{
      this.categorias=data;
    });
  }

}
