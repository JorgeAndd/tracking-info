"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var StatusEnum;
(function (StatusEnum) {
    StatusEnum[StatusEnum["Bought"] = 0] = "Bought";
    StatusEnum[StatusEnum["Paid"] = 1] = "Paid";
    StatusEnum[StatusEnum["Sent"] = 2] = "Sent";
    StatusEnum[StatusEnum["InTransit"] = 3] = "InTransit";
    StatusEnum[StatusEnum["Delivered"] = 4] = "Delivered";
    StatusEnum[StatusEnum["Delayed"] = 5] = "Delayed";
})(StatusEnum = exports.StatusEnum || (exports.StatusEnum = {}));
var Status = /** @class */ (function () {
    function Status() {
    }
    Status.toString = function (status) {
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
    };
    return Status;
}());
exports.Status = Status;
//# sourceMappingURL=statusModel.js.map