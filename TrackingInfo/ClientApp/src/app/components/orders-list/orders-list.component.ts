import { Component, OnInit } from '@angular/core';
import { OrdersListService } from '../../services/orders-list.service';
import { Order } from '../../models/order/orderModel';
import { Status } from '../../models/order/statusModel';

@Component({
    selector: 'app-orders-list',
    templateUrl: './orders-list.component.html',
    styleUrls: ['./orders-list.component.css']
})
export class OrdersListComponent implements OnInit {
    public orders: Order[] = [];

    constructor(
        private ordersListService: OrdersListService
    ) { }

    ngOnInit() {
        this.getUserOrders();
    }

    private getUserOrders() {
        this.ordersListService.getUserOrders(1).subscribe(
            result => {
                this.orders = result;
            },
            error => { console.log("error getting orders: " + JSON.stringify(error)) }
        );
    }

    public getStatusLabel(order: Order): string {
        return Status.toString(order.lastStatus);
    }
}
