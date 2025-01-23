# Registro de Personas - Proyecto de Prueba

Este proyecto es una soluci�n b�sica para registrar personas con datos personales y de contacto. Se desarrolla con tecnolog�as .NET (C#), SQL Server, y utiliza ADO.NET para interactuar con la base de datos. Est� dise�ado exclusivamente con fines de prueba.

---

## **Descripci�n General**

El sistema permite:
1. Registrar personas con los siguientes datos:
   - Documento de identidad (�nico y obligatorio, alfanum�rico).
   - Nombres y apellidos (solo caracteres del alfabeto latino, obligatorios).
   - Fecha de nacimiento (obligatoria).
   - Informaci�n de contacto: 
     - M�nimo una informaci�n de contacto (correo electr�nico o direcci�n f�sica).
     - M�ximo 2 n�meros telef�nicos, 2 correos electr�nicos y 2 direcciones f�sicas.
2. Garantizar la integridad de los datos mediante validaciones en la l�gica de la aplicaci�n.

---

## **Estructura del Proyecto**

El proyecto est� dividido en dos capas principales:
1. **Capa de Datos (`RegistroPersonas.Data`)**
   - Interact�a directamente con la base de datos usando ADO.NET.
   - Contiene m�todos para realizar operaciones CRUD en las tablas de la base de datos.

2. **Capa de Aplicaci�n (`RegistroPersonas.Application`)**
   - Proporciona la l�gica de negocio y las validaciones necesarias antes de interactuar con la capa de datos.
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
   - Configurar la cadena de conexi�n en el archivo `app.config`:
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
   - Abre la soluci�n en Visual Studio.

4. **Configurar la Cadena de Conexi�n**
   - Aseg�rate de que el archivo `app.config` tenga la cadena de conexi�n correcta para tu entorno.

5. **Compilar el Proyecto**
   - Antes de compilar, elimina las carpetas `bin` y `obj` de cada proyecto para evitar conflictos o referencias obsoletas.

6. **Ejecutar el Proyecto**
   - Ejecuta el proyecto desde la clase `Program.cs`.
   - Sigue las instrucciones en la consola para registrar personas y su informaci�n.

---

## **Advertencias**

- **Motivos de Prueba**: Este proyecto es solo para prop�sitos de demostraci�n. No est� dise�ado para producci�n.
- **Limpieza de Carpetas**: 
  - Antes de compilar el proyecto, elimina las carpetas `bin` y `obj` para evitar referencias incorrectas o errores inesperados.
- **Datos Sensibles**: Aseg�rate de no usar informaci�n real o confidencial en las pruebas.

---

## **Problemas Comunes**

1. **Error de Conexi�n a la Base de Datos**
   - Aseg�rate de que la base de datos est� creada y en ejecuci�n.
   - Verifica la cadena de conexi�n en `app.config`.

2. **Validaciones**
   - Si ingresas datos que no cumplen con las reglas (por ejemplo, documento duplicado, nombres con n�meros), el sistema lanzar� un mensaje de error.

---

## **Licencia**

Este proyecto es de uso libre exclusivamente para pruebas y aprendizaje. No se asume responsabilidad por el uso fuera de estos fines.

---

�Gracias por probar el proyecto!
