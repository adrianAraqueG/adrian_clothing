:shipit: Safe Clothing
==================================================

Este repositorio contiene una APP Backend en ASP.NET llamada S.C.

🎱 Requerimientos
-------------------

#### Endpoints requeridos
1. Listar los insumos que pertenecen a una prenda especifica. El usuario debe ingresar el código de la prenda.
2. Listar los Insumos que son vendidos por un determinado proveedor cuyo tipo de persona sea Persona Jurídica. El usuario debe ingresar el Nit de proveedor.
3. Listar todas las ordenes de producción cuyo estado se en proceso.
4. Listar los empleados por un cargo especifico. Los cargos que se encuentran en la empresa son: Auxiliar de Bodega, Jefe de Producción, Corte, Jefe de bodega, Secretaria, Jefe de IT.
5. Listar las ordenes de producción que pertenecen a un cliente especifico. El usuario debe ingresar el IdCliente y debe obtener la siguiente información:
   ->IdCliente, Nombre, Municipio donde se encuentra ubicado.
   ->Nro de orden de producción, fecha y el estado de la orden de producción (Se debe mostrar la descripción del estado, código del estado, valor total de la orden de producción.
   ->Detalle de orden: Nombre de la prenda, Código de la prenda, Cantidad, Valor total en pesos y en dólares.
6. Listar las ventas realizadas por un empleado especifico. El usuario debe ingresar el Id del empleado y mostrar la siguiente información.
   ->Id Empleado
   ->Nombre del empleado
   ->Fecturas : Nro Factura, fecha y total de la factura.
7. Listar los productos y tallas del inventario. La consulta debe mostrar el id del inventario, nombre del producto, tallas y cantidad de cada talla.

#### Requerimientos Funcionales
El proyecto de administración de veterinaria debe cumplir con los siguientes requerimientos funcionales:

1. Implementar restricción de peticiones haciendo uso de limitaciones de peticiones por IP.
2. Implementar protección a los endPoints haciendo uso de JWT y roles de usuario.
3. Implementar esquema de versionado de Api que facilite el proceso de implementación de nuevos endpoints sin afectar el funcionamiento de las aplicaciones externas que consumen los servicios del Api.
4. Implementar endpoints que permitan realizar el proceso de CRUD en cada uno de los controladores del backend.
5. Debido al gran volumen de información que la empresa procesa diariamente se requiere que los endpoints encargados de consultar el contenido de las tablas implementen sistema de paginación.

🔧 Instalación
-------------------
1. Clonar el repo
2. Importar default_db.sql a nuestro MySQL usando cualquier gestor de bases de datos.
3. Configurar la conexión en ´appsettings.json´ (NO cambiar nombre de database)
4. dotnet run 🚀☘️

## API Reference 🛰️
Antes de poder hacer consultas debemos loguearnos.
```
    POST api/usuario/login
    {
      "Username": "admin",
      "Password": "admin"
    }
```