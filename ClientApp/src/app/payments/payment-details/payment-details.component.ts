import { Component, OnInit } from '@angular/core';
import { PaymentService } from 'src/app/shared/payment.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

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

  constructor(private service: PaymentService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
    }
    this.service.formData = {
      Amount: null,
      PaymentType: ''
    }
  }
  onSubmit(form: NgForm) {
    this.service.postPaymentDetail(form.value).subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Payment submitted successfully', 'Done');
      },
      err => {
        console.log(err);
        this.toastr.error('Payment did not go through', 'Payment Error')
      }
    );
  }
}
