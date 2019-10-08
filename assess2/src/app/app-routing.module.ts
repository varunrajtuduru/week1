import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateComponent } from './create/create.component';
import { StudentlistComponent } from './studentlist/studentlist.component';
import {UpdateComponent} from './update/update.component';


const routes: Routes = [
  {path:'form',component:CreateComponent},
  {path:'studentlist',component:StudentlistComponent},
  {path:'edit',component:UpdateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
