import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarDetailComponent } from './components/car-detail/car-detail.component';
import { CarComponent } from './components/car/car.component';
import { RentalComponent } from './components/rental/rental.component';

const routes: Routes = [
  {path: "",pathMatch:"full", component:RentalComponent},
  {path: "cars", component:CarComponent},
  {path: "cars/brands/:brandId", component:CarComponent},
  {path: "cars/colors/:colorId", component:CarComponent},
  {path: "car-detail/:carId", component:CarDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
