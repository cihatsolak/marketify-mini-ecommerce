import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { List_Product } from 'src/app/contracts/list_products';
import { Create_Product } from '../../../contracts/create_product';
import { HttpClientService } from '../http-client.service';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  constructor(private httpClientService: HttpClientService) { }

  create(product: Create_Product, successCallBack?: () => void, errorCallBack?: (errorMessage: string) => void) {
    this.httpClientService.post({
      controller: "products"
    }, product)
      .subscribe(result => {
        if(successCallBack){
          successCallBack();
        }
      }, (errorResponse: HttpErrorResponse) => {
        const _error: Array<{ key: string, value: Array<string> }> = errorResponse.error;
        let message = "";
        _error.forEach((v, index) => {
          v.value.forEach((_v, _index) => {
            message += `${_v}<br>`;
          });
        });
        if(errorCallBack){
          errorCallBack(message);
        }
      });
  }

  async read(page: number = 0, size: number = 5, successCallBack?: () => void, errorCallBack?: (errorMessage: string) => void): Promise<{ totalCount: number; products: List_Product[] }> {
    const promiseData: Promise<{ totalCount: number; products: List_Product[] }> = this.httpClientService.get<{ totalCount: number; products: List_Product[] }>({
      controller: "products",
      queryString: `page=${page}&size=${size}`
    }).toPromise() as Promise<{ totalCount: number; products: List_Product[] }>;

    promiseData.then(d => {
      if(successCallBack){
        successCallBack()
      }
    })
      .catch((errorResponse: HttpErrorResponse) => {
        if(errorCallBack){
          errorCallBack(errorResponse.message)
        }
      })

    return await promiseData;
  }
}