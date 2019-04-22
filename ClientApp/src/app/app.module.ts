import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PaymentsComponent } from './payments/payments.component';
import { PaymentDetailComponent } from './payments/payment-detail/payment-detail.component';
import { PaymentListComponent } from './payments/payment-list/payment-list.component';

@NgModule({
  declarations: [
    AppComponent,
    PaymentsComponent,
    PaymentDetailComponent,
    PaymentListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
