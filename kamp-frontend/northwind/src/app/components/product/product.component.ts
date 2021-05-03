import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { from } from 'rxjs';
import { Product } from 'src/app/models/product';
import { CartService } from 'src/app/services/cart.service';
import { ProductService } from 'src/app/services/product.service';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
  
})


export class ProductComponent implements OnInit {

  products:Product[] = [];
  
  dataLoaded = false;
  filterText = "";

  constructor(private producService : ProductService, 
    private activatedRoot:ActivatedRoute,
    private toastrService:ToastrService,
    private cartService:CartService) { }

  ngOnInit(): void {
    this.activatedRoot.params.subscribe(params =>{
      if(params["categoryId"]){
        this.getProductsByCategory(params["categoryId"])
      }else{
        this.getProducts();
      }
    })  
}

  getProducts(){
    this.producService.getProducts()
    .subscribe(response => {
      this.products = response.data 
      this.dataLoaded = true; 
    }); 
  }

  getProductsByCategory(categoryId:number){
    this.producService.getProductsByCategory(categoryId)
    .subscribe(response => {
      this.products = response.data 
      this.dataLoaded = true; 
    });
  }

  addToCart(product: Product){
    if(product.productId === 1){
      this.toastrService.error("The product cannot be added to the cart", product.productName)
    }else{
      this.toastrService.success("The product is added to cart.", product.productName)
      this.cartService.addToCart(product);
    }
  }

}
