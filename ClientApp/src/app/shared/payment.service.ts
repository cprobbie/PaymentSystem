import { Injectable } from '@angular/core';
import { Payment } from './payment.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentService {
  formData: Payment;
  readonly rootURL = 'http://localhost:5000/api';

  constructor(private http: HttpClient) { }

  postPaymentDetail(formData: Payment) {
    return this.http.post(this.rootURL + '/payment', formData);
  }
}
