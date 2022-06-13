using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RegistroMp
    {
        public string date_created { get; set; }
        public string date_approved { get; set; }
        public string date_released { get; set; }
        public string counterpart_name { get; set; }
        public string counterpart_nickname { get; set; }
        public string counterpart_email { get; set; }
        public string counterpart_phone_number { get; set; }
        public string buyer_document { get; set; }
        public string item_id { get; set; }
        public string reason { get; set; }
        public string external_reference { get; set; }
        public string seller_custom_field { get; set; }
        public string operation_id { get; set; }
        public string status { get; set; }
        public string status_detail { get; set; }
        public string operation_type { get; set; }
        public string transaction_amount { get; set; }
        public string mercadopago_fee { get; set; }
        public string marketplace_fee { get; set; }
        public string shipping_cost { get; set; }
        public string coupon_fee { get; set; }
        public string net_received_amount { get; set; }
        public string installments { get; set; }
        public string payment_type { get; set; }
        public string amount_refunded { get; set; }
        public string refund_operator { get; set; }
        public string claim_id { get; set; }
        public string chargeback_id { get; set; }
        public string marketplace { get; set; }
        public string order_id { get; set; }
        public string merchant_order_id { get; set; }
        public string campaign_id { get; set; }
        public string campaign_name { get; set; }
        public string activity_url { get; set; }
        public string id { get; set; }
        public string shipment_status { get; set; }
        public string buyer_address { get; set; }
        public string tracking_number { get; set; }
        public string operator_name { get; set; }
        public string store_id { get; set; }
        public string pos_id { get; set; }
        public string external_id { get; set; }
        public string financing_fee { get; set; }

        public RegistroMp()
        {

        }

        public RegistroMp(string date_created, string date_approved, string date_released, 
            string counterpart_name, string counterpart_nickname, string counterpart_email, 
            string counterpart_phone_number, string buyer_document, string item_id, 
            string reason, string external_reference, string seller_custom_field, 
            string operation_id, string status, string status_detail, 
            string operation_type, string transaction_amount, string mercadopago_fee, 
            string marketplace_fee, string shipping_cost, string coupon_fee, 
            string net_received_amount, string installments, string payment_type, 
            string amount_refunded, string refund_operator, string claim_id, 
            string chargeback_id, string marketplace, string order_id, 
            string merchant_order_id, string campaign_id, string campaign_name, 
            string activity_url, string id, string shipment_status, string buyer_address, 
            string tracking_number, string operator_name, string store_id, string pos_id, 
            string external_id, string financing_fee)
        {
            this.date_created = date_created;
            this.date_approved = date_approved;
            this.date_released = date_released;
            this.counterpart_name = counterpart_name;
            this.counterpart_nickname = counterpart_nickname;
            this.counterpart_email = counterpart_email;
            this.counterpart_phone_number = counterpart_phone_number;
            this.buyer_document = buyer_document;
            this.item_id = item_id;
            this.reason = reason;
            this.external_reference = external_reference;
            this.seller_custom_field = seller_custom_field;
            this.operation_id = operation_id;
            this.status = status;
            this.status_detail = status_detail;
            this.operation_type = operation_type;
            this.transaction_amount = transaction_amount;
            this.mercadopago_fee = mercadopago_fee;
            this.marketplace_fee = marketplace_fee;
            this.shipping_cost = shipping_cost;
            this.coupon_fee = coupon_fee;
            this.net_received_amount = net_received_amount;
            this.installments = installments;
            this.payment_type = payment_type;
            this.amount_refunded = amount_refunded;
            this.refund_operator = refund_operator;
            this.claim_id = claim_id;
            this.chargeback_id = chargeback_id;
            this.marketplace = marketplace;
            this.order_id = order_id;
            this.merchant_order_id = merchant_order_id;
            this.campaign_id = campaign_id;
            this.campaign_name = campaign_name;
            this.activity_url = activity_url;
            this.id = id;
            this.shipment_status = shipment_status;
            this.buyer_address = buyer_address;
            this.tracking_number = tracking_number;
            this.operator_name = operator_name;
            this.store_id = store_id;
            this.pos_id = pos_id;
            this.external_id = external_id;
            this.financing_fee = financing_fee;
        }
    }
}
