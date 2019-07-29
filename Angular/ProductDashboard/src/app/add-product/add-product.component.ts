import { Component, OnInit } from '@angular/core';
import { productClass } from '../ProductClass';
import { Observable } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductServiceService } from '../product-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {
  datasaved = false;
  message : string;
  FromProduct: any;
  ProductID: number = 0;
  GetAll: Observable<productClass[]>;
  constructor(private formbulider: FormBuilder, private productservice : ProductServiceService, private router: Router) {}

  GetProduct() {
    this.GetAll = this.productservice.getProduct();
  }

  AddProduct(prod:productClass) {
    prod.ProductID = this.ProductID;
    this.productservice.addProduct(prod).subscribe(
      () => {
        this.datasaved = true;
        this.message = "Recorded";
        this.GetProduct();
        this.ProductID = 0;
      }
    );
    alert ("Added Successfully");
    //https://stackoverflow.com/questions/53569884/angular-router-navigate-then-reload  
    this.router.navigate(['']) .then(() => {
      window.location.reload();
    });
  }


  ngOnInit() {
    this.FromProduct = this.formbulider.group({  
      ProductID: ['', [Validators.required]],  
      Name: ['', [Validators.required]],  
      Description: ['', [Validators.required]],  
      Price: ['', [Validators.required]],  
     });  
     this.GetProduct();  
  }
  }


