## Microservices
This Repository hold all the projects to study Microservices apply to .Net Architecture with .Net Core and .Net Framework

This list show the projects folders.

* myMicroservice.
* DockerFiles.
* Books and Doc References.
* Images

This repository collect all the practice concepts from the book .Net Microservices Architecture for Containerized .Net Applications. 

For an easy understand I collect the important concepts from de book to and resume document. 

All the documentation is writed at SPANISH for fast and easy understanding.

--------------------------------------------------------------------------------------------
## LIST OF CONCEPTS

### Volumenes
Espacio de ficheros para administrar archivos de las imagenes de docker
### Montaje de enlace
Dierccionamiento a una ubicacion fisica de fichero en el host fuera de docker
### Montaje TMPFS
Ficheros virtuales
### AMQP
Protocolo orientado a mensajes, alternativa a HTTP y REST
### Transacciones ACID
Concepto informatico en donde la data es ATOMICA, CONSISTENTE, AISLADA, DURABLE
### CQRS
Patron de base de datos donde la responsabilidad de lectura de datos se separa de la de CRUD
### Datos frios
Es cuando se saca una base da datos de copia para hacer consultas robustas que no afecten la base de datos de produccion, supongamos para sacar informes financieros de meses anteriores se replica la data de los meses anteriores en un nueva BD Datos Frios. Por lo general estas bases de datos no estan actualizadas con los ultimos registos. 
### Teorema CAP
Teorema computacional en donde un sistema distribuido no puede garantizar consistencia, disponibilidad, tolerancia al particionad al mismo tiempo, como minimo 2 de las anteriores 3. 
### Modelos de dominio
Representaciones de modelos de acuerod al microservicio, Ejmplo un Usuario puede ser diferente en los microservicios de Pagos, Servicio al cliente, Ordenes, Conferencias
### Puerta de enlace de API
Proyecto proxy o fachada para la administracion, enrutamiento y obtimizacion de peticiones de las APIs
### Comunicacion directa al Microservicio
Conectividad directa entre el aplicativo final y el microservicio careciendo de una Puerta de enlace de API.
### Azure API Managment
Herramienta en azure para la administracion de APIS
### BFF back end para front end
Patron donde se crea una Puerta de enlace de API por cada Aplicacion de cliente asi de esta manera cada aplicacion final tiene su correspondiente Puerta de enlace de API. 
### Ocelot 
Puerta de enlace de API de codigo abierto y facil implementacion para proyectos no dependientes AZURE
### MediatR
Libreria para reducir la dependencia de clases entre funcionalidades
### Microfontend
Patron de presentacion en donde se programan componentes visuales independientementes asociadas cada uno a un microservicio diferente. 
### Kubernetes 
Sirve para administrar clusteres, tambien como orquestador y administrador de 
### Azure Kubernetes Service
Es la solucion de Azure de Kubernetes
### Helm
Programa para administrar clusters complejos de Kibernetes
### Azure Dev Space
Proporciona un lugar donde almacenar contenedores de manera comun entre programadores.
### Desarrollo bucle
Especifica todo el flujo de desarrollo de los programadores que esta excento del interaccion con DevOps
### Dockerfile
Archivo con la configuracion necesaria para iniciar una imagen, esta se recomienda debe ir en la carpeta raiz de la implementacion
### Docker-compose.yml
Archivo para administrar los orquestadores, varias configuraciones de microservicios



