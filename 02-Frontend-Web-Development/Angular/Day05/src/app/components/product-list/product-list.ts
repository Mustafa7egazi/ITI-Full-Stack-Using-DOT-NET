import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { StaticProductService } from '../../services/static-product-service';
import { IProduct } from '../../models/IProductContract';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-product-list',
  imports: [RouterLink, CurrencyPipe],
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductList implements OnInit {
  products: IProduct[] = [];
  constructor(private productService: StaticProductService) {}
  ngOnInit(): void {
    this.products = this.productService.getAllProducts();
  }
  deleteProduct(productId: string) {
    this.products = this.products.filter((product) => product.id !== productId);
  }
}
