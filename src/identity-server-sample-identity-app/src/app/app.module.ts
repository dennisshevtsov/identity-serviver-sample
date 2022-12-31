import { HttpClientModule    } from '@angular/common/http'
import { NgModule            } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule       } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent     } from './app.component';
import { SigninComponent  } from './components';

@NgModule({
  declarations: [
    AppComponent,
    SigninComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [
    AppComponent,
  ],
})
export class AppModule { }