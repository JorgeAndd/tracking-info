import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

// Components
import { AppComponent } from './app.component';
import { OrdersListComponent } from './components/orders-list/orders-list.component';
import { OrderDetailsComponent } from './components/order-details/order-details.component';

// Services
import { OrdersService } from './services/orders.service';

@NgModule({
    declarations: [
        AppComponent,
        OrdersListComponent,
        OrderDetailsComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        NgbModule,
        RouterModule.forRoot([
            { path: '', component: OrdersListComponent, pathMatch: 'full' },
            { path: 'details', component: OrderDetailsComponent }
        ])
    ],
    providers: [
        OrdersService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
