# RickyMorty

# Proyecto Blazor - Votación Rick y Morty

Este proyecto es una aplicación web desarrollada con **Blazor WebAssembly**, que permite ver los personajes de la serie **Rick y Morty** y **votar por tu favorito** mediante botones de Like y Dislike. El puntaje se actualiza dinámicamente.

---

## Descripción general

El objetivo del proyecto es practicar el consumo de APIs REST públicas desde una app Blazor WebAssembly, trabajar con componentes, eventos y datos dinámicos.

---

## Instrucciones para ejecutar la app

1. Clona el repositorio en tu Visual Studio (https://github.com/SaiitGM/PruebaRickyMorty).
2. Apretar el boton F5 el cual ejecutará el programa y abrirá automaticamente una ventana de navegación con la web lista para usar.
   
---

## Consumo de la API
Se utiliza la API pública de Rick and Morty:

https://rickandmortyapi.com/api/character

Se creó un servicio llamado PersonajeServicios que usa HttpClient para consultar los personajes y msotrar la respuesta con las clases PersonajeRespuesta y Personaje.

---

## Estructura del Código

/Pages
  Index.razor             -> Página de inicio con bienvenida e imagen
  Rick.razor              -> Página principal con personajes y votación

/Layout
  NavMenu.razor           -> Barra lateral de navegación
  MainLayout.razor        -> Layout principal de la aplicación

/Modelos
  Personaje.cs
  PersonajeRespuesta.cs

/Servicios
  PersonajeServicios.cs   -> Servicio para consumir la API

/wwwroot
  css/
    app.css               -> Estilos personalizados


---

## Funcionalidades adicionales

- Filtros por nombre, especie y estado.

- Votación con botones Like y Dislike.

- Interfaz adaptable a celular y escritorio (responsive con Bootstrap).

- Estilos personalizados.

---

## Decisiones técnicas
Se usó Blazor WebAssembly por su integración con C# en frontend.

Bootstrap como framework CSS para diseño responsivo y rápido.

Persistencia sin backend para mantener simple el código.

Se usaron componentes de Razor con eventos para interacción.
