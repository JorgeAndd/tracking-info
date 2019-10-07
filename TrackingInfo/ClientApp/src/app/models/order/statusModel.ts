export enum StatusEnum {
    Bought,
    Paid,
    Sent,
    InTransit,
    Delivered,
    Delayed
}

export class Status {
    public status: StatusEnum

    public static toString(status: StatusEnum): string {
        switch (status) {
            case StatusEnum.Bought:
                return 'Comprado';
            case StatusEnum.Paid:
                return 'Pagamento Confirmado';
            case StatusEnum.Sent:
                return 'Enviado';
            case StatusEnum.InTransit:
                return 'Em trânsito';
            case StatusEnum.Delivered:
                return 'Entregue';
            case StatusEnum.Delayed:
                return 'Atrasado';
        }
    }
}
