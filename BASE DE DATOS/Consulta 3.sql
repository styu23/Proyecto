create PROC sp_reporte_articulos_deportivosasbeginselect producto.id_producto, producto.nombre, producto.cantidad, producto.precio_compra, producto.precio_venta, proveedor.nombre as proveedor from productoinner join proveedoron producto.id_proveedor = proveedor.id_proveedorend

select * from cliente