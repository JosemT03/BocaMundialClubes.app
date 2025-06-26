# 🎟️ BocaMundialClubes

Sistema de ventas de entradas y gestión de partidos del Club Atlético Boca Juniors para el Mundial de Clubes.  
Incluye panel de compras, informe de ventas, y administración con API y base de datos.

---

## 🚀 Tecnologías utilizadas

- 🧱 **.NET 7 / C#**
- 🌐 **ASP.NET Core Web API**
- 🖼️ **Windows Forms (WinForms)**
- 🗃️ **SQL Server + Entity Framework Core**
- 🔁 **Consumo de API con `HttpClient`**

---

## 🎯 Funcionalidades principales

### En el sistema WinForms:
- Ver lista de **partidos disponibles**
- Comprar entradas con:
  - Selección de tipo (`General`, `Platea`, `VIP`, `Popular`)
  - Ingreso de nombre y teléfono
- Ver **informe de ventas**
  - Editar nombre y teléfono
  - Eliminar venta

### En la API:
- CRUD de ventas (`GET`, `POST`, `PUT`, `DELETE`)
- Datos precargados de partidos y entradas

---

## 🧪 Cómo ejecutar el proyecto

### 1. Cloná el repositorio

```bash
git clone https://github.com/tuusuario/BocaMundialClubes.git
