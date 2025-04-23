using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class VentaService
    {
        public static int InsertarVenta(DateTime fechaVenta, float total, List<DetalleVenta> detalleVentas, float cambio)
        {
            if (detalleVentas == null || detalleVentas.Count == 0)
                throw new Exception("La venta debe contener al menos un producto.");

            if (cambio <= 0)
                throw new Exception("El dinero recibido no puede ser menor que el total a pagar.");

            try
            {
                Venta venta = new Venta(0, fechaVenta, total, detalleVentas);
                return VentaDao.InsertarVenta(venta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error insertando venta: " + ex.Message);
            }
        }

    }
}
