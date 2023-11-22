# Despliegue de API con Docker y Entity Framework Core
Este documento describe los pasos necesarios para desplegar una API .NET Core versión 7.0.14 utilizando Docker y Entity Framework Core 7.0.14 con SQL Server.

## Requisitos Previos
Antes de comenzar, asegúrate de tener instalado lo siguiente:

Docker
.NET SDK (versión 7.0.14)


## Pasos para el Despliegue
Iniciar servicios con Docker Compose:
Ejecuta el siguiente comando para iniciar los servicios definidos en tu archivo docker-compose.yml:

docker-compose up -d

## Crear Migraciones Iniciales:
Utiliza Entity Framework Core para generar las migraciones iniciales. Este paso configura la base de datos según tu modelo:

dotnet ef migrations add InitialCreate

## Actualizar la Base de Datos:
Aplica las migraciones a la base de datos para reflejar el estado actual del modelo:

dotnet ef database update

## Acceso a la API
Una vez completados estos pasos, tu API estará desplegada y accesible en localhost:8080. Asegúrate de verificar la conexión y el correcto funcionamiento de la API en este puerto.

## Solución de Problemas
Si encuentras algún problema durante el despliegue, revisa los logs de Docker y asegúrate de que todos los servicios necesarios estén ejecutándose correctamente. También verifica la configuración de puertos y conexiones a la base de datos.


