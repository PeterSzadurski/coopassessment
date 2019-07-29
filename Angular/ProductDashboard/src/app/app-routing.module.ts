import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddProductComponent } from './add-product/add-product.component';
import { ProductComponent } from './product-component/product.component';


export const routes: Routes = [
  {path: '', component: ProductComponent}
  ,{path: 'add-product', component: AddProductComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
