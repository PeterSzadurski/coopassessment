
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';

import { Observable } from 'rxjs';
import { ProductServiceService } from '../product-service.service';
import { productClass } from '../ProductClass';
import { Component, OnInit } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
import {Router} from '@angular/router'
import { AppModule } from '../app.module';
import { async } from 'q';
@Component({
  selector: 'app-product-component',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  datasaved = false;
  message : string;
  FromProduct: any;
  prod : productClass;
  ProductID: number = 0;
  GetAll: Observable<productClass[]>;
  constructor(private formbulider: FormBuilder, private productservice : ProductServiceService, private router: Router) {}
  GetProduct() {
    this.GetAll = this.productservice.getProduct();
  }
  GetProductById(i: number){
    var test;
    this.productservice.getProductById(1).subscribe(productClass =>  {
      test = productClass.Name;
    });
    console.log(test);
    //this.productservice.getProductById(i);

  }
  gotoAddProduct(){
    this.router.navigate(['add-product']);  
  }
  DeleteProduct(ProductID: number) {  
    if (confirm("Are You Sure To Delete this Information")) {  
     this.productservice.DeleteProduct(ProductID).subscribe(  
      () => {  
       this.datasaved = true;  
       
       this.GetProduct();  
      }  
     );  
    }  
   }
   
   ProductEdit(ProductID: number) {  
    this.productservice.getProductById(ProductID).subscribe(Response => {  
     this.message = null;  
     this.datasaved = false;  
     this.ProductID = Response.ProductID;  
     this.FromProduct.controls['Name'].setValue(Response.Name);  
     this.FromProduct.controls['Description'].setValue(Response.Description);  
     this.FromProduct.controls['Price'].setValue(Response.Price);  

    });  
   }  
  

  ngOnInit(): void {
    this.FromProduct = this.formbulider.group({  
      ProductID: ['', [Validators.required]],  
      Name: ['', [Validators.required]],  
      Description: ['', [Validators.required]],  
      Price: ['', [Validators.required]],  
     });  
     this.GetProduct();  
     
  }
}



