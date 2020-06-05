# Microservices
This Repository hold all the projects to study Microservices apply to .Net Architecture with .Net Core and .Net Framework

* [Books](https://github.com/mariobot/Microservices/tree/master/Books)
* [DockerFiles](https://github.com/mariobot/Microservices/tree/master/DockerFiles)
* [SQLServer](https://github.com/mariobot/Microservices/tree/master/SQLServer)
* [eShopOnContaines](https://github.com/mariobot/Microservices/tree/master/eShopOnContainers)
* [myMicroservice](https://github.com/mariobot/Microservices/tree/master/myMicroservice)

This repository collect all the practice concepts from the book .Net Microservices Architecture for Containerized .Net Applications. For an easy understanding I collect the important concepts from de book to a resume document. 

*All the documentation was writed at SPANISH for fast and easy understanding.*
[Explicación del proyecto](https://github.com/mariobot/Microservices/tree/master/Explain.md)
--------------------------------------------------------------------------------------------
## LISTA DE CONCEPTOS 
--------------------------------------------------------------------------------------------
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
### Bus de eventos
Hace referencia a la comunicacion entre microservicios y hace referencia a la comunicacion asincrona entre microservicios
### SRP 
Principio de responsabilidad unica
### Arquitectura orientada a eventos EDA
Principio donde se orienta el flujo a los eventos cambiantes de los objetos 
### Swashbuckle
Libreria para generar documentacion automatica en swagger
### NSwag
Otra libreria similar a Swagger que realiza las mismas funciones
### Azure Key Vault
Servicio para almacenar y administrar valores secretos de la aplicacion. Por ejemplo cadenas de conexion, tokens, keys etc
### Control de versiones de API
Tecnica para versionar las implementaciones de API, puede ser por URL, cadena de consulta o version en el encabezado
### HATEOAS
Hipertexto como motor del estado de la aplicación. La respuesta a cada solicitud contiene la información necesaria para pasar de un estado a otro, Las respuestas API pueden sugereir los proximos llamdos. 
### AutoRest
Herramienta para llamar por linea de comandos clases e implementaciones API. 
### .dockerignore 
Se usa para omitir archivos.
### docker-compose.yml 
Se usa para crear microservicios
### docker-compose.override.yml docker-compose.prod.yml docker-compose-test.yml
Se usa para configurar el entorno de microservicios
### ${MY_VAR}
Forma de llamar una variable de entorno dentro de las configuraciones de Docker
### Redis
Es un motor de base de datos en memoria basado en tablas Hash, viene de la palabra remote dictionary service, servicio de diccionario remoto
### Eventos de integracion
Consiste en suscribir a diferentes microservicios para que respondan a eventos de un microservicio. utilizan un bus de eventos para notificar los mensajes entre diferentes microservicios
### RabbitMQ Azure Service Bus
Bus de servicios (eventos), tecnologías de mensajería de infraestructura
### NServiceBus, MassTransit y Brighter
Bus de servicios (eventos) de codigo abierto, 
### Patron Observador
Un objeto proporciona informacion de los eventos a otros eventos interesados
### Patron publicacion/suscripcion Pub/Sus
Funciona igual que el patron observador salvo que utiliza un componente adicional llamado "agente", "mensaje de agente" o "bus de eventos", estos presentan la mejora de desvincular las dependencias gracias a los agentes. el publicador y los suscriptores se desvinculan gracias al bus de eventos o al mensaje de agente mencionados.
### Pruebas unitarias
Corresponde a pruebas respecto a una sola funcionalidad.  
### Pruebas de integracion
Corresponde a pruebas entre diferentes funcionalidades por ejemplo BD, Instancias, Controladores todas dentro de un flujo.
### Pruebas funcionales
Corresponde a pruebas de todo un componente, Esto garantiza que la aplicación funcione según lo esperado
desde la perspectiva del usuario
### Pruebas de servicios
Corresponde a pruebas complejas de un componente de microservicio teneindo en cuenta pruebas de conectividad, puesta de servicio multiple, concurrencia, inicializacion de imagen entre otras.
### IWebHost
Interface para ejecutar tareas en segundo plano o background, implementada en .net core 1.0 y 2.0
### IHost
Interface para ejecutar tareas en segundo plano versiones posteriores .net core 2.0 es mas ligero y carece de todas las caracteristicas de HTTP, MVC o API Web. En conclusion si las tareas en segundo plano no tienen nada que ver con HTTP 
debe usar IHost.
### Commands & Queries
Especifica un patron donde los Commands tienen la responsabilidad de las actualizaciones eliminaciones e inserciones mientras que Queries tiene la responsabilidad exclusiva de consultas al dominio de datos. 
### Dapper
Es un ORM para .Net mas liviano y ligero
### DTO
Objeto de transferencia de datos, Data Transfer Object
### ProducesResponseType
Anotacion para proporcionar mayor informacion a las APIs sobre el tipo de respuesta. Es utilizado por Swashbuckle par adicionar la descripcion de la API.
### Persistencia de datos
Almacenamiento y actualizacoin de datos
### POCO
Acronimo de Plain Old CLR Object, Son clases simples que no dependen de un Framework en especial
### DDD Domain-Driven Design (Diseño guiado por el Dominio)
Propone un modelado basado en la realidad de negocio con relación a sus casos de uso. En el contexto de la creación de aplicaciones, DDD hace referencia a los problemas como dominios. Describe áreas con problemas independientes como contextos delimitados. Lo importante no son los patrones en sí, sino organizar el código para que esté en línea con los problemas del negocio y utilizar los mismos términos empresariales (lenguaje de dominio)
### Aplication Layer - Modelo de Aplicacion
Define los trabajos que el software debe hacer y dirige los objetos de dominio expresivo para que resuelvan problemas. No contiene reglas de negocios ni conocimientos sino que solo coordina tareas y delega trabajo a colaboraciones de objetos de dominio en el siguiente nivel
### Domain model Layer - Modelo de Dominio
Responsable de representar conceptos del negocio, información sobre la situación del negocio y reglas de negocios
### Infraestructure Layer - Modelo de Infraestructura
El nivel de infraestructura es la forma en que los datos que inicialmente se conservan en las entidades de dominio (en la memoria) se guardan en bases de datos o en otro almacén permanente.
### Dominio anémico
El modelo de dominio anémico es simplemente un diseño de estilo de procedimientos. Los objetos de entidad anémicos no son objetos reales, ya que carecen de comportamiento (métodos). Solo contienen propiedades de datos y, por tanto, no se trata de un diseño orientado a objetos.
### Entidad de dominio
Corresponde a una entidad cuyo valor y comportamiento es importante para el negocio. Toda entidad o clase que sea imperativamente critica para el negocio se clasifica como una entidad de dominio. Las entidades de dominio no deben estar acopladas a la infraestructura, ni depender de EntityFramework o de alguna base de datos.
### Agregado
Describe un clúster o grupo de entidades y comportamientos que se pueden tratar como una unidad coherente. Utilizada para agrupar la logica de dominio.
### Raíz agregada
Tener varios objetos de valor y entidades secundarias, con todas las entidades y objetos trabajando de forma conjunta para implementar las transacciones y el comportamiento necesarios.
### AsReadOnly
proporcionar acceso de solo lectura mediante al método
### SeedWork 
Esta carpeta contiene las clases base personalizadas que puede usar como base de los objetos de valor y las entidades de dominio. Tambien suele ser nombrada Common, SharedKernel.
### Objeto de Valor
Son objetos que no requieren ninguna identidad ni ningún seguimiento de identidad, Deben ser inmutables.
### Enumeraciones Empresariales
Forma de implementacion de enumeraciones para logica de dominio
### Reglas invariables
Las reglas invariables se expresan como contratos y si se infringen, se generan excepciones o notificaciones. se aplican para corroborar la integridad de las entidades de dominio. 
### IValidatableObject
Proporciona la funcionalidad para invalidar un objeto, muy utilizado en MVC y API pero no aplicable para logica de dominio.
### Validación en dos pasos
hace referencia a usar la validación de nivel de campo en los objetos de transferencia de datos (DTO) de comandos y la validación de nivel de dominio dentro de las entidades.
### Evento de dominio
Es algo que ha sucedido en el dominio que quiere que otras partes del mismo dominio (en curso) tengan en cuenta. Normalmente las partes notificadas reaccionan de alguna manera a los eventos. los eventos de dominio le ayudan a expresar explícitamente las reglas de dominio, en función del lenguaje ubicuo proporcionado por los expertos de dominio. Además, los eventos de dominio permiten una mejor separación de cuestiones entre clases dentro del mismo dominio.
### Lenguaje ubicuo
Es el concepto de definir un lenguaje (hablado y escrito) que se usa por igual entre los desarrolladores y los expertos en dominios para evitar incoherencias y falta de comunicación debido a problemas de traducción y malentendidos. Verá la misma terminología en el código, las conversaciones entre cualquier miembro del equipo, las especificaciones funcionales y otras cosas. 
### Dominion de Infraestructura o Persistencia
Corresponde al proyecto encargado de los datos, todo lo pertinente a acceso de datos que se hospedan dentro de los límites
de un microservicio (es decir, la base de datos de un microservicio). Contienen la implementación real de componentes como repositorios y clases de unidad de trabajo, como los objetos DbContext de Entity Framework.
### Repositorio
Un repositorio realiza las tareas de un intermediario entre los niveles de modelo de dominio y asignación de datos, actuando de forma similar a un conjunto de objetos de dominio en memoria. Los objetos de cliente generan consultas mediante declaraciones y las envían a los repositorios para obtener las respuestas. Conceptualmente, un repositorio encapsula un conjunto de objetos almacenados en la base de datos y las operaciones que se pueden realizar en ellos, proporcionando una manera de que esté más cerca de la capa de persistencia. Además, los repositorios admiten la finalidad de separar, con claridad y en una dirección, la dependencia entre el dominio de trabajo y la asignación de datos. Recuerde que la creacion de un Repositorio debe estar asociado al agregado y no a la tabla. Es una mala practica crear un repositorio por table, debe ser un repositorio por agregado.
### Una unidad de trabajo 
Se conoce como una sola transacción que implica varias operaciones de inserción, actualización o eliminación. En otras palabras, significa que para una acción de usuario específica todas las transacciones de inserción, actualización o eliminación se administran en una única operación
### Omisión de persistencia y omisión de infraestructura
Quiere decir que la logica de dominio no depende ni esta acoplado a la infraestructura o acceso a datos. 
### Algoritmo Hi-Lo 
Asigna identificadores únicos a filas de la tabla, pero no depende del almacenaje inmediato de la fila en la base de datos. Esto le permite empezar a usar los identificadores de forma inmediata, como sucede con los identificadores de la base de datos secuencial normal.
### Persistencia No Relacional
Concepto que hace referencia a que la base de datos no esta acoplada a una estructura relacional, esto aplica para las bases de datos No relacionales o bases de datos de documentos.
### Azure Cosmos DB
Es la solucion de Microsoft propuesta para manejar bases de datos NoSQL
### ${VARIABLE:-mongodb://nosqldata}
Esta sintaxis llama a la VARIABLE de entorno en .env sino existe usa entonces mongodb://nosqldata por ejemplo
### Contenedores de Inversión de control (IoC)
Son librerias como Ninject o Autofac que permiten implementar los principios de inversion de dependencias por medio de la incersion de dependencias. 
### Principio SOLID 
Principio de responsabilidad única, Principio de abierto y cerrado, Principio de sustitución de Liskov, Principio de segregación de interfaces, Principio de inversión de dependencias
### Inyeccion de dependencias
Cuando cualquiera de los constructores tiene una dependencia de IMyCustomRepository (interfaz o abstracción), el contenedor de IoC insertará una instancia de la clase de implementación MyCustomSQLServerRepository. Esta es una descripcion practica del concepto. 
### Clase comando
Un comando es una solicitud para que el sistema realice una acción que cambia el estado del sistema. Los comandos son imperativos y se deben procesar una sola vez. Un comando no es un hecho del pasado; es solo una solicitud y, por tanto, se puede denegar. es que debe procesarse una sola vez por un único receptor. Esto se debe a que un comando es una única acción o transacción que se quiere realizar en la aplicación.
### Un mediador 
Es un objeto que encapsula el "cómo" de este proceso: coordina la ejecución en función del estado, laforma de invocar un controlador de comandos o la carga que se proporciona al controlador. Con un componente de mediador se pueden aplicar cuestiones transversales de forma centralizada y transparente aplicando elementos Decorador.
### Patron mediador
Simplifica la implementacion de Inyeccion de Dependencias para ser en funcion de una especificacion comun implementada por librerias como MediatR. 
### Resistencia 
Es la capacidad de recuperarse de errores y seguir funcionando. No se trata de evitar los errores, sino de aceptar el hecho de que se producirán errores y responder a ellos para evitar el tiempo de inactividad o la pérdida de datos.
### Patrón de interruptor. 
En este enfoque, el proceso de cliente supervisa el número de solicitudes con error. Si la tasa de errores supera el límite establecido, se activa un "interruptor" para que los intentos adicionales fallen de inmediato. (Si se producen errores en un gran número de solicitudes, esto sugiere que el servicio no está disponible y que enviar solicitudes no sirve de nada.) Tras un período de tiempo de expiración, se verifica el funcionamiento y se desactivar el interruptor.
### Conexiones Recilientes
Hace mencion a las conexiones que agrupan un grupo de ejecucuiones en conjunto para su correcto flujo. Implementaciones de beginTransactions para ejecuciones agrupadas las cuales dependan de su correcta ejecucuion para hacer commit o se comporten ante un error mediante un roolback. Transacciones. 
### IHttpClientFactory
Se puede usar para configurar y crear instancias de HttpClient en una aplicación a través de la inserción de dependencias (DI). Es la correcta implementacion del HttpClient. 
### Usos IHttpClientFactory
Uso básico, Usar clientes con nombre, Usar clientes con tipo, Usar clientes generados
### Polly
Biblioteca de control de errores transitorios y resistentes
### Estrategias de vibracion
Permite realizar reintentos de conexion de manera aleatoria para que los errores de conectividad no se realicen de manera fija por un determinado tiempo o numero de intentos sino que sea provistos de una manera aleatoria. 
### Patrón de reintento
Permite que una aplicación reintente una operación con la expectativa de que finalmente se realice correctamente. 
### El patrón de interruptor 
Impide que una aplicación realice una operación que es probable que falle pero la lógica de reintento debe ser sensible a las excepciones devueltas por el interruptor, y debe dejar de intentar repetir la operación si el interruptor indica que un error no es transitorio.
### HealthChecks
Mecanismo que permite verificar el correcto funcionamiento de una API
### hc
Ruta especificada para verificar los estados por ejemplo 0.0.0.0:0000/hc Mostrara los estados de las apis del dominio
### Un guardián 
Es un servicio independiente que puede observar el estado y la carga en varios servicios, e informar del estado de los microservicios con una consulta con la biblioteca HealthChecks 
### HealthChecks.UI
Se puede usar para mostrar los resultados de comprobación de estado de los URI configurados de manera grafica.
### OAuth 2.0 
Es un framework de autorizacion que permite acceso limitado mediante la autorizacion de un tercero.  
### ASP.NET Core Identity 
Proveedor de Identidad para ASP.Net Core puede funcionar en muchos escenarios de aplicación web en los que es adecuado almacenar información de usuario en una cookie o tambien para generar tokens de autenticacion para APIs.
### Middelware
Capa intermedia de programacion. Hace refrencia a todas las implementaciones que se ejecutan en medio de otras dos, para ser mas especificos estudie la documentacion oficial de Middleware de ASP Core. 
### JWT
Es un acronimo para referirce a JSON Web Token
### Authorize (atributo)
Anotacion para permisos dentro de los controladores para asignar un rol determinado a un controlador. puede aplicar uno o mas roles al mismo controlador. 
### Secretos
Corresponde a todas las claves privadas provistas por los proveedores, cadenas de conexion, api keys, tokens etc. Se recomienda como buena practica guardar estas claves privadas o secretos en los parametros de entorno adicional de nunca proteger esta informacion dentro de un repositorio. Existen mecanismos para adiministrar claves privadas y publicas para entornos de desarrollo como Azure Key Vault.
### AddEnvironmentVariables 
Metodo para acceder a estos valores de variables de entorno
### Secret Manager
Mecanismo para implementar secretos dentro de NET CORE. Gestione los secretos del proyecto unificados. 

--------------------------------------------------------------------------------------------------------------
*Resumen Pag 355 A modo de resumen y puntos clave, estas son las conclusiones más importantes de la guía.*

### Ventajas del uso de contenedores 
Las soluciones basadas en contenedor permiten un gran ahorro, ya que ayudan a reducir los problemas de implementación derivados de las dependencias erróneas en los entornos de producción. Los contenedores mejoran significativamente las operaciones de DevOps y producción.
El uso de los contenedores será generalizado. Los contenedores basados en Docker se están convirtiendo en el estándar de facto del sector, ya que son compatibles con los proveedores más importantes de los ecosistemas de Windows y Linux, como Microsoft, Amazon AWS, Google e IBM. El uso de Docker probablemente se ampliará a centros de datos en la nube y locales.
### Los contenedores como una unidad de implementación 
Un contenedor de Docker se está convirtiendo en la unidad de implementación estándar para cualquier aplicación o servicio basados en servidor.
### Microservicios
La arquitectura de microservicios se está convirtiendo en el método preferido para aplicaciones críticas distribuidas y grandes o complejas basadas en múltiples subsistemas independientes en forma de servicios autónomos. En una arquitectura basada en microservicios, la aplicación se basa en una colección de servicios que se desarrollan, prueban, versionan, implementan y escalan por separado. Cada servicio puede incluir cualquier base de datos autónoma relacionada.
### Diseño guiado por el dominio y SOA 
Los patrones de arquitectura de microservicios se derivan de la arquitectura orientada a servicios (SOA) y del diseño guiado por el dominio (DDD). Al diseñar y desarrollar microservicios para entornos con necesidades y reglas empresariales en evolución, es importante tener en cuenta los enfoques y los patrones DDD.
### Retos de los microser vicios 
Los microservicios ofrecen muchas capacidades eficaces, como la implementación independiente, los límites de subsistema seguros y la diversidad de tecnología. Sin embargo, también suponen muchos retos nuevos relacionados con el desarrollo de aplicaciones distribuidas, como los modelos de datos fragmentados e independientes, la comunicación resistente entre microservicios, la coherencia final y la complejidad operativa que comporta agregar la información de registro y supervisión de varios microservicios.
Estos aspectos presentan un nivel de complejidad mucho mayor que una aplicación monolítica tradicional. Comoresultado, solo algunos escenarios específicos son adecuados para las aplicaciones basadas en microservicio. Estas incluyen aplicaciones grandes y complejas con varios subsistemas en evolución. En estos casos, merece la pena invertir en una arquitectura de software más compleja, ya que la agilidad y el mantenimiento de la aplicación serán mejores a largo plazo.
### Contenedores para cualquier aplicación 
Los contenedores son prácticos para los microservicios, pero también pueden resultar útiles para las aplicaciones monolíticas basadas en el .NET Framework tradicional, al usar contenedores de Windows. Las ventajas de usar Docker, como solucionar muchos problemas relacionados con el paso de la implementación a la producción y proporcionar entornos de desarrollo y prueba vanguardistas, se aplican a muchos tipos diferentes de aplicaciones.
### CLI frente a IDE 
Con herramientas de Microsoft, puede desarrollar aplicaciones .NET en contenedores con su método preferido. Puede desarrollar con una CLI y un entorno basado en editor mediante la CLI de Docker y Visual Studio Code. O bien, puede usar un enfoque centrado en IDE con Visual Studio y sus características exclusivas para Docker, como la depuración de múltiples contenedores.
### Aplicaciones en la nube resistentes 
En los sistemas basados en la nube y en los sistemas distribuidos en general, siempre hay el riesgo de error parcial. Puesto que los clientes y los servicios son procesos independientes(contenedores), es posible que un servicio no pueda responder de forma oportuna a la solicitud de un cliente. Por ejemplo, podría ser que un servicio estuviera inactivo a causa de un error parcial o por mantenimiento, que estuviera sobrecargado y respondiera lentamente a las solicitudes o bien que simplemente fuera inaccesible
durante un breve tiempo debido a problemas de red. Por tanto, una aplicación basada en la nube debe estar preparada para dichos errores y disponer de una estrategia para responder a los mismos. Estas estrategias pueden incluir aplicar directivas de reintento (volver a enviar mensajes o solicitudes) e implementar patrones de interruptor para evitar una carga exponencial de solicitudes repetidas. Básicamente, las aplicaciones basadas en la nube deben tener mecanismos resistentes, ya sean personalizados o basados en la infraestructura de nube, como los de alto nivel de orquestadores o buses de servicio.
### Seguridad 
Nuestro mundo moderno de contenedores y microservicios puede exponer nuevas vulnerabilidades. Existen varias formas de implementar la seguridad de la aplicación básica, basada en la autenticación y la autorización. Sin embargo, la seguridad del contenedor debe tener en cuenta otros componentes clave que resultan en aplicaciones intrínsecamente más seguras. Un elemento fundamental de crear aplicaciones más seguras es tener una forma segura de comunicarse con otros sistemas y aplicaciones, algo que a menudo requiere credenciales, tokens, contraseñas y demás, que normalmente se denominan secretos de la aplicación. Cualquier
solución segura debe seguir los procedimientos recomendados de seguridad, como cifrar secretos mientras están en tránsito y en reposo e impedir que los secretos se filtren cuando la aplicación final los consuma. Esos secretos deben almacenarse y guardarse de forma segura.
### Orquestadores
Los orquestadores basados en contenedores, como Azure Kubernetes Service y Azure Service Fabric, representan una parte fundamental de todo microservicio significativo y aplicación basada en contenedores. Estas aplicaciones llevan consigo gran complejidad, necesidades de escalabilidad y evolucionan constantemente. En esta guía se han presentado orquestadores y su rol en las soluciones basadas en microservicio y contenedor. Si sus necesidades de aplicación lo están dirigiendo hacia aplicaciones en contenedores complejas, le resultará útil para buscar recursos adicionales que le permitan obtener más información sobre los orquestadores.




                                                                                *Si llego hasta este punto y leyo la mayoria de la documentacion lo felicito.*

                                                                                *Redactado por Mario Botero*
                                                                                *[@Mariobot](https://www.twitter.com/mariobot)*
                                                                                *[wordpres.mariobot.com](https://wordpres.mariobot.com)*







