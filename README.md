# Tarea4.3_Transaccion

Sistema de Gestión de Productos (C# + MySQL)

Este proyecto es una aplicación de escritorio desarrollada en C# (Windows Forms) que permite gestionar productos conectándose a una base de datos MySQL.

## Funcionalidades actuales

- Conexión a base de datos MySQL (localhost)
- Búsqueda de productos por código
- Inserción de múltiples productos (transacciones con Commit/Rollback)
- Llenado de un DataGridView con columnas dinámicas
- Confirmaciones con MessageBox tipo "¿Estás seguro?" antes de eliminar
- Manejo de excepciones con errores detallados (no solo genéricos)

## Tecnologías usadas
- C# - Windows Forms (.NET)
- MySQL como base de datos
- MySql.Data para la conexión (conector oficial)
  
## Configuración de conexión
Editar esta línea en el código:
cn.ConnectionString = "server=localhost; database=Productos; user=root; password=root;";

### Asegúrate de que:
- El servidor MySQL esté ejecutándose.
- El usuario y contraseña sean correctos.
- La base de datos Productos exista (incluye tabla producto).

## Cómo ejecutar
- Clonar o descargar el proyecto.
- Verificar la cadena de conexión MySQL.
- Ejecutar script.sql para crear la base de datos y tabla.
- Abrir el proyecto en Visual Studio.
- Presionar F5 para ejecutar.

  ### **Realizado por Ricardo Abraham Pérez Hernández & Guadalupe Yolet Villagómez Núñez**
