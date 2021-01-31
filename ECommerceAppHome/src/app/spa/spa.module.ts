import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import{ Routes,RouterModule} from'@angular/router';

import{MembershipModule} from '../membership/membership.module';
import{StandardModule} from '../standard/standard.module';
import{CatalogModule} from '../catalog/catalog.module';

import { ContainerComponent } from './container/container.component';
import { HomeComponent } from '../standard/home/home.component';
import { AboutusComponent } from '../standard/aboutus/aboutus.component';
import { ContactusComponent } from '../standard/contactus/contactus.component';
import { ServicesComponent } from '../standard/services/services.component';
import { ListComponent } from '../catalog/list/list.component';
import { InsertComponent } from '../catalog/insert/insert.component';
import { UpdateComponent } from '../catalog/update/update.component';
import { DetailsComponent } from '../catalog/details/details.component';

const routes:Routes=
[
  { path:'',redirectTo:'home',pathMatch:'full'},
  { path:'home',component:HomeComponent},
  { path:'aboutus',component:AboutusComponent},
  { path:'contactus',component:ContactusComponent},
  { path:'services',component:ServicesComponent},
  { path:'products',component:ListComponent},
  { path:'products/:id',component:DetailsComponent},
  { path:'insert',component:InsertComponent},
  { path:'update/:id',component:UpdateComponent}
];


@NgModule({
  declarations: [ContainerComponent],
  imports: [
    CommonModule,
    StandardModule,
    CatalogModule,
    MembershipModule,
    RouterModule.forRoot(routes)
  ],
   exports:[
    ContainerComponent
  ]
})
export class SpaModule { }
