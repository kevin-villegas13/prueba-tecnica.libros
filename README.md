Aquí tienes el **README** más organizado y estructurado para que sea fácil de leer y entender.  

---

# 📚 **Biblioteca - Gestión de Libros y Autores**  

Aplicación web para gestionar libros y autores, permitiendo agregar, visualizar, editar y eliminar registros de manera eficiente.  

---

## 🚀 **Características Principales**  

✔️ Listado de libros y autores  
✔️ Creación, edición y eliminación de registros  
✔️ Detalles de autores con la lista de libros asociados  
✔️ Diseño responsivo con **Tailwind CSS**  
✔️ Validaciones en los formularios  
✔️ Confirmación de eliminación con **SweetAlert2**  

---

## 📂 **Estructura del Proyecto**  

```
📦 Biblioteca
├── 📁 Data           # DbContext y configuración de la base de datos
├── 📁 Models         # Modelos de datos (Author, Book)
├── 📁 Controllers    # Controladores de lógica
├── 📁 DTO            # Data Transfer Objects (DTO)
├── 📁 Views          # Interfaz de usuario
├── 📁 wwwroot        # Archivos estáticos (CSS, JS)
└── 📄 Program.cs     # Configuración de la aplicación
```

---

## 🛠️ **Instalación y Configuración**  

### 1️⃣ Clonar el repositorio  

```sh
git clone https://github.com/kevin-villegas13/prueba-tecnica.libros.git
cd biblioteca
```

### 2️⃣ Configurar la base de datos  

1. Crea una base de datos en **SQL Server** con el nombre `BibliotecaDB`.  
2. Modifica `appsettings.json` y configura la conexión a la base de datos:  

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BibliotecaDB;Trusted_Connection=True;"
}
```

### 3️⃣ Aplicar Migraciones  

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🎨 **Tecnologías Utilizadas**  

🔹 **ASP.NET Core MVC** - Backend robusto  
🔹 **Entity Framework Core** - ORM para la base de datos  
🔹 **Tailwind CSS** - Estilos modernos y responsivos  
🔹 **SweetAlert2** - Confirmaciones y alertas interactivas  

---

## 📝 **Validaciones Implementadas**  

✔️ Campos obligatorios en formularios  
✔️ Verificación de datos no vacíos  
✔️ Mensajes de error claros  

---

## 📊 **Diagrama Entidad-Relación**  

📌 Representación de la estructura de la base de datos:  
![Diagrama ER](https://github.com/user-attachments/assets/e3bdaae7-acbd-4618-8e82-b6bf2aac9b99)  

---

## 📸 **Capturas de Pantalla**  

### 🏠 **Página Principal**  
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

## 🔗 **Enlaces Importantes**  

📌 **Repositorio:** [GitHub - Biblioteca](https://github.com/kevin-villegas13/prueba-tecnica.libros)  
📩 **Contacto:** kevinvilleperez@gmail.com  
