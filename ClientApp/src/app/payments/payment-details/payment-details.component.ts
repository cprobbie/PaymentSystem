import { Component, OnInit } from '@angular/core';
import { PaymentService } from 'src/app/shared/payment.service';

export interface PaymentType {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-payment-details',
  templateUrl: './payment-details.component.html',
  styles: []
})
export class PaymentDetailsComponent implements OnInit {

  constructor(private service: PaymentService) { }

  ngOnInit() {
  }

}
