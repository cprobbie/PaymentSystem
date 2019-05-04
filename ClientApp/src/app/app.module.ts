import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { AppComponent } from './app.component';
import { PaymentDetailsComponent } from './payments/payment-details/payment-details.component';
import { PaymentListComponent } from './payments/payment-list/payment-list.component';
import { PaymentsComponent } from './payments/payments.component';
import { PaymentService } from './shared/payment.service';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailsComponent,
    PaymentListComponent,
    PaymentsComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    HttpClientModule
  ],
  providers: [PaymentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
