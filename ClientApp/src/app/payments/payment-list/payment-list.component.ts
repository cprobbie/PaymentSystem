import { Component, OnInit } from '@angular/core';
import { PaymentService } from 'src/app/shared/payment.service';

@Component({
  selector: 'app-payment-list',
  templateUrl: './payment-list.component.html',
  styles: []
})
export class PaymentListComponent implements OnInit {

  constructor(private service: PaymentService) { }

  ngOnInit() {
    this.service.refreshList();
  }

}
