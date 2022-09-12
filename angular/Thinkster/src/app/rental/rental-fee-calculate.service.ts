import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RentalFeeCalculateService {

  constructor() { }

   CalculateRentalFee(): number{
    return 2.99;
  }
}
