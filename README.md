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

  
- la velocidad que usas es menor que 1
  ![p3_c](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/17ba45f4-7abf-48f2-8a95-495605c12071)


- la posición del cubo tiene y>0
  ![p2_d](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/c218a8e0-8daf-4cdb-8ee9-a8585e8d02fa)

- intercambiar movimiento relativo al sistema de referencia local y el mundial
          cubo.transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
  ![p3_e](https://github.com/adriansanzzzz/II_Actividad3/assets/74414073/35721a48-65aa-4195-aaeb-8298032bf037)


