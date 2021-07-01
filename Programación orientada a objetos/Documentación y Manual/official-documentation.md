# Documentación oficial
## Aspectos técnicos
### Desarrollado utilizando:

- Windows 10
- Visual Studio 2019
- SQL Server
- SQL Server Management Studio

### Paquetes y librerías:

- .NET Core 5.0
- LiveCharts.WinForms.NetCore3 (0.9.7)
- Microsoft.EntityFrameworkCore (5.0.7)
- Microsoft.EntityFrameworkCore.Design (5.0.7)
- Microsoft.EntityFrameworkCore.SqlServer (5.0.7)
- Microsoft.EntityFrameworkCore.Tools (5.0.7)

## Patrones de diseño

### **Repository**
- La implementación del modelo repositorio facilita la creación de los diferentes servicios que rigen el comportamiento de las principales entidades del proyecto.
### **View Model**
- Utilizado principalmente en los "data grid view" del proyecto, facilitan dar un formato de salida estándar para los datos que provienen de la base de datos.

## Instalación
- Para ejecutar la solución es necesario correr el script projectDB.sql para tener en nuestro sistema la base de datos GestorVaccination
- Se recomienda instalación en SQLEXPRESS
- Correr el programa setup.exe
- Dar siguiente a todo
- Abrir el programa Project_Poo