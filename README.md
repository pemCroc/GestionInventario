# GestiónInventario

# README

## Sistema de Gestión de Inventario

### Descripción
Este sistema de gestión de inventario permite realizar operaciones básicas como agregar, editar y eliminar productos, gestionar categorías y proveedores, consultar productos según criterios específicos y exportar datos a formato CSV. Además, el sistema incluye validaciones para garantizar la integridad de los datos.

---

## Requisitos
Los detalles de los requisitos del sistema se encuentran en el archivo `requirements.txt`.

---

## Instalación y Configuración

1. **Clonar el Repositorio**
   - Usa el siguiente comando para clonar el repositorio:
     ```bash
     git clone <URL del repositorio>
     ```
     
2. **Abrir el Proyecto en Visual Studio**
   - Navega hasta la carpeta donde clonaste el repositorio.
   - Abre el archivo de solución `.sln`.

3. **Configurar la Base de Datos**
   - Verifica que el archivo `Inventario.db` esté ubicado en la carpeta `bin\Debug\netX` del proyecto.
   - Si no existe, puedes crearlo manualmente o generarlo automáticamente al ejecutar el programa.

4. **Ejecutar el Proyecto**
   - Presiona `F5` o selecciona **Iniciar depuración** en Visual Studio para ejecutar el programa.

5. **Probar el Sistema**
   - Usa la interfaz para agregar, editar y consultar productos. También puedes generar reportes y exportarlos a CSV.

---

## Funcionalidades

### Gestión de Productos
- Agregar productos con validaciones de código único.
- Editar y eliminar productos existentes.

### Consultas y Reportes
- Consultar productos por categoría o proveedor.
- Generar un reporte de productos con stock bajo (menos de 10 unidades).

### Exportación de Datos
- Exportar los datos de la `Tabla` a un archivo CSV.
---

## Ejecución del Programa

1. **Abrir la Interfaz**
   - Ejecuta el programa desde Visual Studio.

2. **Agregar Productos**
   - Llena los campos requeridos en la sección de productos y haz clic en `Agregar`.

3. **Consultar Productos**
   - Selecciona un criterio en el ComboBox de consultas, elige un valor y haz clic en `Consultar`.

4. **Exportar Datos**
   - Haz clic en el botón `Exportar a CSV` para guardar los datos visibles en un archivo.

---

