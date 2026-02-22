# Programacion-1

#Los patrones de diseño son, en esencia, planos o recetas probadas para resolver problemas comunes en el desarrollo de software. No son fragmentos de código que copias y pegas, sino conceptos que adaptas a tu situación particular para que tu código sea más flexible, reutilizable y fácil de mantener.

1. Singleton (Creacional)
Este patrón asegura que una clase tenga una única instancia en todo el programa y proporciona un punto de acceso global a ella.

Utilidad: Ideal para manejar conexiones a bases de datos, sistemas de log o configuraciones globales donde tener múltiples copias causaría conflictos.

Strategy (De Comportamiento)
Permite definir una familia de algoritmos, poner cada uno en una clase separada y hacer que sus objetos sean intercambiables en tiempo de ejecución.

Utilidad: Muy útil para sistemas de pago (PayPal, Tarjeta, Cripto) o métodos de exportación de archivos (PDF, Excel, JSON) donde el usuario elige el método al momento de usar la app.


Observer (De Comportamiento)
Define una dependencia de "uno a muchos", de modo que cuando un objeto cambia su estado, todos sus dependientes son notificados y actualizados automáticamente.

Utilidad: Es el corazón de los sistemas de suscripciones, interfaces de usuario (UI) que reaccionan a datos o sistemas de notificaciones.