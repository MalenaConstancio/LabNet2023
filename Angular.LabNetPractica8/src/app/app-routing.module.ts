import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesComponent } from './pages/categories/categories.component';
import { HomeComponent} from './pages/home/home.component';
import { SuppliersComponent } from './pages/suppliers/suppliers.component';
 

const routes: Routes = [
{path:'home',component:HomeComponent},
{path:'categories',component:CategoriesComponent},
{path:'suppliers',component:SuppliersComponent},
{path:'**',pathMatch: 'full',redirectTo:'/home'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
