# F1HUB 🏎️
Este proyecto se basa en crear una **aplicación** multiplataforma con todos los recursos aprendidos en los 2 años del ciclo superior de DAM.  
La **aplicación** se basa en una red social enfocada al mundo de la Fórmula 1 (F1).  
Tiene como nombre "F1HUB" y busca atraer a todo tipo de fans de este deporte, tanto expertos y muy avanzados en la materia como gente totalmente nueva con ganas de estar a la **última** **hora** sobre las noticias de la F1.

En este informe se plasmará cada 5 **días** los distintos avances y cambios que vayan surgiendo en la **aplicación** en sus distintas modalidades (**web**, aplicación de **escritorio** y aplicación **móvil** ).  

## 🔗 Fuentes de Informacion:
- Beekeeper studio + MySQL : [Tutorial](https://www.youtube.com/watch?v=_pyrtFLFKxM)
- Instalación de la libreria Metro Framework en C# : [Tutorial](https://www.youtube.com/watch?v=QlUmvIGYoF8)
- Configuracion del Bottom Navigation en Android Studio : [Tutorial](https://www.youtube.com/watch?v=OV25x3a55pk)
- Imagenes en la web de inicio de sesion : [Tutorial](https://www.youtube.com/watch?v=j4r4lYO6x_0), [Tutorial](https://www.youtube.com/watch?v=wj9txMVExZY)
- Diseño radiobuttons en la parte web de registro : [Tutorial](https://www.youtube.com/watch?v=5OrlF71bFrk)

📱 En esta primera parte se desarrollará la parte correspondiente al apartado de **móviles**.

---

## 📅 14/01

🎨 Avance en las **interfaces** tanto de **inicio de sesión** 🔑 como de **registro de un nuevo usuario** 📝.

---

## 📅 19/01

🎨 Retoques gráficos en la **primera interfaz de registro** 🖌️.  

⚙️ Creación de nuevas funcionalidades en **iniciar sesión**, como:  
-  El usuario puede **ver u ocultar su contraseña** mientras la escribe.  
-  Si el usuario ingresa correctamente tanto **nombre** como **contraseña**, se le dirige al **feed de la aplicación**.  
-  Un **link** que lleva al usuario a registrarse si todavía **no tiene cuenta**.  

📝 Creación de una **segunda actividad de registro**, donde el usuario escribirá su **contraseña** y la **confirmará**.  
✅ Diseño y **finalización** de la primera actividad de Registro con distintos campos (nombre, apellidos, correo, etc...) y sus respectivas comprobaciones.  
✅ Diseño y **finalización** de la segunda actividad de Registro mencionada anteriormente, donde el usuario escoge su contraseña, también con sus respectivas comprobaciones.  
🎨 Cambios con el fin de mejorar la usabilidad.  

⏳ A **expensas** de distintos cambios visuales que puedan surgir a lo largo del proyecto, la funcionalidad tanto del inicio de sesión como de registro de un nuevo usuario quedaría **completa** en el apartado de **móviles**.

  
---

🖥️ A partir de aqui empezará el desarrollo de la parte de **escritorio**

---

## 📅 26/01

⚙️ En el apartado de móviles se configuró el componente Bottom Navigation para la actividad principal.

🗄️ Creacion de la base de datos y distintas tablas para almacenar todos los datos necesarios de la aplicacion a traves de Beekeeper Studio.

🚀 Primeros avances para la creacion de la API (clase ApiRest).

📦 Instalacion de la libreria Metro Framework en C# .


---

💻 A partir de aqui empezará el desarrollo en la parte de **web**

---

## 📅 31/01

⚙️ Actualización en la **API**, permitiendo que desde Android el usuario pueda iniciar sesión con una cuenta ya registrada o registrarse en caso de no disponer de una, almacenando correctamente los datos en la base de datos.

🎨 Creación de las interfaces de **inicio de sesión** y **registro** en la parte web, centrándose exclusivamente en el diseño visual y quedando a la espera de implementar la funcionalidad y conexión con la API en futuras fases del proyecto.

---

## 📅 05/02

🛠️ Diferentes actualizaciones en la **API** para subir publicaciones.

🔐 Modificacion en la funcion de **iniciar Sesion** de la API para devolver un objeto usuario tanto en el backend como en el Android Studio.

📱 Creacion de nuevas **Vistas** y **Funciones** para subir un post en la aplicacion de móvil.

---

## 📅 10/02

🚀 En la parte web primeros avances para registrar nuevos usuarios y que queden reflejados en la base de datos y los usuarios que esten registrados puedan iniciar sesion.

✅ Correciones para cambiar de una vista a otra en la propia web

⚙️ Ajuste de componentes en la pantalla de moviles e implementacion de tema claro y oscuro.

---
# 📅 20/02

🚀 Avances en todas las interfaces y funcionalidades de la web.
✅ Finalizacion de las funciones en la Api para subir una publicacion,borrarla y editar un perfil












  


