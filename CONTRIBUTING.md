## Convención de Ramas

Para mantener el orden en el repositorio, seguimos esta estructura de ramas:

- `main` → Rama estable con el código final.
- `dev` → Rama de desarrollo principal.
- `feature/nombre` → Para nuevas funcionalidades (Ejemplo: `feature/salto-doble`).
- `bugfix/nombre` → Para correcciones de errores (Ejemplo: `bugfix/colisiones`).
- `hotfix/nombre` → Para correcciones urgentes en `main` (Ejemplo: `hotfix/crash-al-iniciar`).

### Flujo de trabajo:
1. Crear una nueva rama a partir de `dev` para trabajar en una funcionalidad o bug.
2. Hacer commits claros y descriptivos siguiendo la convención de mensajes.
3. Crear un **Pull Request** hacia `dev` cuando la tarea esté lista.
4. Esperar revisión antes de hacer `merge`.
