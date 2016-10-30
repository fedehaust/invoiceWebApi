# invoiceWebApi - Kellerman, Haustein, Pastore

Para la utilización óptima de la api web es necesario: 

Instalar Visual Studio Community 2015: 

https://www.visualstudio.com/vs/community/

Conectar la BD que el cliente vaya a utilizar de la siguiente manera:

1-Abrir el archivo Web.config

![exploradordesoluciones](https://cloud.githubusercontent.com/assets/13921860/19838782/2f98d300-9eb5-11e6-8b05-c9483d435041.png)

2-Localizar el tag < connectionStrings> (Para una mejor visualizacion, abra la imagen en otra pestaña del navegador, o aumente el zoom)

![webconfiglocalizartag](https://cloud.githubusercontent.com/assets/13921860/19838809/b7c9ab82-9eb5-11e6-9b64-5cc3055128aa.png)

3-Modificar en la linea < add... data-source=DIRECCION DEL SERVIDOR ... >

![cabiardatasouerced](https://cloud.githubusercontent.com/assets/13921860/19838864/8abcf576-9eb6-11e6-8c53-d1ea97638a27.png)

Para obtener el nombre del servidor, debe ingresar al gestor de base de datos que posea en su PC. En este caso el servidor es “FEDEHAUST\SQLEXPRESS”

![entrarasql](https://cloud.githubusercontent.com/assets/13921860/19838835/1de72f5c-9eb6-11e6-84db-45d0d51f2b97.png)

![tomarnombreserver](https://cloud.githubusercontent.com/assets/13921860/19838847/5cc0aa8c-9eb6-11e6-8789-738a7a83c32b.png)

4-Guardar el archivo

![guardarwebconfig](https://cloud.githubusercontent.com/assets/13921860/19838870/c052909c-9eb6-11e6-8001-4ef05c216d8e.png)

Opción 2: 

-Ir a la pestaña view/Server Explorer (Explorador de servidores)

![irexploradordeservidores](https://cloud.githubusercontent.com/assets/13921860/19838880/fe747b06-9eb6-11e6-887d-b828f5c2f62d.png)

-Cambiar la BD y el servidor.

![irexploradordeservidores](https://cloud.githubusercontent.com/assets/13921860/19838880/fe747b06-9eb6-11e6-887d-b828f5c2f62d.png)

Se abrirá la ventana para agregar conexión.

![agregarconexion1](https://cloud.githubusercontent.com/assets/13921860/19838944/1add044c-9eb8-11e6-96c9-a59d1866b94f.png)

En este caso el servidor es “FEDEHAUST\SQLEXPRESS” (Como vimos con anterioridad se obtiene desde el gestor de base de datos fácilmente)

![agregarconexion2](https://cloud.githubusercontent.com/assets/13921860/19838947/28a05cd2-9eb8-11e6-9c9b-63c0a6373d64.png)


Elegimos la base de datos que queremos utilizar, en nuestro caso usamos la de prueba “parcial2BaseDatos” (El archivo bd_schema.sql contiene el script para generar a la misma)

![agregarconexion3](https://cloud.githubusercontent.com/assets/13921860/19838948/31fffb98-9eb8-11e6-9d16-23677ddbf59c.png)

![agregarconexion4](https://cloud.githubusercontent.com/assets/13921860/19838950/3c77e144-9eb8-11e6-8b1d-82ebb5d6bafc.png)

Luego de esto, tenemos nuestra base conectada

![conectadoexploradordeservidores](https://cloud.githubusercontent.com/assets/13921860/19838953/627b1410-9eb8-11e6-9026-698085c80177.png)

Probar api: 

Recomendamos el uso de POSTMAN:

https://chrome.google.com/webstore/detail/postman/fhbjgbiflinjbdggehcddcbncdddomop

Con este enlace accedemos a la tienda de Chrome (Debemos tener instalado el navegador Chrome para poder instalarlo)

![agregarpostman1](https://cloud.githubusercontent.com/assets/13921860/19838973/cd0c3930-9eb8-11e6-8934-33386afdded2.png)

![agregarpostman2](https://cloud.githubusercontent.com/assets/13921860/19838996/276b8b9c-9eb9-11e6-9806-9581d8102237.png)

Hacemos clic en el icono de la aplicación

![iniciarpostman1](https://cloud.githubusercontent.com/assets/13921860/19839043/10cddfb0-9eba-11e6-857b-ee6eeaf79799.png)

![iniciarpostman3](https://cloud.githubusercontent.com/assets/13921860/19839088/d4a1d126-9eba-11e6-9eea-ca546baf3cb7.png)

Si no tenemos cuenta, podemos generar una para utilizar la aplicación, o podemos usarla sin iniciar sesión (Para nuestra prueba es indiferente).

![iniciarpostman2](https://cloud.githubusercontent.com/assets/13921860/19839046/16d96640-9eba-11e6-9026-db8c644eaf53.png)

En el lugar resaltado colocamos las URLs
 
![iniciarpostman5](https://cloud.githubusercontent.com/assets/13921860/19839065/6d2b56ca-9eba-11e6-9e26-910a66d0c4e2.png)

Se pueden probar varios métodos, en nuestro caso vamos a usar GET y POST

![iniciarpostman4](https://cloud.githubusercontent.com/assets/13921860/19839051/226463e8-9eba-11e6-9788-8f0f9e55bdb3.png)

Ejecutamos desde Visual Studio la API (Esto abrirá el navegador Internet Explorer, como veremos más adelante, se puede hacer lo mismo solo con él, para una mejor visualización, primero usaremos POSTMAN)

![ejecutarapi](https://cloud.githubusercontent.com/assets/13921860/19839118/3dc03a4e-9ebb-11e6-958e-31ed560bdcb5.png)

URL:

GET: localhost:56298/api/invoice/{id} -> muestra la informacion de la factura (sustituir “{id}” por el valor de identificación que posee el registro que queremos consultar de la base de datos).

![metodogetpostman](https://cloud.githubusercontent.com/assets/13921860/19839185/1ecc4e92-9ebc-11e6-9c53-d2383fb063a6.png)

URL:

POST: localhost:56298/api/invoice -> recibiendo desde la app mediante una llamada a ajax un objeto "invoice" la misma guarda la informacion en la BD

![metodopostconparametros1](https://cloud.githubusercontent.com/assets/13921860/19839881/2286bf74-9ec9-11e6-8461-bc3a4fa2c707.png)

Parametros de ejemplo (Seleccionar Body/x-www-form-urlencoded):

![parametrospost1](https://cloud.githubusercontent.com/assets/13921860/19839918/0259231c-9eca-11e6-93e3-53071eec70db.png)

invoiceDate --> 2016-10-20

customerName --> Empresa TodoGud

invoiceTotalValue --> 200

URL:
 
POST: localhost:56298/api/invoice/details -> recibiendo desde la app mediante una llamada a ajax un objeto "invoice_detail" la misma guarda la informacion en la BD

![metodopostconparametros2](https://cloud.githubusercontent.com/assets/13921860/19839885/415cbb2e-9ec9-11e6-8469-86b5475a4f6e.png)

Parametros de ejemplo (Seleccionar Body/x-www-form-urlencoded):

![parametrospost2](https://cloud.githubusercontent.com/assets/13921860/19839919/09e61dec-9eca-11e6-8b90-2049894493f0.png)

invoiceNumber --> 1

articleName --> Cosito

articlePrice --> 200

En el caso de no utilizar POSTMAN, colocando la misma URL en el navegador, obtendremos el JSON solo para el metodo GET

![metodoget1intexp](https://cloud.githubusercontent.com/assets/13921860/19839518/46fa4daa-9ec2-11e6-82b0-e1fa082f777c.png)

![metodoget2intexp](https://cloud.githubusercontent.com/assets/13921860/19839527/58859c78-9ec2-11e6-82a3-e280caf2e1e9.png)

![metodoget3intexp](https://cloud.githubusercontent.com/assets/13921860/19839547/c06b46e4-9ec2-11e6-921b-9a544dedeae3.png)

{"invoice_detail":[{"articleId":1,"articleName":"Articulo","articlePrice":350.0,"invoiceNumber":1},{"articleId":2,"articleName":"Cosito","articlePrice":200.0,"invoiceNumber":1}],"invoiceNumber":1,"invoiceDate":"2016-10-10","customerName":"Empresa SRL","invoiceTotalValue":200}

# Fin del documento

