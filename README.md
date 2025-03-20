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

1. Crea una base de datos en **SQL Server** con el siguiente script:  

```sql
CREATE DATABASE Biblioteca;
GO

USE Biblioteca;
GO

-- Tabla de Autores
CREATE TABLE Authors (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL
);
GO

-- Tabla de Libros
CREATE TABLE Books (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    AuthorId INT NOT NULL,
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id) ON DELETE CASCADE
);
GO
```

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

### 🏠 **Home Principal**  
![image](https://github.com/user-attachments/assets/239bf29d-940b-4416-ad1d-0e8153e5610d)

### 📋 **Listado de Autores**  
![image](https://github.com/user-attachments/assets/a757683f-fef0-4a9c-87fc-3ffce0b858da)

### ➕ **Agregar Autor**  
![image](https://github.com/user-attachments/assets/cc442cca-0552-4b51-91cc-ca503385e33c)

### ✏️ **Editar Autor**  
![image](https://github.com/user-attachments/assets/834fc992-ae4a-46d4-967a-00c6d3be0db3)

### 📖 **Ver Autor con Libros Asociados**  
![image](https://github.com/user-attachments/assets/64325181-2782-4b4c-9020-a5d9dd5d8d12)  
![image](https://github.com/user-attachments/assets/39bf0b0d-bcf7-43b5-9204-c15ca883e1b8)

### 📚 **Gestión de Libros**  
![image](https://github.com/user-attachments/assets/9251a7cd-8b20-4945-ac94-843c51b58bd6)

### ➕ **Agregar Libro**  
![image](https://github.com/user-attachments/assets/ff79013c-6dba-4eb6-b3cb-8f00e425bb62)

### ✏️ **Editar Libro**  
![image](https://github.com/user-attachments/assets/eeb4f264-f154-47e4-b991-ac1803148f99)

---

📌 **Repositorio:** [GitHub - Biblioteca](https://github.com/kevin-villegas13/prueba-tecnica.libros)  
📩 **Contacto:** Para cualquier duda, contáctame en `kevinvilleperez@gmail.com`.  
