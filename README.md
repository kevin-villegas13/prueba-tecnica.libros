```markdown
# 📚 Biblioteca - Gestión de Libros y Autores

Este proyecto es una aplicación web para gestionar libros y autores. Permite a los usuarios agregar, visualizar, editar y eliminar libros y autores en una base de datos.

## 🚀 Características

- 📖 Listado de libros y autores.
- 📝 Creación, edición y eliminación de libros y autores.
- 🔎 Detalles de autores con la lista de libros asociados.
- 🎨 Diseño responsivo con Tailwind CSS.
- ✅ Validaciones en los formularios.
- ⚡ Confirmación de eliminación con SweetAlert.

## 📂 Estructura del Proyecto

```
📦 Biblioteca

├── 📁 Data           # Db context eso
├── 📁 Models         # Modelos de datos (Author, Book)
├── 📁 Controllers    # Controladores para manejar la lógica
├── 📁 DTO            # Dto
├── 📁 Views          # Vistas para la interfaz de usuario
├── 📁 wwwroot        # Archivos estáticos (CSS, JS)
└── 📄 Program.cs     # Configuración de la aplicación
```

## 🛠️ Instalación y Configuración

### 1️⃣ Clonar el repositorio:
```sh
[git clone https://github.com/tuusuario/biblioteca.git](https://github.com/kevin-villegas13/prueba-tecnica.libros.git)
cd biblioteca
```

### 2️⃣ Configurar la base de datos:
- Crea una base de datos en **SQL Server** BibliotecaDB.
- Modifica `appsettings.json` para configurar la conexión:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BibliotecaDB;Trusted_Connection=True;"
}
```

### 3️⃣ Aplicar Migraciones:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 🎨 Tecnologías Utilizadas

- **ASP.NET Core MVC** - Framework para el backend.
- **Entity Framework Core** - ORM para la base de datos.
- **Tailwind CSS** - Estilos responsivos y modernos.
- **SweetAlert2** - Alertas interactivas.

## 📝 Validaciones Implementadas

- Campos obligatorios en los formularios.
- Verificación de que el título del libro y el nombre del autor no estén vacíos.
- Mensajes de error claros para el usuario.

## 📊 Diagrama Entidad-Relación

Aquí está el modelo de la base de datos utilizado:
![image](https://github.com/user-attachments/assets/e3bdaae7-acbd-4618-8e82-b6bf2aac9b99)

## 📸 Capturas de Pantalla

### 📋 Listado de Autores
![Lista de Autores](https://via.placeholder.com/800x400?text=Captura+Lista+Autores)

### 📖 Gestión de Libros
![Gestión de Libros](https://via.placeholder.com/800x400?text=Captura+Gestion+Libros)

## 🤝 Contribuciones

¡Las contribuciones son bienvenidas! Si encuentras errores o quieres mejorar la aplicación, envía un **Pull Request**.

## 📄 Licencia

Este proyecto está bajo la licencia MIT. ¡Siéntete libre de usarlo y mejorarlo! 😊

---

📌 **Repositorio:** [GitHub - Biblioteca](https://github.com/tuusuario/biblioteca)  
📩 **Contacto:** Si tienes dudas, contáctame en `tuemail@ejemplo.com`.
```

---

📌 **Notas:**  
- **Reemplaza** `https://github.com/tuusuario/biblioteca` con tu enlace real de GitHub.  
- Para las capturas de pantalla, **sube imágenes reales** y reemplaza los placeholders.  
- **Modifica la conexión a la base de datos** según el entorno que uses.  

🚀 **Con este README, cumples con todos los requisitos de entrega!** 😃
