ExploradorDePaises - Proyecto (lista de países) - listo para Visual Studio 2022

Instrucciones rápidas:
1. Descomprime la carpeta y abre 'ExploradorDePaises.sln' en Visual Studio 2022.
2. Asegúrate de tener instalado .NET 6 SDK (dotnet --list-sdks debe mostrar 6.0.x).
3. Selecciona el perfil 'ExploradorDePaises' o 'IIS Express' en la barra superior y presiona F5.
4. La API estará disponible en:
   - https://localhost:5001/api/paises  (lista)
   - https://localhost:5001/api/paises/{codigo}  (detalles por código)
   - https://localhost:5001/api/paises/buscar/{nombre}  (buscar por nombre)
   - https://localhost:5001/api/paises/favoritos  (POST para agregar favorito)
   - https://localhost:5001/api/paises/favoritos/{usuario}  (GET favoritos por usuario)

Postman:
- Importa 'ExploradorDePaises.postman_collection.json' y usa la variable {{baseUrl}} = https://localhost:5001
