# invoiceWebApi - Kellerman, Haustein, Pastore

Para la utilización óptima de la api web es necesario:

Instalar Visual Studio Community 2015:

https://www.visualstudio.com/vs/community/

Conectar la BD que el cliente vaya a utilizar de la siguiente manera:

1-Abrir el archivo Web.config

2-Localizar el tag < connectionStrings>

3-Modificar en la linea < add... data-source=DIRECCION DEL SERVIDOR ... >

Para obtener el nombre del servidor, debe ingresar al gestor de base de datos que posea en su PC. En este caso el servidor es “FEDEHAUST\SQLEXPRESS”

(Para una mejor visualización de la siguiente imagen, ábrala en otra pestaña si se encuentra en el navegador, o aumente el zoom del visualizador de archivos que esté utilizando)

El sector marcado con rojo es lo que se visualiza en la siguiente imagen.

4-Guardar el archivo

Opción 2:

-Ir a la pestaña view/Server Explorer (Explorador de servidores)

-Cambiar la BD y el servidor.

Se abrirá la ventana para agregar conexión.

En este caso el servidor es “FEDEHAUST\SQLEXPRESS” (Como vimos con anterioridad se obtiene desde el gestor de base de datos fácilmente)

Elegimos la base de datos que queremos utilizar, en nuestro caso usamos la de prueba “parcial2BaseDatos” (El archivo bd_schema.sql contiene el script para generar a la misma)

Luego de esto, tenemos nuestra base conectada

Probar api:

Recomendamos el uso de POSTMAN:

https://chrome.google.com/webstore/detail/postman/fhbjgbiflinjbdggehcddcbncdddomop

Con este enlace accedemos a la tienda de Chrome (Debemos tener instalado el navegador Chrome para poder instalarlo)

Hacemos clic en el icono de la aplicación

Si no tenemos cuenta, podemos generar una para utilizar la aplicación, o podemos usarla sin iniciar sesión (Para nuestra prueba es indiferente).

En el lugar resaltado colocamos las URLs

Se pueden probar varios métodos, en nuestro caso vamos a usar GET y POST

Ejecutamos desde Visual Studio la API (Esto abrirá el navegador Internet Explorer, como veremos más adelante, se puede hacer lo mismo solo con él, para una mejor visualización, primero usaremos POSTMAN)

URL:

GET: localhost:56298/api/invoice/{id} -> muestra la informacion de la factura (sustituir “{id}” por el valor de identificación que posee el registro que queremos consultar de la base de datos).

URL:

POST: localhost:56298/api/invoice -> recibiendo desde la app mediante una llamada a ajax un objeto "invoice" la misma guarda la informacion en la BD

URL:

POST: localhost:56298/api/invoice/details -> recibiendo desde la app mediante una llamada a ajax un objeto "invoice_detail" la misma guarda la informacion en la BD

En el caso de no utilizar POSTMAN, colocando las mismas URL en el navegador, obtendremos los JSON para descargarlos

{"invoice_detail":[{"articleId":1,"articleName":"Articulo","articlePrice":350.0,"invoiceNumber":1},{"articleId":2,"articleName":"Cosito","articlePrice":200.0,"invoiceNumber":1}],"invoiceNumber":1,"invoiceDate":"2016-10-10","customerName":"Empresa SRL","invoiceTotalValue":200}

# Fin del documento
