module OrderTakingTypes
    type CustomerInfo = Undefined
    type Order = {
        CustomerInfo: CustomerInfo
        ShippingAddress: ShippingAddress
        BillingAddress: BillingAddress
        OrderLines: OrderLine list
        AmountToBill: BillingAmount
        }