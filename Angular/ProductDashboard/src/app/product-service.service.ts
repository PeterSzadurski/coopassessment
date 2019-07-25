//angular crud guide:
// https://www.c-sharpcorner.com/article/crud-operation-using-web-api-and-angular-7/
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';    
import {HttpHeaders} from '@angular/common/http'; 
import { observable, Observable } from 'rxjs';
import { productClass } from './ProductClass';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {
  Url = "http://localhost:4201/api/";
  constructor(private http:HttpClient) {}
  getProduct():Observable<productClass[]>{
  const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };  
      return this.http.get<productClass[]>(this.Url + "/product/GetAll");
    }
    DeleteProduct(ProductID:number):Observable<number>    
    {    
      return this.http.get<number>(this.Url + '/produvt/DeleteProduct?ProductId='+ProductID);    
    }
    getProductById(ProductID: number): Observable<productClass> {    
      return this.http.get<productClass>(this.Url + '/product/GetProduct?ProductId=' + ProductID);    
    }
    edit(ProductID: number): Observable<productClass> {    
      return this.http.get<productClass>(this.Url + '/product/Edit?ProductId=' + ProductID);    
    }    
    addProduct(OutletVM:productClass):Observable<productClass[]>    
    {    
     const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };    
      return this.http.post<productClass[]>(this.Url + '/product/Add/', OutletVM, httpOptions)    
    }    
   
}
