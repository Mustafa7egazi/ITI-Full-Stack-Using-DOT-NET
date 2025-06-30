import { IProduct } from './../models/IProductContract';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class StaticProductService {
  products: IProduct[] = [];
  constructor() {
    this.products = [
      {
        id: '6',
        name: 'Mechanical Keyboard (RGB)',
        price: 89.95,
        quantity: 40,
        imgSrc: 'https://placehold.co/400x300/909090/888888?text=Keyboard',
      },
      {
        id: '7',
        name: 'Noise-Cancelling Headphones',
        price: 199.0,
        quantity: 25,
        imgSrc: 'https://placehold.co/400x300/808080/777777?text=Headphones',
      },
      {
        id: '8',
        name: 'Portable Bluetooth Speaker',
        price: 65.0,
        quantity: 70,
        imgSrc: 'https://placehold.co/400x300/707070/666666?text=Speaker',
      },
      {
        id: '9',
        name: 'USB-C Hub Multiport Adapter',
        price: 35.75,
        quantity: 90,
        imgSrc: 'https://placehold.co/400x300/606060/555555?text=USB+Hub',
      },
      {
        id: '10',
        name: 'External SSD 1TB',
        price: 95.5,
        quantity: 35,
        imgSrc: 'https://placehold.co/400x300/505050/444444?text=SSD',
      },
    ];
  }

  getAllProducts(): IProduct[] {
    return this.products;
  }

  getProductById(productId: string | null): IProduct | undefined {
    return this.products.find((product) => product.id == productId);
  }

  addNewProduct(product: any): IProduct[] {
    this.products.push(product);
    return this.products;
  }
  editProduct(product:IProduct , newProduct:IProduct): IProduct[] {
    const index = this.products.indexOf(product);
    this.products[index] = newProduct;
    return this.products;
  }

  //deleteProduct(productId: string | null) {}
}
