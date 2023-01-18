# AdminBackend
 
### Tecnologias:

- .NET Core 6
- Dapper

### Cómo ejecutar el proyecto Web API 

Para ejecutar un proyecto Web API .NET Core 6, sigue los siguientes pasos:

1. Asegúrate de tener instalado el SDK de .NET Core 6 en tu computadora. Puedes descargarlo desde el sitio web oficial de Microsoft.

2. Descarga o clona el proyecto en una carpeta local en tu computadora.

3. Abre la línea de comandos (cmd o powershell) y navega hasta la carpeta del proyecto.

4. Ejecuta el comando `dotnet build` para compilar el proyecto.

5. Una vez compilado el proyecto, ejecuta el comando `dotnet run` para iniciar la aplicación.

6. Si todo ha salido bien, la aplicación debería iniciarse y estar disponible en el navegador en la dirección `http://localhost:25608/swagger` (o en otra dirección especificada en el proyecto).

7. Para probar las diferentes rutas y verificar que tu API está funcionando correctamente, puedes utilizar una herramienta como Postman para hacer peticiones HTTP a la API.

8. Si quieres generar un archivo ejecutable para distribuir tu proyecto, ejecuta el comando `dotnet publish -c Release`. Esto generará un archivo ejecutable en la carpeta `bin/Release/netcoreapp6.0/publish/`.

Nota: Recuerda que para acceder a las rutas de tu API, debes utilizar la url de tu proyecto seguida de la ruta deseada.


