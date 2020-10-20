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

Sin embargo, si observamos la interacción entre los objetos, podemos ver que aumentar el peso de la esfera hace que empuje más al cubo al chocar con él. Veamos:

Este es la esfera cayendo con peso = 1 (el cubo también tiene peso = 1)

![Ball Falling on Cube (light)](img/fallingLight.gif)

Ahora, la esfera cayendo con peso = 10 (el cubo sigue teniendo peso = 1)

![Ball Falling on Cube (light)](img/fallingHeavy.gif)

Para el apartado **e**, tendremos que modificar la componente Box Collider de nuestro objeto Cubo.

![Modifying Collider Component](img/ColliderSettings.PNG)

Al no tener físicas el cubo, no parece haber cambios en la escena. La bola cae y el cubo no. Sin embargo, en el siguiente apartado se apreciará mejor la influencia de lo que hemos hecho. Como ya hemos visto, aplicamos físicas al cubo añadiéndole una componente Rigidbody. El resultado, como hemos visto en las transparencias del tema, es el siguiente: el cubo cae a la vez que la esfera y atraviesa el plano. Esto es porque un objeto de naturaleza IsTrigger solo utiliza el collider para **detectar** las colisiones; no para restringir el movimiento del propio objeto.

Para el siguiente apartado, tendremos que bloquear la rotación del cubo en ciertos ejes. Esto se consigue modificando la componente Rigidbody, bajo la pestaña de Constraints.

![Freezing Rotation on Axis](img/FreezeRot.PNG)

Aquí, haremos tick en las cajas de X y Z del apartado Freeze Rotation. Ahora, si volvemos a probar la colisión entre los objetos, comprobaremos que efectivamente el cubo no puede rotar en los ejes X ni Z. Por esto, parecería que está completamente quieto cuando la esfera lo golpea.

![Ball Falling on Cube No Movement](img/fallingHeavyNoRot.gif)

### Ejercicio 2

Para empezar, reescalaremos el plano para poder movernos con libertad, eliminaremos el objeto esfera y recolocaremos el cubo de forma centrada. Esto nos hará las cosas más fáciles. Como en el apartado **a** se nos indica que no debemos aplicar simulación física, no incluiremos en nuestro cubo una componente de Rigidbody. Ahora, podemos pasar a crear un nuevo script.

![Code for the Script](img/code.PNG)

Este será el script que nos permitirá un control muy básico sobre nuestro cubo. Como podemos ver, al no incluir una componente Rigidbody, no podemos utilizarlo para el movimiento (mediante AddForce). Por tanto, utilizaremos transform para el movimiento. Vemos también que, como se nos indica en el apartado **b**, se incluye el valor público para configurar la velocidad del movimiento. Esta velocidad se utiliza más adelante al hacer el translate.

