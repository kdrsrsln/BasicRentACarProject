import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarImage } from 'src/app/models/car-image';
import { CarDetailDto } from 'src/app/models/carDetailDto';
import { CarImageService } from 'src/app/services/car-image.service';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {

  currentCar:CarDetailDto;
  carImages:CarImage[];
  
  constructor(
    private carService:CarService,
    private carImageService:CarImageService, 
    private activatedRoute:ActivatedRoute) { }

  ngOnInit(): void {
    this.getCarDetail();
    this.getCarImages();
  }

  getCarDetail(){
    const carId = this.activatedRoute.snapshot.paramMap.get('carId')?.toString();
    this.carService.getCarDetail(Number(carId)).subscribe(response => {
      this.currentCar = response.data
    })
  }

  getCarImages(){
    const carId = this.activatedRoute.snapshot.paramMap.get('carId')?.toString();
    this.carImageService.getCarImages(Number(carId)).subscribe(response => {
      this.carImages = response.data;

      console.log(response.data)
    })
  }

}
