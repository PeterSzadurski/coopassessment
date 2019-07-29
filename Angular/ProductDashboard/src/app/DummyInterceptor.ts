/*// /https://www.youtube.com/watch?v=qnRrqH-BzJE
import {HttpInterceptor, HttpRequest, HttpHandler } from '@angular/common/http';
import { request } from 'http';
import { productClass } from './ProductClass';
export class DummyInterceptor implements HttpInterceptor {
   intercept(req: HttpRequest<"api">, next: HttpHandler){
       const newReq = req.clone({
           headers: req.headers.set(
            "httpInterceptor", "DummyInterceptor"

           )
       })
       return next.handle(req);
   }
    
}*/