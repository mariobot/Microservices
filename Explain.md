# Microservicios

### Como esta organizado el proyecto

El proyecto esta dividido en varios grupos de proyectos. (32~) La siguientes son las carpetas de SRC

## ApiGetaways
Se crea una puerta de enlace de API por cada proyecto de implementacion por eso se crea un proyecto para la parte web, como otro para la parte Mobil, esto con la finalidad de segmentar funcionalidades y operaciones en el Api Getaway. 
Envoy permite enrutar las peticiones, de acuerdo a una arquitectura de proxy.

## Mobile 
Maneja toda la implementacion de Xamarin para ejecutar el aplicativo. 

## Web
Maneja toda la implementacion de web dil aplicativo entre la cual esta
#### WebMVC 
IMPLEMENTACION REALIZADA EN ASP MVC
#### WebSPA 
IMPLEMENTACION REALIZADA CON ANGULAR
#### WebStatus 
Swager para ver los estados de los servicios y del proyecto en general
#### WebhookCliet

## Services
Los servicios estan divididos en la carpeta de Servicios los cuales estan expuestos por medio de apis en su mayoria para los diferentes proyectos.

#### Basket
Microservicio para el carrito de compras
#### Catalog
Microservicio para administrar el catalogo de productos
#### Identidad
Microservicio para autenticacion y seguridad del sistema
#### Location
Microservicio para servicios de Localizacion
#### Marketing
Microservicio para campañas y implementar la localizacion
#### Ordering
Microservicio para pedidos y compradores
#### Payment
Microservicio para la pasarela de pagos
#### Webhooks
Microservicio de webhooks msg. 

## Test
Almacena los proyectos de pruebas unitarias y funcionales para cada uno de los proyectos. adicional a esto cada proyecto tiene su propio subproyecto de pruebas. para efectos de implementacion rapida estos proyectos han sido deshabilitados de la solucion original ya que nos basamos mas en la implementacion que en la parte de pruebas. 

# Tenga en cuenta
Para ejecutar el proyecto es recomendable deshabilitar todos los proyectos de Testing. 
Debe tener instalado Docker para Windows como Visual Studio 2019
Tambien puede acceder y ejecutar con VS Code pero es un poco mas dispendiosa la ejecucion. 

####
####
####
####
####
####
####






























----------------------------------------------------------------------------
# Encabezado h1
## Encabezado h2
### Encabezado h3
#### Encabezado h4
##### Encabezado h5
###### Encabezado h6

**Este texto está en negrita**
*Este texto está en cursiva*
~~Este texto está tachado~~
***Todo este texto es importante***

para citar texto utilice >
> Mas vale uno en mano que mil volando

#Formatear text o codigo en su propio bloque
```
git status
git add
git commit
```
#Formatear codigo en su lenguaje
### C# Code
``` C#
public string Consultar(string nombre)
{
    return DAL.Persona.Consultar(nombre);
}
```
### Python Code
``` python
def calc_position(lat,long):
    return located(lat,long)
```
### Razor Code
``` HTML+Razor
@Html.Action("Index","Home")
```
###  SQL Code
``` SQL
SELECT * FROM STUTENTS
```

Puede encontrar los lenguajes suportados en el siguiente enlace [languages](https://github.com/github/linguist/blob/master/lib/linguist/languages.yml)

#Enlaces
[PALABRA](ENLACE)
www.google.com

#Enlaces relativo
use ./ o ../ para hacer referencia al path
[Contribution guidelines for this project](docs/CONTRIBUTING.md)

#Imagenes
[![MarioBot Avatar](https://mariobot.files.wordpress.com/2009/12/mariobotavatar2.jpg?w=158&h=168)](https://mariobot.wordpress.com/)

#Listas con
- Pereira
- Colombia
- Suramerica

#Lista de tareas
- [] Subir base de datos
- [x] Crear copia de base de datos

Mencionar una persona @mariobot

Referencia a una peticion solo es necesario escribir #4567 y el numero de la peticion

Puedes agregar emojis a tu escritura al escribir :EMOJICODE:
🔉 🔧🔴
🔴 ## Mi Repositorio
La lista de emoji con los codigos los puede encontrar en: [emoji link list](https://www.webfx.com/tools/emoji-cheat-sheet/)

Para evadir un marcador puede anteponer \
tenga en cuenta \*Este Codigo\*

Tablas
| Comando | Descripción |
| --- | --- |
| git status | Enumera todos los archivos nuevos o modificados |
| git diff | Muestra las diferencias de archivo que no han sido preparadas |

| Alineado a la izquierda | Alineado en el centro | Alineado a la derecha |
| :--- | :---: | ---: |
| git status | git status | git status |
| git diff | git diff | git diff |

Links complejos
[![Support via PayPal](https://cdn.rawgit.com/twolfson/paypal-github-button/1.0.0/dist/button.svg)](https://www.paypal.me/)

[![](https://programmingapplicationinsights.files.wordpress.com/2020/02/256px-.net_core_logo.svg_.png?w=128) Get more details at **DOTNET CORE**.](https://docs.microsoft.com/en-us/dotnet/core/)
