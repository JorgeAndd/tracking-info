import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

// Components
import { AppComponent } from './app.component';
import { OrdersListComponent } from './components/orders-list/orders-list.component';

// Services
import { OrdersListService } from './services/orders-list.service';

@NgModule({
    declarations: [
        AppComponent,
        OrdersListComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        NgbModule,
        RouterModule.forRoot([
            { path: '', component: OrdersListComponent, pathMatch: 'full' },
        ])
    ],
    providers: [
        OrdersListService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
