import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BookRoutingModule } from './book-routing.module';
import { BookComponent } from './book.component';
import { SharedModule } from '../shared/shared.module';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';
import { ListService } from '@abp/ng.core';


@NgModule({
  declarations: [
    BookComponent
  ],
  imports: [
    SharedModule,
    BookRoutingModule,
    NgbDatepickerModule
  ],
  providers:[
    ListService
  ]
})
export class BookModule { }
