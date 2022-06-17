using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Aspose.Cells;
using SpreadsheetLight;
using Dominio;
using Negocio;
using Workbook = Aspose.Cells.Workbook;

namespace PruebasPS
{
    public partial class AnalizarExcel : System.Web.UI.Page
    {
        private List<RegistroMp> listaMp = new List<RegistroMp>();
        private int iRow = 1, iCol = 1, cantFilas = 0, cantColumnas = 0;
        private string[] nombresColsCorrectas = {
            "Fecha de compra (date_created)",
            "Fecha de acreditación (date_approved)",
            "Fecha de liberación del dinero (date_released)",
            "Nombre de la contraparte (counterpart_name)",
            "Nickname de la contraparte (counterpart_nickname)",
            "E-mail de la contraparte (counterpart_email)",
            "Teléfono de la contraparte (counterpart_phone_number)",
            "Documento de la contraparte (buyer_document)",
            "Identificador de producto (item_id)",
            "Descripción de la operación (reason)",
            "Código de referencia (external_reference)",
            "SKU Producto (seller_custom_field)",
            "Número de operación de Mercado Pago (operation_id)",
            "Estado de la operación (status)",
            "Detalle del estado de la operación (status_detail)",
            "Tipo de operación (operation_type)",
            "Valor del producto (transaction_amount)",
            "Tarifa de Mercado Pago (mercadopago_fee)",
            "Comisión por uso de plataforma de terceros (marketplace_fee)",
            "Costo de envío (shipping_cost)",
            "Descuento a tu contraparte (coupon_fee)",
            "Monto recibido (net_received_amount)",
            "Cuotas (installments)",
            "Medio de pago (payment_type)",
            "Monto devuelto (amount_refunded)",
            "Operador que devolvió dinero (refund_operator)",
            "Número de reclamo (claim_id)",
            "Número de contracargo (chargeback_id)",
            "Plataforma (marketplace)",
            "Número de venta en Mercado Libre (order_id)",
            "Número de venta en tu negocio online (merchant_order_id)",
            "Número de campaña de descuento (campaign_id)",
            "Nombre de campaña de descuento (campaign_name)",
            "Detalle de la venta (activity_url)",
            "Mercado Pago Point (id)",
            "Estado del envío (shipment_status)",
            "Domicilio del comprador (buyer_address)",
            "Código de seguimiento (tracking_number)",
            "Operador en cobros de Point (operator_name)",
            "Número de local (store_id)",
            "Número de caja (pos_id)",
            "Número de caja externo (external_id)",
            "Costos de financiación (financing_fee)"
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                //mostrar todo lo que haya que mostrar.

                MercadoPagoBD mpNegocio = new MercadoPagoBD();
                MercadoPago mp = new MercadoPago("47514", "2020-12-09", "23:51:13-03:00", "1111", 2296530508215, "approved", "78558", 491756239753, "regular_payment", "debvisa", "debit_card", "accredited", 1, null, "245577091-2e1e96c4-b733-4177-b936-46a3ed324c67", 10000, 0, 10000, 10000, 0, 10000, 42173134, null, "IMPAGO", DateTime.Now.ToString("yyyy/MM/dd"), "23:51:13-03:00", 10000, "NO", "APROBADA", "SI", "NO");
                //basura                                                                                                                                                                                                                                                //basura                         //basura                                                                                             

                mpNegocio.Update(mp);
            }
            else
            {
                //ocultar todo lo que haya que ocultar

                Session.Add("Error", "Debe loguearse para acceder a esta página.");
                Response.Redirect("Error.aspx", false); 
            }
        }

        private void ContarFilasColumnasArchivo(SLDocument archivo)
        {
            while (!string.IsNullOrEmpty(archivo.GetCellValueAsString(this.iRow, 1))) //Cuenta la cantidad de filas con datos que tiene el archivo
            {
                this.iRow++;
                this.cantFilas++;
            }

            while (!string.IsNullOrEmpty(archivo.GetCellValueAsString(1, this.iCol))) //Cuenta la cantidad de columnas con datos que tiene el archivo
            {
                this.iCol++;
                this.cantColumnas++;
            }
        }

        private RegistroMp CargarRegistroMp(SLDocument archivo)
        {
            RegistroMp aux = new RegistroMp();

            aux.date_created = archivo.GetCellValueAsString(this.iRow, 1);
            aux.date_approved = archivo.GetCellValueAsString(this.iRow, 2);
            aux.date_released = archivo.GetCellValueAsString(this.iRow, 3);
            aux.counterpart_name = archivo.GetCellValueAsString(this.iRow, 4);
            aux.counterpart_nickname = archivo.GetCellValueAsString(this.iRow, 5);
            aux.counterpart_email = archivo.GetCellValueAsString(this.iRow, 6);
            aux.counterpart_phone_number = archivo.GetCellValueAsString(this.iRow, 7);
            aux.buyer_document = archivo.GetCellValueAsString(this.iRow, 8);
            aux.item_id = archivo.GetCellValueAsString(this.iRow, 9);
            aux.reason = archivo.GetCellValueAsString(this.iRow, 10);
            aux.external_reference = archivo.GetCellValueAsString(this.iRow, 11);
            aux.seller_custom_field = archivo.GetCellValueAsString(this.iRow, 12);
            aux.operation_id = archivo.GetCellValueAsString(this.iRow, 13);
            aux.status = archivo.GetCellValueAsString(this.iRow, 14);
            aux.status_detail = archivo.GetCellValueAsString(this.iRow, 15);
            aux.operation_type = archivo.GetCellValueAsString(this.iRow, 16);
            aux.transaction_amount = archivo.GetCellValueAsString(this.iRow, 17);
            aux.mercadopago_fee = archivo.GetCellValueAsString(this.iRow, 18);
            aux.marketplace_fee = archivo.GetCellValueAsString(this.iRow, 19);
            aux.shipping_cost = archivo.GetCellValueAsString(this.iRow, 20);
            aux.coupon_fee = archivo.GetCellValueAsString(this.iRow, 21);
            aux.net_received_amount = archivo.GetCellValueAsString(this.iRow, 22);
            aux.installments = archivo.GetCellValueAsString(this.iRow, 23);
            aux.payment_type = archivo.GetCellValueAsString(this.iRow, 24);
            aux.amount_refunded = archivo.GetCellValueAsString(this.iRow, 25);
            aux.refund_operator = archivo.GetCellValueAsString(this.iRow, 26);
            aux.claim_id = archivo.GetCellValueAsString(this.iRow, 27);
            aux.chargeback_id = archivo.GetCellValueAsString(this.iRow, 28);
            aux.marketplace = archivo.GetCellValueAsString(this.iRow, 29);
            aux.order_id = archivo.GetCellValueAsString(this.iRow, 30);
            aux.merchant_order_id = archivo.GetCellValueAsString(this.iRow, 31);
            aux.campaign_id = archivo.GetCellValueAsString(this.iRow, 32);
            aux.campaign_name = archivo.GetCellValueAsString(this.iRow, 33);
            aux.activity_url = archivo.GetCellValueAsString(this.iRow, 34);
            aux.id = archivo.GetCellValueAsString(this.iRow, 35);
            aux.shipment_status = archivo.GetCellValueAsString(this.iRow, 36);
            aux.buyer_address = archivo.GetCellValueAsString(this.iRow, 37);
            aux.tracking_number = archivo.GetCellValueAsString(this.iRow, 38);
            aux.operator_name = archivo.GetCellValueAsString(this.iRow, 39);
            aux.store_id = archivo.GetCellValueAsString(this.iRow, 40);
            aux.pos_id = archivo.GetCellValueAsString(this.iRow, 41);
            aux.external_id = archivo.GetCellValueAsString(this.iRow, 42);
            aux.financing_fee = archivo.GetCellValueAsString(this.iRow, 43);

           

            return aux;
        }

        private void RecorrerArchivo(SLDocument archivo)
        {
            for (this.iRow = 2; this.iRow <= this.cantFilas; this.iRow++)
            {
                this.listaMp.Add(CargarRegistroMp(archivo));
            }
        }

        private bool ValidarArchivo(SLDocument archivo)
        {
            bool resultado = false;

            for (this.iCol = 1; this.iCol <= this.cantColumnas; this.iCol++)
            {
                string valor = archivo.GetCellValueAsString(1, this.iCol); //Recorremos el archivo celda por celda y obtenemos su respectivo valor

                if (valor == nombresColsCorrectas[this.iCol-1])
                {
                    resultado = true;
                }
                else
                {
                    return false;
                }
            }

            return resultado;
        }

        private void CargarLista(SLDocument archivo)
        {
            ContarFilasColumnasArchivo(archivo);

            if (ValidarArchivo(archivo))
            {
                RecorrerArchivo(archivo);

                dgvRegistrosMp.DataSource = this.listaMp;
                dgvRegistrosMp.DataBind();
                dgvRegistrosMp.Visible = true;

                MostrarMensaje("La operación se ha completado correctamente!", "OK");
            }
            else
            {
                MostrarMensaje("Archivo inválido. Verifique que las columnas del archivo sean las correctas.", "ERROR");
            }
        }

        private void AbrirArchivo(string path)
        {
            try
            {
                SLDocument archivo = new SLDocument(@"" + path); //Abrimos el archivo que se acaba de guardar

                string hoja1 = archivo.GetSheetNames()[0].ToString(); //Obtenemos el nombre de la primera hoja del archivo
                archivo.SelectWorksheet(hoja1); //Seleccionamos esa hoja

                CargarLista(archivo);
            }
            catch
            {
                MostrarMensaje("Error al abrir el archivo.", "ERROR");
            }
        }
        
        protected void BtnProcesarArchivo_Click(object sender, EventArgs e)
        {
            if (CargarArchivo.HasFile) //Validamos que se halla seleccionado algún archivo
            {
                string extension = System.IO.Path.GetExtension(CargarArchivo.FileName); //Obtenemos la extension del archivo seleccionado
                string fileName = CargarArchivo.FileName;
                extension = extension.ToLower();

                int tam = CargarArchivo.PostedFile.ContentLength; //Obtenemos el tamaño del archivo seleccionado

                if (extension == ".xlsx" || extension == ".xls") //Validamos el formato del archivo seleccionado
                {
                    if (tam <= 1048576) //Validamos su tamaño (en bytes)
                    {
                        string path = "~/Planillas_Subidas/Libro1"+extension;
                        CargarArchivo.SaveAs(Server.MapPath(path)); //Guardamos el archivo seleccionado en la carpeta 
                        path = Server.MapPath(path);

                        if (extension == ".xls")
                        {
                            var workbook = new Workbook(path);
                            path = path.Replace(".xls", ".xlsx");
                            workbook.Save(path);
                        }

                        AbrirArchivo(path);
                    }
                }
                if (extension == ".csv")
                {
                    MostrarMensaje("Sólo se permiten archivos con extension '.xls' ó '.xlsx'.", "ERROR");
                }
            }
            else
            {
                MostrarMensaje("No se seleccionó ningún archivo.", "ERROR");
            }
        }

        private void MostrarMensaje(string mensaje, string tipoMensaje)
        {
            if (tipoMensaje == "ERROR")
            {
                LblMensaje.ForeColor = System.Drawing.Color.Red;
                dgvRegistrosMp.Visible = false;
            }
            if (tipoMensaje == "OK")
            {
                LblMensaje.ForeColor = System.Drawing.Color.Green;
                dgvRegistrosMp.Visible = true;
            }
            LblMensaje.Text = mensaje;
            LblMensaje.Visible = true;
        }
    }
}

/*
 *  1) Recorrer la lista (foreach) e ir consultando cada registro con la BD y asignando el estado de las mismas
       en cada registro, en la propiedad "estado".
    2) Recorrer la lista (foreach) y los que tienen "estado" = Pendiente/Cancelado, cargar los datos correspondientes
       en la BD.
    3) Mostrar cartel aclaratorio informando si la operación se completo correctamente o no.
*/


