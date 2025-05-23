# 🚀 CI/CD con .NET, GitHub Actions y Azure

> Proyecto de demostración para la charla **"Del Código a la Nube: CI/CD con .NET, GitHub y Azure"**.  
> Esta aplicación ASP.NET Core MVC consume una API pública de Star Wars y muestra cómo automatizar el ciclo completo de desarrollo: compilación, pruebas, contenerización y despliegue.

---

## 📦 Tecnologías utilizadas

- [.NET 9 (Preview)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- ASP.NET Core MVC
- GitHub Actions
- Docker
- xUnit para pruebas
- Docker Hub / GHCR
- Azure (opcional para despliegue)

---
⚙️ CI/CD con GitHub Actions

El flujo de trabajo se encuentra en .github/workflows/docker-ci.yml.
Incluye:

    Build con .NET 9

    Pruebas con xUnit

    Construcción y publicación de imagen Docker a Docker Hub o GHCR

Se ejecuta automáticamente al hacer push a la rama master.

