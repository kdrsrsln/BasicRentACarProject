import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { ListResponseModel } from '../models/listResponseModel';
import { Observable } from 'rxjs';
import { CarDetailDto } from '../models/carDetailDto';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl = "https://localhost:44319/api/";

  constructor(private httpClient:HttpClient) { }

  getCars():Observable<ListResponseModel<CarDetailDto>>{
    let newPath = this.apiUrl + "cars/cardetaildto"
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }

  getCarsByBrand(brandId:number):Observable<ListResponseModel<CarDetailDto>>{
    let newPath = this.apiUrl + "cars/getAllCarDetailsByBrand?brandId="+brandId
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }

  getCarsByColor(colorId:number):Observable<ListResponseModel<CarDetailDto>>{
    let newPath = this.apiUrl + "cars/getAllCarDetailsByColor?colorId="+colorId
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }
}
