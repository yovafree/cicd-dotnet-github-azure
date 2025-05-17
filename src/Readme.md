# StarWars.MVC 🚀

Aplicación ASP.NET Core MVC que consume la API pública de Star Wars (`https://swapi.info`) para mostrar películas y planetas. Incluye un proyecto de pruebas con xUnit.

---

## 📦 Requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Editor de código (Visual Studio, VS Code o Rider)

---

## 🛠 Estructura del proyecto

```
/StarWars.sln
/StarWars.MVC/           # Proyecto principal ASP.NET Core MVC
/StarWars.MVC.Tests/     # Proyecto de pruebas con xUnit
```

▶️ Ejecutar el proyecto

Abre una terminal en la raíz del repositorio.

Ejecuta la aplicación con el siguiente comando:

```
dotnet run --project StarWars.MVC
```

Abre el navegador y accede a:

    https://localhost:5001/Movies → Para ver películas

    https://localhost:5001/Planets → Para ver planetas

🧪 Ejecutar pruebas

Desde la raíz de la solución, ejecuta:

```
dotnet test
```

Este comando ejecutará las pruebas definidas en StarWars.MVC.Tests.