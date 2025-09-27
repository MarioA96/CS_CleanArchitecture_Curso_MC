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

1. Crea el proyecto desde la carpeta que contenga la solucion
Por ejmplo, tengo la carpeta llamada: CleanArchitecture, dentro de esta contiene la solucion CleanArchitecture.sln, entonces.
```bash
$ cd ./CleanArchitecture
$ dotnet new console -n Proyecto_1 -o Proyecto_1
```

2. Luego de creaado el proyecto, debes añadir esté a la solucion, desde ahi mismo hacemos (no es necesario agregar el .csproj):
```bash
$ dotnet sln add Proyecto_1
```
