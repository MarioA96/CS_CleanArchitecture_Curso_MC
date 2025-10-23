# C# / Dotnet

## Generacion de nuevo proyecto

```bash
$ dotnet new console -n <Project Name> -o ./<Directory Name To Save Project>
```

## Generacion de bin, obj y la ejecucion del programa

```bash
$ dotnet run Program.cs
```

## Generacion de nueva solucion

```bash
$ dotnet new sln --name <Name of Solution>
```

## Agregar proyecto a la solucion

```bash
$ dotnet sln add StructureProgramming.csproj
```

## Pasos recomendados

1. Crea el proyecto desde la carpeta que contenga la solucion Por ejmplo, tengo
   la carpeta llamada: CleanArchitecture, dentro de esta contiene la solucion
   CleanArchitecture.sln, entonces.

```bash
$ cd ./CleanArchitecture
$ dotnet new console -n Proyecto_1 -o Proyecto_1
```

2. Luego de creaado el proyecto, debes añadir esté a la solucion, desde ahi
   mismo hacemos (no es necesario agregar el .csproj):

```bash
$ dotnet sln add Proyecto_1
```

## Data Structures

---

## OOP

### Objetos

Los objetos son instancias de clases y representan entidades del mundo real.
Tienen propiedades (atributos) y métodos (comportamientos) que definen su estado
y funcionalidad.

### Clases

Las clases son plantillas o moldes para crear objetos. Definen las propiedades y
métodos que los objetos creados a partir de la clase tendrán.

### Herencia

La herencia permite que una clase (clase derivada o subclase) herede propiedades
y métodos de otra clase (clase base o superclase). Esto promueve la
reutilización del código y establece una relación jerárquica entre las clases.

### Encapsulamiento

El encapsulamiento es el principio de ocultar los detalles internos de una clase
y exponer solo lo necesario a través de una interfaz pública. Esto se logra
mediante modificadores de acceso (public, private, protected) y propiedades.

### Polimorfismo

El polimorfismo permite que diferentes clases sean tratadas como instancias de
la misma clase a través de una interfaz común. Esto se puede lograr mediante la
sobrecarga de métodos y la implementación de interfaces.

#### Sobrecarga de métodos

La sobrecarga de métodos permite definir múltiples métodos con el mismo nombre
pero diferentes parámetros (tipo o cantidad). Esto mejora la legibilidad y
usabilidad del código.

#### Sobrescritura de métodos

La sobrescritura de métodos permite a una clase derivada proporcionar una
implementación específica de un método que ya está definido en su clase base.
Esto se logra utilizando la palabra clave `override` en el método de la clase
derivada.

#### Métodos virtuales

Los métodos virtuales son métodos en una clase base que pueden ser sobrescritos
en una clase derivada. Se definen utilizando la palabra clave `virtual` en la
clase base. Esto permite que las clases derivadas proporcionen una
implementación específica del método.

#### Métodos abstractos

Los métodos abstractos son métodos que se declaran en una clase base pero no
tienen implementación. Las clases derivadas deben proporcionar una
implementación para estos métodos. Se utilizan para definir un contrato que las
clases derivadas deben cumplir. Se definen utilizando la palabra clave
`abstract` en la clase base.

### Abstract

Las clases abstractas son clases que no se pueden instanciar directamente y se
utilizan como base para otras clases. Pueden contener métodos abstractos (sin
implementación) que deben ser implementados por las clases derivadas.

### Polimorfismo con clases abstractas

El polimorfismo con clases abstractas se refiere a la capacidad de tratar
objetos de diferentes clases derivadas como si fueran instancias de la clase
base abstracta. Esto se logra mediante la implementación de métodos abstractos
en las clases derivadas, lo que permite que cada clase proporcione su propia
versión del método.

### Interface

Las interfaces definen un contrato que las clases deben cumplir. Una interfaz
puede contener métodos y propiedades, pero no puede contener implementación. Las
clases pueden implementar múltiples interfaces.

#### Upcasting y Downcasting

- Upcasting: Convertir un objeto de una clase derivada a una clase base. Es
  seguro y no requiere una conversión explícita.
- Downcasting: Convertir un objeto de una clase base a una clase derivada.
  Requiere una conversión explícita y puede fallar en tiempo de ejecución si el
  objeto no es realmente una instancia de la clase derivada.

### Generics

Los genéricos permiten definir clases, interfaces y métodos con un tipo de dato
parametrizado. Esto proporciona flexibilidad y reutilización del código al
permitir que una misma estructura de datos o algoritmo funcione con diferentes
tipos de datos.

### Static

Los miembros estáticos (métodos y propiedades) pertenecen a la clase en sí misma
en lugar de a instancias individuales de la clase. Se definen utilizando la
palabra clave `static`. Los miembros estáticos se pueden acceder sin crear una
instancia de la clase.

---

## Programacion Funcional

### Funciones de orden superior

Las funciones de orden superior son aquellas que pueden recibir otras funciones
como argumentos o devolverlas como resultado. Esto permite una mayor abstracción
y composición de funciones, facilitando la creación de código más modular y
reutilizable.

### Funciones puras

Las funciones puras son aquellas que, dado un conjunto de entradas, siempre
devuelven el mismo resultado y no tienen efectos secundarios observables. Esto
facilita la prueba y el razonamiento sobre el código, ya que las funciones puras
son predecibles y no dependen del estado externo.
