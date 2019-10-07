import { Component, OnInit } from '@angular/core';
import { OrderDetail } from '../../models/order/orderDetailModel';
import { OrdersService } from '../../services/orders.service';
import { Router } from '@angular/router';
import { Status, StatusEnum } from '../../models/order/statusModel';
import { TrackingStep } from '../../models/order/trackingStepModel';

@Component({
    selector: 'app-order-details',
    templateUrl: './order-details.component.html',
    styleUrls: ['./order-details.component.css']
})
export class OrderDetailsComponent implements OnInit {
    public order: OrderDetail = new OrderDetail();
    public StatusEnum = StatusEnum;

    constructor(
        private ordersListService: OrdersService,
        private router: Router
    ) { }

    ngOnInit() {
        let orderId = history.state.data.orderId;

        this.getOrderDetails(orderId);
    }

    private getOrderDetails(orderId: number): void {
        this.ordersListService.getOrderDetails(orderId).subscribe(
            result => {
                this.order = result;
            },
            error => { console.log("error getting orders: " + JSON.stringify(error)) }
        );
    }

    public getProgressColorClass(): string {
        let lastStatus = this.order.trackingSteps[this.order.trackingSteps.length - 1];

        switch (lastStatus.status) {
            case StatusEnum.Bought:
                return 'progress-bar-warning';
            case StatusEnum.Paid:
                return 'progress-bar-info';
            case StatusEnum.Sent:
                return 'progress-bar-info';
            case StatusEnum.InTransit:
                return 'progress-bar-info active';
            case StatusEnum.Delivered:
                return 'progress-bar-success';
            case StatusEnum.Delayed:
                return 'progress-bar-danger';
            default:
                return 'progress-bar-warning';
        }
    }

    public getProgressValue(): string {
        let lastStatus = this.order.trackingSteps[this.order.trackingSteps.length - 1];

        switch (lastStatus.status) {
            case StatusEnum.Bought:
                return '0%';
            case StatusEnum.Paid:
                return '20%';
            case StatusEnum.Sent:
                return '40%';
            case StatusEnum.InTransit:
                return '60%';
            case StatusEnum.Delivered:
                return '100%';
            case StatusEnum.Delayed:
                return '80%';
            default:
                return '100%';
        }
    }

    public getProgressLabel(): string {
        let lastStatus = this.order.trackingSteps[this.order.trackingSteps.length - 1];

        switch (lastStatus.status) {
            case StatusEnum.Bought:
                return 'Comprado';
            case StatusEnum.Paid:
                return 'Pago';
            case StatusEnum.Sent:
                return 'Enviado';
            case StatusEnum.InTransit:
                return 'Em trânsito';
            case StatusEnum.Delivered:
                return 'Entregue';
            case StatusEnum.Delayed:
                return 'Atrasado';
            default:
                return 'Desconhecido';
        }
    }

    public getStatusText(step: TrackingStep): string {
        let date = new Date(step.date);
        let statusLabel = Status.toString(step.status);

        let dateOptions = { day: '2-digit', month: '2-digit', year: 'numeric'}
        let dateString = date.toLocaleDateString('pt-BR', dateOptions);

        return `${dateString} ${statusLabel}`;
    }

    public goBack(): void {
        this.router.navigate(['']);
    }

}
