# Práctica 2 - José Nicolás Cabrera Domínguez (alu0101051420)

### Ejercicio 1

El apartado **a** es muy sencillo: como ya hemos visto, introducimos los tres objetos en el menú GameObject > 3D Object seleccionando el que querramos incluir.
La escena, después de colocar y separar los objetos, queda así:

![Initial Scene Layout](img/firstScene.PNG)

Para añadir físicas a un objeto, necesitaremos incluir en él un componente Rigidbody. Para esto, seleccionamos el objeto y en el inspector, añadimos un nuevo componente.

![Adding a rigidBody to an object](img/addRigid.gif)

Esto lo utlizaremos para los apartados **b** y **c**. 
Al aplicarle físicas, vemos que tanto el cubo como la esfera se comportan de la misma forma: el objeto se ve ahora afectado por la gravedad, y cae sobre el plano.

Para el apartado **d**, tendremos que modificar la masa de la esfera. Esto se hace en el inspector, sobre el componente Rigidbody.

![Mass modify](img/rbSettings.PNG)

En este caso, el resultado no es el que se podría esperar: la esfera cae exactamente a la misma velocidad que el cubo.

Para el apartado **e**, tendremos que modificar la componente Box Collider de nuestro objeto Cubo.

![Modifying Collider Component](img/ColliderSettings.PNG)

Al no tener físicas el cubo, no parece haber cambios en la escena. La bola cae y el cubo no. Sin embargo, en el siguiente apartado se apreciará mejor la influencia de lo que hemos hecho. Como ya hemos visto, aplicamos físicas al cubo añadiéndole una componente Rigidbody. El resultado, como hemos visto en las transparencias del tema, es el siguiente: el cubo cae a la vez que la esfera y atraviesa el plano. Esto es porque un objeto de naturaleza IsTrigger solo utiliza el collider para **detectar** las colisiones; no para restringir el movimiento del propio objeto.

Para el siguiente apartado, tendremos que bloquear la rotación del cubo en ciertos ejes. Esto se consigue modificando la componente Rigidbody, bajo la pestaña de Constraints.

![Freezing Rotation on Axis](img/FreezeRot.PNG)

Aquí, haremos tick en las cajas de X y Z del apartado Freeze Rotation. Los resultados de hacer esto realmente son poco/no apreciables en la escena actual, aunque se puede suponer que el cubo no podrá rotar en los ejes X ni Z. 


### Ejercicio 2

Para empezar, reescalaremos el plano para poder movernos con libertad, eliminaremos el objeto esfera y recolocaremos el cubo de forma centrada. Esto nos hará las cosas más fáciles. Ahora, crearemos un script nuevo en el apartado de proyecto.

