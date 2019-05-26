import { Injectable } from '@angular/core';
import { Payment } from './payment.model';
import { PaymentDetailsModel } from './paymentDetails.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentService {
  formData: Payment;
  viewModel: PaymentDetailsModel;
  readonly rootURL = 'http://localhost:5000/api';
  list: PaymentDetailsModel[];

  constructor(private http: HttpClient) { }

  postPaymentDetail(formData: Payment) {
    return this.http.post(this.rootURL + '/payment', formData, { responseType: 'text' });
  }

  refreshList() {
    this.http.get(this.rootURL + '/payment')
      .toPromise()
      .then(res => this.list = res as PaymentDetailsModel[]);
  }
}
