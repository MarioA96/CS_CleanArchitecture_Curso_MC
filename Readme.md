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

### Inmutabilidad
La inmutabilidad se refiere a la propiedad de los datos que no pueden ser
modificados después de su creación. En la programación funcional, se fomenta el
uso de estructuras de datos inmutables para evitar efectos secundarios y mejorar
la predictibilidad del código.

### Currying
El currying es una técnica que transforma una función que toma múltiples
argumentos en una secuencia de funciones que toman un solo argumento. Esto
permite la creación de funciones más específicas y facilita la composición de
funciones.

#### Delegados
Los delegados son tipos que representan referencias a métodos con una firma
específica. Permiten pasar métodos como parámetros y definir funciones de orden
superior.

#### Action
`Action` es un tipo de delegado que representa un método que no devuelve un
valor (void) y puede tomar de 0 a 16 parámetros. Se utiliza comúnmente para definir
métodos que realizan acciones sin devolver resultados.

#### Tipo func
`Func` es un tipo de delegado que representa un método que devuelve un valor y
puede tomar de 0 a 16 parámetros. Se utiliza para definir funciones que realizan
cálculos y devuelven resultados.

### Expresiones lambda
Las expresiones lambda son funciones anónimas que se pueden definir de manera
concisa. Se utilizan comúnmente para pasar funciones como argumentos a otras
funciones, especialmente en operaciones de colección como filtrado, mapeo y
reducción.

#### Funciones lambda con múltiples parámetros
Las funciones lambda pueden aceptar múltiples parámetros separados por comas. Por
ejemplo, una función lambda que toma dos parámetros `x` e `y` y devuelve su suma se
puede definir como `(x, y) => x + y`.

#### Funciones de orden superior con expresiones lambda
Las funciones de orden superior pueden utilizar expresiones lambda como argumentos. Por
ejemplo, se puede definir una función de orden superior que toma una función lambda
como parámetro y la aplica a una lista de valores.

#### Predicados con expresiones lambda
Los predicados son funciones que devuelven un valor booleano (true o false). Se pueden definir utilizando expresiones lambda para filtrar colecciones
basadas en condiciones específicas. Por ejemplo, una expresión lambda que verifica si un número es par se puede definir como `number => number % 2 == 0`.

---

## Programacion Full Stack
### Responsabilidades
- Presentacion
Este nivel es responsable de interactuar con el usuario final y mostrar la
informacion de manera clara y atractiva. Incluye la interfaz de usuario (UI) y
la experiencia de usuario (UX).
  - Frontend: Se encarga de la parte visual y la interaccion con el usuario.
  - Capa no necesariamente web, puede ser una aplicacion de escritorio o movil.
  - Incluso los servicios que exponen API REST o GraphQL pueden considerarse parte del
    frontend.
  - Esto puede incluir videojuegos, aplicaciones de escritorio, aplicaciones móviles, 
    realidad aumentada, etc.
  
Cuando se trabaja frontend con C# .net se utilizara Blazor para aplicaciones web

- Logica de negocio
Este nivel maneja las reglas y procesos que definen el funcionamiento de la
aplicacion. Se encarga de procesar los datos, aplicar las reglas de negocio y
tomar decisiones basadas en la logica definida.
  - Backend: Se encarga de la logica de negocio y la comunicacion con el
     frontend y la base de datos.

En este caso se usara la tecnologia ASP .NET Core para crear aplicaciones web robustas y escalables
con y usaremos Entity Framework Core como ORM para interactuar con bases de datos relacionales.
Pero aqui usaremos .NET Minimal APIs para crear servicios backend ligeros y eficientes.

- Acceso a datos
Este nivel se encarga de interactuar con las fuentes de datos, como bases de
datos, servicios web y sistemas externos. Proporciona una capa de abstraccion
para acceder y manipular los datos de manera eficiente y segura.
  - Base de datos: Se encarga de almacenar y gestionar los datos de la
    aplicacion.

En el caso de este proyecto se hara uso de SQL Server como sistema de gestion de bases de datos relacionales.

## El protocolo HTTP
HTTP (Hypertext Transfer Protocol) es el protocolo de comunicacion utilizado en la web para transferir datos entre clientes (como navegadores web) y servidores. Funciona mediante un modelo de solicitud-respuesta, donde el cliente envia una solicitud al servidor y este responde con los datos solicitados.

### Metodos HTTP
Los metodos HTTP definen las acciones que se pueden realizar sobre los recursos en la web. Los metodos mas comunes son:
- GET: Se utiliza para solicitar datos de un recurso especifico. No debe tener efectos secundarios y es seguro.
- POST: Se utiliza para enviar datos al servidor para crear un nuevo recurso. Puede tener efectos secundarios.
- PUT: Se utiliza para actualizar un recurso existente con nuevos datos. Puede tener efectos secundarios.
- DELETE: Se utiliza para eliminar un recurso especifico. Puede tener efectos secundarios.

### Codigos de estado HTTP
Los codigos de estado HTTP indican el resultado de una solicitud HTTP. Algunos codigos comunes son
- 200 OK: La solicitud se ha procesado correctamente y se ha devuelto el recurso solicitado.
- 201 Created: La solicitud se ha procesado correctamente y se ha creado un nuevo recurso.
- 204 No Content: La solicitud se ha procesado correctamente, pero no hay contenido para devolver.
- 301 Moved Permanently: El recurso solicitado se ha movido permanentemente a una nueva URL.
- 302 Found: El recurso solicitado se ha movido temporalmente a una nueva URL.
- 400 Bad Request: La solicitud es invalida o no se puede procesar debido a errores del cliente.
- 401 Unauthorized: La solicitud requiere autenticacion y el cliente no ha proporcionado credenciales validas.
- 403 Forbidden: El cliente no tiene permiso para acceder al recurso solicitado.
- 404 Not Found: El recurso solicitado no se ha encontrado en el servidor.
- 500 Internal Server Error: Ha ocurrido un error en el servidor al procesar la solicitud.

### Solicitudes y respuestas HTTP
Una solicitud HTTP consta de una linea de solicitud, encabezados y un cuerpo opcional. 
- La linea de solicitud incluye el metodo HTTP, la URL del recurso y la version del protocolo. 
- Los encabezados proporcionan informacion adicional sobre la solicitud, como el tipo de contenido aceptado y las credenciales de autenticacion. 
- El cuerpo de la solicitud contiene los datos que se envian al servidor, si es necesario.

Ejemplo de solicitud HTTP:
```
POST /api/resource HTTP/1.1
Host: example.com
User-Agent: Mozilla/5.0
Content-Type: application/json
Authorization: Bearer <token>

{
  "name": "New Resource",
  "description": "This is a new resource."
}
```

Una respuesta HTTP consta de una linea de estado, encabezados y un cuerpo opcional.
- La linea de estado incluye la version del protocolo, el codigo de estado y un mensaje descriptivo. 
- Los encabezados proporcionan informacion adicional sobre la respuesta, como el tipo de contenido devuelto y la longitud del contenido. 
- El cuerpo de la respuesta contiene los datos solicitados, si es necesario.

Ejemplo de respuesta HTTP:
```
HTTP/1.1 201 Created
Date: Mon, 27 Sep 2021 12:00:00 GMT
Server: Apache/2.4.41 (Ubuntu)
Content-Type: application/json
Content-Length: 85
Location: /api/resource/123

{
  "id": 123,
  "name": "New Resource",
  "description": "This is a new resource."
}
```

### Interaccion HTTP
La interaccion HTTP entre un cliente y un servidor sigue un flujo de trabajo tipico:
1. El cliente envia una solicitud HTTP al servidor especificando el metodo, la URL y los encabezados necesarios.
2. El servidor procesa la solicitud, aplica la logica de negocio y accede a los datos si es necesario.
3. El servidor genera una respuesta HTTP con el codigo de estado adecuado, los encabezados y el cuerpo de la respuesta.
4. El cliente recibe la respuesta y procesa los datos devueltos, mostrando la informacion al usuario o realizando acciones adicionales.

### Formato JSON
JSON (JavaScript Object Notation) es un formato ligero de intercambio de datos que es facil de leer y escribir para los humanos, y facil de parsear y generar para las maquinas. Se utiliza comunmente en aplicaciones web para enviar y recibir datos entre el cliente y el servidor.
Un objeto JSON se representa como una coleccion de pares clave-valor, donde las claves son cadenas de texto y los valores pueden ser cadenas, numeros, booleanos, arreglos u otros objetos JSON.
Ejemplo de objeto JSON:
```json
{
  "id": 1,
  "name": "John Doe",
  "email": "john.doe@example.com",
  "isActive": true,
  "roles": ["admin", "user"],
  "address": {
    "street": "123 Main St",
    "city": "Anytown",
    "zip": "12345"
  }
}
```

### Serializacion y deserializacion JSON
La serializacion es el proceso de convertir un objeto en una cadena JSON para su almacenamiento o transmision. La deserializacion es el proceso inverso, donde una cadena JSON se convierte de nuevo en un objeto.
En C#, se pueden utilizar bibliotecas como `System.Text.Json` o `Newtonsoft.Json` para realizar la serializacion y deserializacion de objetos JSON.
Ejemplo de serializacion en C#:
```csharp
using System.Text.Json;

var user = new User
{
    Id = 1,
    Name = "John Doe",
    Email = "john.doe@example.com",
    IsActive = true,
    Roles = new[] { "admin", "user" },
    Address = new Address
    {
        Street = "123 Main St",
        City = "Anytown",
        Zip = "12345"
    }
};

string json = JsonSerializer.Serialize(user);


var people = new People()
{
  Id = 1,
  Name = "Jane Doe",
  Country = "USA"
}

public class People
{
  public int Id {get; set;}
  public string Name {get; set;}
  public string Country {get; set;}
}

string json = JsonSerializer.Serialize(people);

Console.WriteLine(json);
```

Ejemplo de deserializacion en C#:
```csharp
using System.Text.Json;

People people2 = JsonSerializer.Deserialize<People>(json);

Console.WriteLine(people2.Name);
```