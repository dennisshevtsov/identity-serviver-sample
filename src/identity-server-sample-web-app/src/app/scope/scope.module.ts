import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchScopesComponent } from './search-scopes/search-scopes.component';
import { AddScopeComponent } from './add-scope/add-scope.component';



@NgModule({
  declarations: [
    SearchScopesComponent,
    AddScopeComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ScopeModule { }