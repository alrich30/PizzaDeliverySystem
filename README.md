# PizzaDeliverySystem

Sistema de pedidos de pizza con API en ASP.NET Core 8, Entity Framework Core y MySQL. Incluye un cliente web en `Client-js`.

## Requisitos

- .NET 8 SDK
- MySQL 8

## Configuración

1. Copia `PizzaDeliverySystem/appsettings.example.json` a `PizzaDeliverySystem/appsettings.json`.
2. Configura `ConnectionStrings:PizzaDbV2` con tu servidor de MySQL y reemplaza `Jwt:Key` por una clave aleatoria de al menos 32 caracteres. El archivo local está excluido de Git.
3. Abre `PizzaDeliverySystem.sln` en Visual Studio y restaura los paquetes NuGet.
4. Aplica las migraciones de Entity Framework Core y ejecuta el proyecto web `PizzaDeliverySystem`.
5. Para usar el cliente, abre `Client-js` con un servidor local y ajusta `Client-js/config.js` a la dirección HTTPS de la API si es necesario.

## Estructura

- `PizzaDeliverySystem`: API web y controladores.
- `PizzaDeliverySystem.Application`: servicios y DTO.
- `PizzaDeliverySystem.Domain`: entidades y contratos.
- `PizzaDeliverySystem.Infrastructure`: acceso a datos y migraciones.
- `Client-js`: interfaz web.
