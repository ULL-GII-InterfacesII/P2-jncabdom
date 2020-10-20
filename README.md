# Práctica 2 - José Nicolás Cabrera Domínguez (alu0101051420)

El apartado a es muy sencillo: como ya hemos visto, introducimos los tres objetos en el menú GameObject > 3D Object seleccionando el que querramos incluir.
La escena, después de colocar y separar los objetos, queda así:

![Initial Scene Layout](img/firstScene.PNG)

Para añadir físicas a un objeto, necesitaremos incluir en él un componente Rigidbody. Para esto, seleccionamos el objeto y en el inspector, añadimos un nuevo componente.

![Adding a rigidBody to an object](addRigid.gif)

Esto lo utlizaremos para los apartados b y c. 
Al aplicarle físicas, vemos que tanto el cubo como la esfera se comportan de la misma forma: el objeto se ve ahora afectado por la gravedad, y cae sobre el plano.
Para el apartado d, tendremos que modificar la masa de la esfera. Esto se hace en el inspector, sobre el componente Rigidbody.

![Mass modify](img/rbSettings.PNG)

En este caso, el resultado no es el que se podría esperar: la esfera cae exactamente a la misma velocidad que el cubo.
