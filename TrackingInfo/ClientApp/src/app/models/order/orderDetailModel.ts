import { TrackingStep } from './trackingStepModel';

export class OrderDetail {
    public id: number;
    public trackingNumber: number;
    public trackingSteps: TrackingStep[];
}
