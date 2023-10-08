# Práctica 3 - Movimiento fisicas
## Asignatura: Interfaces Inteligentes
## Adrián Sanz Fernández - alu0101686400@ull.edu.es


### 1 - Agrega un campo velocidad al cubo de la práctica anterior y asígnale un valor que se pueda cambiar en el inspector de objetos. Muestra la consola el resultado de multiplicar la velocidad por el valor del eje vertical y por el valor del eje horizontal cada vez que se pulsan las teclas flecha arriba-abajo ó flecha izquierda-derecha. El mensaje debe comenzar por el nombre de la flecha pulsada.

### 2 - Mapea la tecla H a la función disparo. 
En los ajustes del proyecto, buscamos el Input Manager y aqui cambiamos la tecla positiva para que cada vez que se pulse se dispare.
<img width="693" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/5c054152-4fcc-4d4a-8fc9-56a6a7415350">

### 2 - Crea un script asociado al cubo que en cada iteración traslade al cubo una cantidad proporcional un vector que indica la dirección del movimiento: moveDirection que debe poder modificarse en el inspector.  La velocidad a la que se produce el movimiento también se especifica en el inspector, con la propiedad speed. Inicialmente la velocidad debe ser mayor que 1 y el cubo estar en una posición y=0. En el informe de la práctica comenta los resultados que obtienes en cada una de las siguientes situaciones:
- duplicas las coordenadas de la dirección del movimiento.
   ![p2_a](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/521254eb-da4a-4d28-9130-93f9ad946ad1)

- duplicas la velocidad manteniendo la dirección del movimiento.
   ![p3_x](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/9f69d66b-6338-4ec1-a5a1-7e8ee64068a2)


- la velocidad que usas es menor que 1
  ![p3_c](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/17ba45f4-7abf-48f2-8a95-495605c12071)


- la posición del cubo tiene y>0
  ![p3_cv2](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/cc5c00e9-6549-4b7e-8ed8-6240a949743e)


- intercambiar movimiento relativo al sistema de referencia local y el mundial
  Para ello modificamos  el codigo y añadimos Space.World a las propiedades del Transalate
  ```csharp
  cubo.transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
  ```
  ![p3_e](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/35721a48-65aa-4195-aaeb-8298032bf037)



### 3 - Mueve el cubo con las teclas de flecha arriba-abajo, izquierda-derecha a la velocidad speed. Cada uno de estos ejes implican desplazamientos en el eje vertical y horizontal respectivamente. Mueve la esfera con las teclas w-s (movimiento vertical) a-d (movimiento horizontal).

<img width="551" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/9fb71c68-0267-4cf8-ad8e-7c2e7706468a">
<img width="551" alt="image" src="https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/b0311b53-38d8-41d0-a198-2274278a811f">

![p3_3](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/3307b62f-9ea7-4d86-88e4-b741875da9e5)

### 4 - Adapta el movimiento en el ejercicio 4 para que sea proporcional al tiempo transcurrido durante la generación del frame.

![p3_4](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/53541357-2388-4910-b0fc-a44a8eae24c2)

