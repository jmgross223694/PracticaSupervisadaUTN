using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MercadoPago
    {
        private string mepa_idmercadopago;
        private string mepa_fecha;
        private string mepa_hora;
        private string mepa_idalumno;
        private long mepa_payment_id;
        private string mepa_status;
        private string mepa_external_reference;
        private long mepa_merchant_order_id;
        private string mepa_operation_type;
        private string mepa_payment_method_id;
        private string mepa_payment_type_id;
        private string mepa_status_detail;
        private int mepa_installments;
        private string mepa_card;
        private string mepa_preference_id;
        private double mepa_transaction_amount;
        private double mepa_transaction_amount_refunded;
        private double mepa_net_received_amount;
        private double mepa_total_paid_amount;
        private double mepa_overpaid_amount;
        private double mepa_installment_amount;
        private long mepa_idsubcuenta;
        private string mepa_idfactura;
        private string mepa_estado;
        private string mepa_fechaproc;
        private string mepa_horaproc;
        private double mepa_importe;
        private string mepa_procesado;
        private string mepa_estado_operacion;
        private string mepa_chk_return;
        private string mepa_chk_ipn;

        public MercadoPago()
        {

        }

        public MercadoPago(string mepa_idmercadopago, string mepa_fecha, string mepa_hora, string mepa_idalumno, long mepa_payment_id, string mepa_status, string mepa_external_reference, long mepa_merchant_order_id, string mepa_operation_type, string mepa_payment_method_id, string mepa_payment_type_id, string mepa_status_detail, int mepa_installments, string mepa_card, string mepa_preference_id, double mepa_transaction_amount, double mepa_transaction_amount_refunded, double mepa_net_received_amount, double mepa_total_paid_amount, double mepa_overpaid_amount, double mepa_installment_amount, long mepa_idsubcuenta, string mepa_idfactura, string mepa_estado, string mepa_fechaproc, string mepa_horaproc, double mepa_importe, string mepa_procesado, string mepa_estado_operacion, string mepa_chk_return, string mepa_chk_ipn)
        {
            this.mepa_idmercadopago = mepa_idmercadopago;
            this.mepa_fecha = mepa_fecha;
            this.mepa_hora = mepa_hora;
            this.mepa_idalumno = mepa_idalumno;
            this.mepa_payment_id = mepa_payment_id;
            this.mepa_status = mepa_status;
            this.mepa_external_reference = mepa_external_reference;
            this.mepa_merchant_order_id = mepa_merchant_order_id;
            this.mepa_operation_type = mepa_operation_type;
            this.mepa_payment_method_id = mepa_payment_method_id;
            this.mepa_payment_type_id = mepa_payment_type_id;
            this.mepa_status_detail = mepa_status_detail;
            this.mepa_installments = mepa_installments;
            this.mepa_card = mepa_card;
            this.mepa_preference_id = mepa_preference_id;
            this.mepa_transaction_amount = mepa_transaction_amount;
            this.mepa_transaction_amount_refunded = mepa_transaction_amount_refunded;
            this.mepa_net_received_amount = mepa_net_received_amount;
            this.mepa_total_paid_amount = mepa_total_paid_amount;
            this.mepa_overpaid_amount = mepa_overpaid_amount;
            this.mepa_installment_amount = mepa_installment_amount;
            this.mepa_idsubcuenta = mepa_idsubcuenta;
            this.mepa_idfactura = mepa_idfactura;
            this.mepa_estado = mepa_estado;
            this.mepa_fechaproc = mepa_fechaproc;
            this.mepa_horaproc = mepa_horaproc;
            this.mepa_importe = mepa_importe;
            this.mepa_procesado = mepa_procesado;
            this.mepa_estado_operacion = mepa_estado_operacion;
            this.mepa_chk_return = mepa_chk_return;
            this.mepa_chk_ipn = mepa_chk_ipn;
        }

        public string Mepa_idmercadopago { get => mepa_idmercadopago; set => mepa_idmercadopago = value; }
        public string Mepa_fecha { get => mepa_fecha; set => mepa_fecha = value; }
        public string Mepa_hora { get => mepa_hora; set => mepa_hora = value; }
        public string Mepa_idalumno { get => mepa_idalumno; set => mepa_idalumno = value; }
        public long Mepa_payment_id { get => mepa_payment_id; set => mepa_payment_id = value; }
        public string Mepa_status { get => mepa_status; set => mepa_status = value; }
        public string Mepa_external_reference { get => mepa_external_reference; set => mepa_external_reference = value; }
        public long Mepa_merchant_order_id { get => mepa_merchant_order_id; set => mepa_merchant_order_id = value; }
        public string Mepa_operation_type { get => mepa_operation_type; set => mepa_operation_type = value; }
        public string Mepa_payment_method_id { get => mepa_payment_method_id; set => mepa_payment_method_id = value; }
        public string Mepa_payment_type_id { get => mepa_payment_type_id; set => mepa_payment_type_id = value; }
        public string Mepa_status_detail { get => mepa_status_detail; set => mepa_status_detail = value; }
        public int Mepa_installments { get => mepa_installments; set => mepa_installments = value; }
        public string Mepa_card { get => mepa_card; set => mepa_card = value; }
        public string Mepa_preference_id { get => mepa_preference_id; set => mepa_preference_id = value; }
        public double Mepa_transaction_amount { get => mepa_transaction_amount; set => mepa_transaction_amount = value; }
        public double Mepa_transaction_amount_refunded { get => mepa_transaction_amount_refunded; set => mepa_transaction_amount_refunded = value; }
        public double Mepa_net_received_amount { get => mepa_net_received_amount; set => mepa_net_received_amount = value; }
        public double Mepa_total_paid_amount { get => mepa_total_paid_amount; set => mepa_total_paid_amount = value; }
        public double Mepa_overpaid_amount { get => mepa_overpaid_amount; set => mepa_overpaid_amount = value; }
        public double Mepa_installment_amount { get => mepa_installment_amount; set => mepa_installment_amount = value; }
        public long Mepa_idsubcuenta { get => mepa_idsubcuenta; set => mepa_idsubcuenta = value; }
        public string Mepa_idfactura { get => mepa_idfactura; set => mepa_idfactura = value; }
        public string Mepa_estado { get => mepa_estado; set => mepa_estado = value; }
        public string Mepa_fechaproc { get => mepa_fechaproc; set => mepa_fechaproc = value; }
        public string Mepa_horaproc { get => mepa_horaproc; set => mepa_horaproc = value; }
        public double Mepa_importe { get => mepa_importe; set => mepa_importe = value; }
        public string Mepa_procesado { get => mepa_procesado; set => mepa_procesado = value; }
        public string Mepa_estado_operacion { get => mepa_estado_operacion; set => mepa_estado_operacion = value; }
        public string Mepa_chk_return { get => mepa_chk_return; set => mepa_chk_return = value; }
        public string Mepa_chk_ipn { get => mepa_chk_ipn; set => mepa_chk_ipn = value; }
    }
}

