import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { TrainingRoutingModule } from './training-routing.module';
import { TrainingComponent } from './training.component';
import { DateTimePickerModule} from 'ngx-datetime-picker';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { TrainingService } from './training.service';

@NgModule({
  declarations: [
    TrainingComponent,
  ],
  imports: [
    BrowserModule,
    TrainingRoutingModule,
    NgbModule,
    DateTimePickerModule,
    FormsModule,
    HttpModule,
    HttpClientModule
  ],
  providers: [ ],
  bootstrap: [TrainingComponent]
})
export class TrainingModule { }
