
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';

import { Observable } from 'rxjs';
import { ProductServiceService } from '../product-service.service';
import { productClass } from '../ProductClass';
import { Component, OnInit } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
@Component({
  selector: 'app-product-component',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  datasaved = false;
  message : string;
  FromProduct: any;
  ProductID: number = 0;
  GetAll: Observable<productClass[]>;
  constructor(private formbulider: FormBuilder, private productservice : ProductServiceService) {}
  GetProduct() {
    this.GetAll = this.productservice.getProduct();
  }
  AddProduct(prod:productClass) {
    prod.ProductId = this.ProductID;
    this.productservice.addProduct(prod).subscribe(
      () => {
        this.datasaved = true;
        this.message = "Recorded";
        this.GetProduct();
        this.ProductID = 0;
      }
    );
  }
  DeleteStudent(ProductID: number) {  
    if (confirm("Are You Sure To Delete this Informations")) {  
     this.productservice.DeleteProduct(ProductID).subscribe(  
      () => {  
       this.datasaved = true;  
       this.message = "Deleted Successfully";  
       this.GetProduct();  
      }  
     );  
    }  
   }
   
   StudentEdit(productId: number) {  
    this.productservice.getProductById(productId).subscribe(Response => {  
     this.message = null;  
     this.datasaved = false;  
     this.ProductID = Response.ProductId;  
     this.FromProduct.controls['Name'].setValue(Response.Name);  
     this.FromProduct.controls['Description'].setValue(Response.Description);  
     this.FromProduct.controls['Price'].setValue(Response.Price);  

    });  
   }  
  

  ngOnInit(): void {
    this.FromProduct = this.formbulider.group({  
      ProductId: ['', [Validators.required]],  
      Name: ['', [Validators.required]],  
      Description: ['', [Validators.required]],  
      Price: ['', [Validators.required]],  
     });  
     this.GetProduct();  
  }
}



