import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentlistComponent } from './studentlist/studentlist.component';
import { CreateComponent } from './create/create.component';
import {FormsModule} from '@angular/forms';
import { UpdateComponent } from './update/update.component'

@NgModule({
  declarations: [
    AppComponent,
    StudentlistComponent,
    CreateComponent,
    UpdateComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
