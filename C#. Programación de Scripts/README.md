# C#. Programación de Scripts

<br/>

## Script ScoreScript.cs

Script utilizado para aumentar la puntuación del jugador en el *HUD* cada vez que este golpee una pelota.

<br/>

## Script PlayerController.cs

Script utilizado para asignar los controles para que el usuario pueda mover la capsula. Este se podrá mover a cierta velocidad y cuando golpee una pelota estática la mandará con una fuerza predeterminada. Además, siempre que golpee cualquier tipo de pelota (Dinámica o Estática), sumará un punto a la puntuación total.

<br/>

## Script StaticSphere.cs

Script utilizado para hacer que la pelota al entrar en contacto con el jugador, disminuya su tamaño y se oscurezca su color hasta 5 veces. Luego de esto, el propio GameObject es destruido.

<br/>

## Script DynamicSphere.cs

Script utilizado para asignar a la pelota un movimiento continuo haciendo que:

 - Rebote contra las paredes.
 - Rebote contra el jugador y halle el vector de repulsión.
 - Rebote contra otras pelotas estáticas, halle el vector de repulsión y empuje a estas con una fuerza predeterminada.

Por último, como en el script anterior, al entrar el jugador en contacto con la pelota, esta disminuirá su tamaño y se le oscurecerá el color hasta 5 veces. Luego de esto, la pelota se destruirá.

</br>
