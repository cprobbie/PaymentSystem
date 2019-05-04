import { Component, OnInit } from '@angular/core';
import { PaymentService } from 'src/app/shared/payment.service';
import { NgForm } from '@angular/forms';

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
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form = null) {
      form.resetForm();
    }
    this.service.formData = {
      PaymentId: 0,
      Amount: null,
      CreatedOn: null,
      PaymentType: '',
      ProcessingFee: 0,
      SettlementAmount: 0
    }
  }
  onSubmit(form: NgForm) {
    this.service.postPaymentDetail(form.value).subscribe(
      res => {
        this.resetForm(form);
      },
      err => {
        console.log(err);
      }
    );
  }
}
