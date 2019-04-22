import { Injectable } from '@angular/core';
import { Payment } from './payment.model';

@Injectable({
  providedIn: 'root'
})
export class PaymentService {
  formData: Payment

  constructor() { }
}
