import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { StaticProductService } from '../../services/static-product-service';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';

interface IProduct {
  id: string;
  name: string;
  price: number;
  quantity: number;
  imgSrc?: string;
}

@Component({
  selector: 'app-product-form',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './product-form.html',
  styleUrl: './product-form.css',
})
export class ProductForm implements OnInit {
  productId: string | null = null;
  productToEdit: IProduct | undefined;
  buttonText: string = 'Add new Product';
  isAddingNewProduct: boolean = true;

  constructor(
    private productService: StaticProductService,
    private router: Router,
    private activeRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.productId = this.activeRoute.snapshot.paramMap.get('id');

    if (this.productId && parseInt(this.productId) > 0) {
      this.productToEdit = this.productService.getProductById(this.productId);

      if (this.productToEdit) {
        this.isAddingNewProduct = false;
        this.buttonText = 'Update Product';
        this.productForm.patchValue({
          name: this.productToEdit.name,
          price: this.productToEdit.price,
          quantity: this.productToEdit.quantity,
          imgSrc: this.productToEdit.imgSrc || '',
        });
      } else {
        console.warn(
          `Product with ID ${this.productId} not found for editing.`
        );
        this.router.navigate(['/products/add']);
      }
    } else {
      this.buttonText = 'Add new Product';
    }
  }

  productForm = new FormGroup({
    name: new FormControl<string>('', [
      Validators.required,
      Validators.minLength(3),
    ]),
    price: new FormControl<number | null>(null, Validators.required),
    quantity: new FormControl<number | null>(null, Validators.required),
    imgSrc: new FormControl<string | null>(''),
  });

  get getName() {
    return this.productForm.controls['name'];
  }
  get getPrice() {
    return this.productForm.controls['price'];
  }
  get getQuantity() {
    return this.productForm.controls['quantity'];
  }

  addNewProduct() {
    if (this.productForm.status === 'VALID') {
      const id = (this.productService.products.length + 1).toString();

      const formValue = this.productForm.value;
      let product: IProduct = {
        id,
        name: formValue.name!,
        price: formValue.price!,
        quantity: formValue.quantity!,
        imgSrc: formValue.imgSrc || undefined,
      };

      this.productService.addNewProduct(product);
      this.router.navigate(['/products']);
    } else {
      console.log('Form is invalid. Please fix errors.');
      this.productForm.markAllAsTouched();
    }
  }

  saveProduct(): void {
    if (this.productForm.status === 'VALID') {
      const formValue = this.productForm.value;

      let product: IProduct = {
        id:
          this.productId ||
          (this.productService.products.length + 1).toString(),
        name: formValue.name!,
        price: Number(formValue.price),
        quantity: Number(formValue.quantity),
        imgSrc: formValue.imgSrc || undefined,
      };

      if (this.productId && parseInt(this.productId) > 0) {
        this.productService.editProduct(this.productToEdit!, product);
        console.log('Product updated:', product);
      } else {
        this.productService.addNewProduct(product);
        console.log('New product added:', product);
      }

      this.router.navigate(['/products']);
    } else {
      console.log('Form is invalid. Please fix errors.');
      this.productForm.markAllAsTouched();
    }
  }
}
