🔧 Gestión de Proyectos — API REST
Backend de la aplicación de gestión de proyectos para equipos de consultoría. Construido con ASP.NET Core 8, Entity Framework Core y SQLite.

🚀 Tecnologías utilizadas
TecnologíaUsoASP.NET Core 10Framework principal de la APIEntity Framework CoreORM para acceso a base de datosSQLiteBase de datos localSwagger / OpenAPIDocumentación y prueba de endpoints

📁 Estructura del proyecto
GestionProyectos/
├── Controllers/
│   ├── ProyectosController.cs     # CRUD de proyectos
│   ├── TareasController.cs        # CRUD de tareas por proyecto
│   └── ComentariosController.cs   # CRUD de comentarios por proyecto
├── Data/
│   └── AppDbContext.cs            # Contexto de base de datos
├── Models/
│   ├── Proyecto.cs                # Modelo de proyecto
│   ├── Tarea.cs                   # Modelo de tarea
│   └── Comentario.cs              # Modelo de comentario
├── Migrations/                    # Migraciones de EF Core
├── appsettings.json               # Configuración de la app
└── Program.cs                     # Punto de entrada y configuración

📡 Endpoints disponibles
Proyectos
MétodoEndpointDescripciónGET/api/proyectosListar todos los proyectosGET/api/proyectos/{id}Obtener un proyecto por IDPOST/api/proyectosCrear un nuevo proyectoPUT/api/proyectos/{id}Editar un proyectoDELETE/api/proyectos/{id}Eliminar un proyecto
Tareas
MétodoEndpointDescripciónGET/api/proyectos/{id}/tareasListar tareas de un proyectoPOST/api/proyectos/{id}/tareasAgregar tarea a un proyectoPUT/api/proyectos/{id}/tareas/{tareaId}Editar una tareaDELETE/api/proyectos/{id}/tareas/{tareaId}Eliminar una tareaPATCH/api/proyectos/{id}/tareas/{tareaId}/toggleMarcar tarea como hecha/pendiente
Comentarios
MétodoEndpointDescripciónGET/api/proyectos/{id}/comentariosListar comentarios de un proyectoPOST/api/proyectos/{id}/comentariosAgregar comentario a un proyectoDELETE/api/proyectos/{id}/comentarios/{comentarioId}Eliminar un comentario

▶️ Cómo correr el proyecto
Requisitos

.NET 10 SDK
Visual Studio 2026 o VS Code

Pasos

Cloná el repositorio:

bashgit clone https://github.com/Alexander08S-C/gestion-proyectos-api.git
cd gestion-proyectos-api/GestionProyectos

Instalá las herramientas de EF Core:

bashdotnet tool install --global dotnet-ef

Creá la base de datos:

bashdotnet ef database update

Levantá la API:

bashdotnet run

Abrí Swagger en el navegador:

http://localhost:5294/swagger

🗺️ Próximos pasos

 Conectar con el frontend en HTML/CSS/JS
 Agregar autenticación con JWT
 Migrar de SQLite a SQL Server o PostgreSQL
 Desplegar en Azure o Railway
 Agregar paginación en los endpoints
 Agregar DTOs para validación de datos


🔗 Repositorios relacionados

Frontend — gestion-proyectos — Panel web en HTML/CSS/JS


👨‍💻 Autor
Alexander — @Alexander08S-C

📄 Licencia
Este proyecto es de uso libre para fines educativos y personales.
