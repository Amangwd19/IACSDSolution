import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import{SpaModule} from './spa/spa.module';

import { AppComponent } from './app.component';
import { CatalogModule } from './catalog/catalog.module';

 


///What do you mean by Module ?
//Logical container of components, 
//                     directives,
//                     pipes,
//                     Services,
//                     classes
//                     interfaces
//                    
//                     etc.
@NgModule({
  // members of module
  declarations: [
                  AppComponent,
                
                  
                ],
  // association with other modules
  imports: [
              BrowserModule,
              FormsModule,
            CatalogModule,
           //  SpaModule,
            
           //  AppRoutingModule,
           
            ],

  // Dependencies for exeuction

  providers: [],
  //  startup component

  bootstrap: [AppComponent],

  
  

})
export class AppModule { }
