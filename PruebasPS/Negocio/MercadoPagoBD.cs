using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class MercadoPagoBD
    {
        private DB conex = new DB();

        public bool Update(MercadoPago mp)
        {
            bool resultado = false;

            try
            {
                string Consulta = "UPDATE mercadopagos " +
                                 " SET mepa_payment_id=" + mp.Mepa_payment_id + " , mepa_status='" + mp.Mepa_status + 
                                 "', mepa_status_detail='" + mp.Mepa_status_detail + "' , mepa_operation_type='" + 
                                 mp.Mepa_operation_type + "', mepa_merchant_order_id= " + mp.Mepa_merchant_order_id + 
                                 ",mepa_installments=" + mp.Mepa_installments + ",mepa_payment_type_id='" + 
                                 mp.Mepa_payment_type_id + "',mepa_payment_method_id='" + mp.Mepa_payment_method_id + 
                                 "',mepa_transaction_amount=" + mp.Mepa_transaction_amount + ", mepa_total_paid_amount=" + 
                                 mp.Mepa_total_paid_amount + ",mepa_net_received_amount=" + mp.Mepa_net_received_amount + 
                                 ",mepa_transaction_amount_refunded=" + mp.Mepa_transaction_amount_refunded + 
                                 ",mepa_overpaid_amount=" + mp.Mepa_overpaid_amount + ",mepa_installment_amount=" + 
                                 mp.Mepa_installment_amount + ",mepa_estado_operacion='" + mp.Mepa_estado_operacion + 
                                 "',mepa_chk_return='" + mp.Mepa_chk_return + "'" +
                                 " WHERE mepa_idmercadopago ='" + mp.Mepa_idmercadopago + "'  " +
                                 "and mepa_estado_operacion != 'APROBADA' ";
               

                conex.SetearConsulta(Consulta);
                conex.EjecutarConsulta();

                if (conex.Lector.Read())
                {
                    resultado = true;
                }
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                conex.CerrarConexion();
            }
            return resultado;
        }

        public string ConsultaEstadoRegistro(string id)
        {
            string estado = "", 
                   consulta = "SELECT mepa_estado_operacion from mercadopagos where mepa_idmercadopago = '" + id + "'";

            try
            {
                conex.SetearConsulta(consulta);
                conex.EjecutarConsulta();

                if (conex.Lector.Read())
                {
                    estado = conex.Lector["mepa_estado_operacion"].ToString();
                }
            }
            catch
            {
                estado = "Error";
            }
            finally
            {
                conex.CerrarConexion();
            }
            return estado;
        }
    }
}

