import { Component, OnInit } from '@angular/core';
import { Shared } from '../../shared/shared';
import { StaticProductService } from '../../services/static-product-service';
import { IProduct } from '../../models/IProductContract';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-product-details',
  imports: [Shared, RouterLink , CurrencyPipe],
  templateUrl: './product-details.html',
  styleUrl: './product-details.css',
})
export class ProductDetails implements OnInit {
  product?: IProduct;
  productId!: string | null;

  constructor(
    private productService: StaticProductService,
    private activatedRoute: ActivatedRoute
  ) {}
  ngOnInit(): void {
    this.productId = this.activatedRoute.snapshot.paramMap.get('id');
    this.product = this.productService.getProductById(this.productId);
  }
}
