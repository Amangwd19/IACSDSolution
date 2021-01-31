import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import{Observable} from 'rxjs';
import{Product} from './product.model';

@Injectable({
  providedIn: 'root'
})
export class RestProductHubService {

  dotNetRestUrl:string="http://localhost:56728/api/products";


  //constructor dependency injection

  constructor(private http:HttpClient) { }
  //step 3
  
  //Asynchronous data arraival

  getAllProducts():Observable<Product>   //any
  { 
      //fetch data from  rest api
      return this.http.get<Product>(this.dotNetRestUrl); // from rest api
  }

  createProduct(product: object): Observable<object> {  
    return this.http.post(`${this.dotNetRestUrl}`, product);  
  }  
  
  deleteProduct(id: number): Observable<any> {  
    return this.http.delete(`${this.dotNetRestUrl}`, { responseType: 'text' });  
  }  
  
  getProduct(id: number): Observable<Object> {  
    return this.http.get(`${this.dotNetRestUrl}/${id}`);  
  }  
  
  updateProduct(id: number, value: any): Observable<Object> {  
    return this.http.post(`${this.dotNetRestUrl}/${id}`, value);  
  }  
}
