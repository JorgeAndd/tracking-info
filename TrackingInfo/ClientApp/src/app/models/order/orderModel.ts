import { Status, StatusEnum } from './statusModel';

export class Order {
    public id: number;
    public userId: number;
    public lastStatus: StatusEnum;
}

