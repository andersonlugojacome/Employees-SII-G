# Employees SII Group - ASP.NET Core MVC Application

## Descripción

Employees SII Group es una aplicación web construida con ASP.NET Core MVC para gestionar información de empleados obtenida a través de una API externa. Esta aplicación permite consultar empleados por su ID, listar todos los empleados disponibles, y calcular su salario anual en función de su salario mensual.

## Características

- **Listado de Empleados:** Muestra una lista de todos los empleados obtenidos de una API externa.
- **Búsqueda de Empleados por ID:** Permite buscar y mostrar los detalles de un empleado específico por su ID.
- **Cálculo de Salario Anual:** Calcula y muestra el salario anual de cada empleado.
- **Manejo de Errores Amigable:** Muestra mensajes de error amigables en caso de conflictos, problemas de conexión con la API, o cuando no se encuentra un empleado.

## Requisitos del Sistema

- **.NET Core SDK 8.0** o superior
- **Rider**, **Visual Studio 2017+** o cualquier otro IDE compatible con .NET Core
- **Conexión a Internet** para obtener los datos de empleados desde la API externa

## Estructura del Proyecto

```plaintext
Employees-SII-G/
│
├── Controllers/
│   ├── HomeController.cs
│
├── Models/
│   ├── Employees.cs
│   ├── ErrorViewModel.cs
│
├── DataAccess/
│   ├── ApiResponse.cs
│   ├── EmployeeService.cs
│
├── BusinessLogic/
│   ├── EmployeeCalculator.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── Privacy.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   ├── Error.cshtml
│   ├── _ViewImports.cshtml
│   ├── _ViewStart.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── README.md
