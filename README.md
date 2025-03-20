Aquí tienes el **README** bien organizado y con una presentación clara:  

---

# 📚 **Biblioteca - Gestión de Libros y Autores**  

Este proyecto es una aplicación web que permite gestionar libros y autores. Los usuarios pueden agregar, visualizar, editar y eliminar libros y autores dentro de una base de datos de manera sencilla y eficiente.  

---

## 🚀 **Características Principales**  

✅ Listado de libros y autores.  
✅ Creación, edición y eliminación de libros y autores.  
✅ Detalles de autores con la lista de libros asociados.  
✅ Diseño responsivo con **Tailwind CSS**.  
✅ Validaciones en los formularios.  
✅ Confirmación de eliminación con **SweetAlert2**.  

---

## 📂 **Estructura del Proyecto**  

```markdown
📦 Biblioteca
├── 📁 Data           # DbContext y configuración de la base de datos
├── 📁 Models         # Modelos de datos (Author, Book)
├── 📁 Controllers    # Controladores para manejar la lógica
├── 📁 DTO            # Data Transfer Objects (DTO)
├── 📁 Views          # Vistas para la interfaz de usuario
├── 📁 wwwroot        # Archivos estáticos (CSS, JS)
└── 📄 Program.cs     # Configuración de la aplicación
```

---

## 🛠️ **Instalación y Configuración**  

### 🔹 **1. Clonar el repositorio**  

Ejecuta el siguiente comando en tu terminal:  

```sh
git clone https://github.com/kevin-villegas13/prueba-tecnica.libros.git
cd biblioteca
```

---

### 🔹 **2. Configurar la base de datos**  

1. Crea una base de datos en **SQL Server** con el nombre `BibliotecaDB`.  
2. Modifica el archivo `appsettings.json` y configura la conexión a la base de datos:  

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BibliotecaDB;Trusted_Connection=True;"
}
```

---

### 🔹 **3. Aplicar Migraciones**  

Ejecuta los siguientes comandos en la terminal:  

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🎨 **Tecnologías Utilizadas**  

🔹 **ASP.NET Core MVC** - Framework para el backend.  
🔹 **Entity Framework Core** - ORM para la base de datos.  
🔹 **Tailwind CSS** - Para estilos responsivos y modernos.  
🔹 **SweetAlert2** - Para confirmaciones y alertas interactivas.  

---

## 📝 **Validaciones Implementadas**  

✔️ Campos obligatorios en los formularios.  
✔️ Verificación de que el título del libro y el nombre del autor no estén vacíos.  
✔️ Mensajes de error claros para el usuario.  

---

## 📊 **Diagrama Entidad-Relación**  

El siguiente diagrama representa la relación entre los modelos de la base de datos:  

![Diagrama ER](https://github.com/user-attachments/assets/e3bdaae7-acbd-4618-8e82-b6bf2aac9b99)  

---

## 📸 **Capturas de Pantalla**  

### 📋 **Listado de Autores**  
![Lista de Autores](https://via.placeholder.com/800x400?text=Captura+Lista+Autores)  

### 📖 **Gestión de Libros**  
![Gestión de Libros](https://via.placeholder.com/800x400?text=Captura+Gestion+Libros)  

📌 **Repositorio:** [GitHub - Biblioteca](https://github.com/kevin-villegas13/prueba-tecnica.libros)  
📩 **Contacto:** Para cualquier duda, contáctame en `kevinvilleperez@gmail.com`.  
