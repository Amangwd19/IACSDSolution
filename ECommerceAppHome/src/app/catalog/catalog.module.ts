 import { NgModule } from '@angular/core';
 import { CommonModule } from '@angular/common';
 import { HttpClientModule} from '@angular/common/http';
 import { FormsModule } from '@angular/forms';
 import { RouterModule } from '@angular/router';

 import{SharedModule} from '../shared/shared.module';

 import { ListComponent } from './list/list.component';
 import { DetailsComponent } from './details/details.component';
 import { InsertComponent } from './insert/insert.component';
 import { UpdateComponent } from './update/update.component';
 import { GitComponent } from './git/git.component';
 import { RestlistComponent } from './restlist/restlist.component';
 import { FlowerDetailsComponent } from './flower-details/flower-details.component';
 import { FlowersListComponent } from './flowers-list/flowers-list.component';
 
 @NgModule({
   declarations: [ ListComponent, 
                   DetailsComponent, 
                   InsertComponent, 
                   UpdateComponent,
                    GitComponent,
                    RestlistComponent,
                    FlowerDetailsComponent,
                    FlowersListComponent
                 ],
   imports: [
               CommonModule,
               FormsModule,
               RouterModule,
               HttpClientModule,
               SharedModule
   ],
   
   //add entries of those which needed to be used outside
   exports:[
    ListComponent,
    DetailsComponent,
    InsertComponent, 
    UpdateComponent,
    GitComponent,
    RestlistComponent,
    FlowerDetailsComponent,
    FlowersListComponent
   ]
 })
 export class CatalogModule { }
 