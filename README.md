# Práctica 3 - Movimiento fisicas
## Asignatura: Interfaces Inteligentes
## Adrián Sanz Fernández - alu0101686400@ull.edu.es


### 1 - Agrega un campo velocidad al cubo de la práctica anterior y asígnale un valor que se pueda cambiar en el inspector de objetos. Muestra la consola el resultado de multiplicar la velocidad por el valor del eje vertical y por el valor del eje horizontal cada vez que se pulsan las teclas flecha arriba-abajo ó flecha izquierda-derecha. El mensaje debe comenzar por el nombre de la flecha pulsada.

### 2 - Mapea la tecla H a la función disparo. 
En los ajustes del proyecto, buscamos el Input Manager y aqui cambiamos la tecla positiva para que cada vez que se pulse se dispare.
<img width="693" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/5c054152-4fcc-4d4a-8fc9-56a6a7415350">

### 3 - Crea un script asociado al cubo que en cada iteración traslade al cubo una cantidad proporcional un vector que indica la dirección del movimiento: moveDirection que debe poder modificarse en el inspector.  La velocidad a la que se produce el movimiento también se especifica en el inspector, con la propiedad speed. Inicialmente la velocidad debe ser mayor que 1 y el cubo estar en una posición y=0. En el informe de la práctica comenta los resultados que obtienes en cada una de las siguientes situaciones:
- duplicas las coordenadas de la dirección del movimiento. No sucece nada ya que hemos normalizado el vector y por lo tanto solo nos interesa la dirección.

- duplicas la velocidad manteniendo la dirección del movimiento. Se mueve más deprisa
   ![p3_x](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/9f69d66b-6338-4ec1-a5a1-7e8ee64068a2)


- la velocidad que usas es menor que 1. Va hacia atras.
  ![p3_c](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/17ba45f4-7abf-48f2-8a95-495605c12071)


- la posición del cubo tiene y>0. Sube hacia arriba


- intercambiar movimiento relativo al sistema de referencia local y el mundial
  Para ello modificamos  el codigo y añadimos Space.World a las propiedades del Transalate. No noto diferencia
  ```csharp
  transform.Translate(cubeMovement,Space.World);
  ```



### 4 - Mueve el cubo con las teclas de flecha arriba-abajo, izquierda-derecha a la velocidad speed. Cada uno de estos ejes implican desplazamientos en el eje vertical y horizontal respectivamente. Mueve la esfera con las teclas w-s (movimiento vertical) a-d (movimiento horizontal).

<img width="551" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/9fb71c68-0267-4cf8-ad8e-7c2e7706468a">
<img width="551" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/b0311b53-38d8-41d0-a198-2274278a811f">

![p3_3](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/3307b62f-9ea7-4d86-88e4-b741875da9e5)

### 5 - Adapta el movimiento en el ejercicio 4 para que sea proporcional al tiempo transcurrido durante la generación del frame.

![p3_4](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/53541357-2388-4910-b0fc-a44a8eae24c2)

### 6 - Adapta el movimiento en el ejercicio 5 para que el cubo se mueva hacia la posición de la esfera. Debes considerar, que el avance no debe estar influenciado por cuánto de lejos o cerca estén los dos objetos.
![p3_61](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/1f11a5c5-1a1e-4d8f-9245-aabb07b4a4bb)


### 7 - Adapta el movimiento en el ejercicio 6 de forma que el cubo gire hacia la esfera. Realiza pruebas cambiando la posición de la esfera mediante las teclas awsd
![p3_72](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/7485bdfe-a22e-4cbc-a216-a6af8ff05f35)


### 8 - Utilizar el eje “Horizontal” para girar el objetivo y que avance siempre en la dirección hacia adelante.
![p3_8](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/c6c72f94-cb6f-4d22-8d32-cb87f63b78d1)


### 9 - Configura el cilindro como un objeto físico, cuando el cubo o la esfera colisionen con él se debe mostrar un mensaje en consola con la etiqueta del objeto que haya colisionado. 
<img width="1267" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/e4765f9d-201c-451b-8a7b-ac42bed00981">

![colision esfera](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/491204ff-d117-401b-899a-e18efef2de73)
![colision cubo](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/d8c4db82-881b-4ce1-b0fb-2515b688bb00)

### 10 - Configura el cubo como un objeto cinemático y la esfera como un objeto físico. Adapta los scripts del ejercicio 9 para obtener el mismo comportamiento.
<img width="1267" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/a25a94af-ea04-45a6-987d-116923cbea29">


### 12- Agrega un cilindro de un color diferente al que ya hay en la escena y configúralo como un objeto físico. Selecciona un conjunto de teclas que te permitan controlar su movimiento por la escena y prográmale un movimiento que permita dirigirlo hacia la esfera. Prueba diferentes configuraciones de la esfera física con masa 10 veces mayor que el cilindro, física con masa 10 veces menor que el cilindro, cinemática y trigger. También prueba la configuración del cilindro de forma que su fricción se duplique o no. Explica en el informe todos los resultados posibles. 

#### a
<img width="1267" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/eef9fbe5-c1bc-400e-a341-3ac2530b6265">
![12](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/802e14a1-2b35-4700-acea-4cea3dd9ded3)
#### b
