import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarDetailDto } from 'src/app/models/carDetailDto';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {

  currentCar:CarDetailDto;
  
  constructor(
    private carService:CarService, 
    private activatedRoute:ActivatedRoute) { }

  ngOnInit(): void {
    this.getCarDetail();
  }

  getCarDetail(){
    const carId = this.activatedRoute.snapshot.paramMap.get('carId')?.toString();
    this.carService.getCarDetail(Number(carId)).subscribe(response => {
      this.currentCar = response.data
    })

  }
}
