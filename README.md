# Registro de Personas - Proyecto de Prueba

Este proyecto es una solución básica para registrar personas con datos personales y de contacto. Se desarrolla con tecnologías .NET (C#), SQL Server, y utiliza ADO.NET para interactuar con la base de datos. Está diseñado exclusivamente con fines de prueba.

---

## **Descripción General**

El sistema permite:
1. Registrar personas con los siguientes datos:
   - Documento de identidad (único y obligatorio, alfanumérico).
   - Nombres y apellidos (solo caracteres del alfabeto latino, obligatorios).
   - Fecha de nacimiento (obligatoria).
   - Información de contacto: 
     - Mínimo una información de contacto (correo electrónico o dirección física).
     - Máximo 2 números telefónicos, 2 correos electrónicos y 2 direcciones físicas.
2. Garantizar la integridad de los datos mediante validaciones en la lógica de la aplicación.

---

## **Estructura del Proyecto**

El proyecto está dividido en dos capas principales:
1. **Capa de Datos (`RegistroPersonas.Data`)**
   - Interactúa directamente con la base de datos usando ADO.NET.
   - Contiene métodos para realizar operaciones CRUD en las tablas de la base de datos.

2. **Capa de Aplicación (`RegistroPersonas.Application`)**
   - Proporciona la lógica de negocio y las validaciones necesarias antes de interactuar con la capa de datos.
   - Garantiza que los datos ingresados cumplan con las reglas establecidas.

---

## **Requisitos**

1. **Entorno de Desarrollo**
   - Visual Studio 2022 o superior.
   - .NET Framework 4.7.2 o superior.
   - SQL Server (puede ser SQL Server Express).

2. **Base de Datos**
   - Crear la base de datos y las tablas utilizando el archivo `TablasSQL.sql` proporcionado o el script SQL incluido.

3. **Connection String**
   - Configurar la cadena de conexión en el archivo `app.config`:
     ```xml
     <connectionStrings>
       <add name="DefaultConnection" 
            connectionString="Server=localhost;Database=RegistroPersonas;Trusted_Connection=True;" 
            providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

---

## **Instrucciones de Uso**

1. **Clonar el Repositorio**
   - Clona este proyecto en tu entorno local.

2. **Configurar la Base de Datos**
   - Ejecuta el script SQL para crear la base de datos y tablas.

3. **Abrir el Proyecto**
   - Abre la solución en Visual Studio.

4. **Configurar la Cadena de Conexión**
   - Asegúrate de que el archivo `app.config` tenga la cadena de conexión correcta para tu entorno.

5. **Compilar el Proyecto**
   - Antes de compilar, elimina las carpetas `bin` y `obj` de cada proyecto para evitar conflictos o referencias obsoletas.

6. **Ejecutar el Proyecto**
   - Ejecuta el proyecto desde la clase `Program.cs`.
   - Sigue las instrucciones en la consola para registrar personas y su información.

---

## **Advertencias**

- **Motivos de Prueba**: Este proyecto es solo para propósitos de demostración. No está diseñado para producción.
- **Limpieza de Carpetas**: 
  - Antes de compilar el proyecto, elimina las carpetas `bin` y `obj` para evitar referencias incorrectas o errores inesperados.
- **Datos Sensibles**: Asegúrate de no usar información real o confidencial en las pruebas.

---

## **Problemas Comunes**

1. **Error de Conexión a la Base de Datos**
   - Asegúrate de que la base de datos esté creada y en ejecución.
   - Verifica la cadena de conexión en `app.config`.

2. **Validaciones**
   - Si ingresas datos que no cumplen con las reglas (por ejemplo, documento duplicado, nombres con números), el sistema lanzará un mensaje de error.

---

## **Licencia**

Este proyecto es de uso libre exclusivamente para pruebas y aprendizaje. No se asume responsabilidad por el uso fuera de estos fines.

---

¡Gracias por probar el proyecto!
