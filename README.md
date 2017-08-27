# examentecnico.netdeveloper
Ejercicios practivos con mvc .net

Problema 01
Usando C#, crear una clase llamada ChangeString que tenga un método llamado
build el cual tome un parámetro string que debe ser modificado por el siguiente
algoritmo . Reemplazar cada letra de la cadena con la letra siguiente en el
alfabeto. Por ejemplo reemplazar a por b ó c por d . Finalmente devolver la
cadena.
Indicaciones
● Crear la solución en un solo archivo llamado ChangeString.cs
● El método build devuelve la salida del algoritmo
● Considerar el siguiente abecedario : a, b, c, d, e, f, g, h, i, j, k, l, m, n, ñ, o,
p, q, r, s, t, u, v, w, x, y, z.
Ejemplos
● entrada : "123 abcd*3" salida : "123 bcde *3"
● entrada : "**Casa 52" salida : "** Dbtb 52"


Problema 02
Usando C#, crear una clase llamada CompleteRange que tenga un método
llamado build el cual tome un parámetro de colección de números enteros
positivos (1,2,3, ...n) en cualquier orden. El algoritmo debe completar si faltan
números en la colección en el rango dado. Finalmente devolver la colección
completa y ordenada de manera ascendente.
Indicaciones
● Crear la solución en un solo archivo llamado CompleteRange .cs
● El método build devuelve la salida del algoritmo
Ejemplos
● entrada : [2, 1, 4, 5] salida : [1, 2, 3 , 4, 5]
● entrada : [4, 2, 9] salida : [ 1 , 2, 3 , 4, 5, 6, 7, 8 , 9]
● entrada : [58, 60, 55] salida : [ 1 , 2 , … 54 , 55, 56, 57, 58, 59, 60]


Problema 03
Usando C#, crear una clase llamada MoneyParts que tenga un método llamado
build que reciba como parámetro una cadena con un monto en soles y devuelva
todas las combinaciones posibles en un arreglo.
Indicaciones
● Crear la solución en un solo archivo llamado MoneyParts .cs
● El método build devuelve la salida del algoritmo
● Considerar las siguientes denominaciones (0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10,
20, 50, 100, 200)
Ejemplos
● entrada : "0.1" salida : [[0.05, 0.05], [0.1]]
● entrada : "0.5" salida : [[0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05, 0.05,
0.05], ….… [0.1, 0.1, 0.1, 0.1, 0.1]]
● entrada : "10.50" salida : [[0.05, 0.05, …. 0.05], …… [10.0, 0.5]]
Los puntos suspensivos representan todas las combinaciones posibles para
representar la cantidad monetaria ingresada.
