# ClickBuy API

API ini dibangun menggunakan **ASP.NET Core (C#)** dengan menerapkan **Clean Architecture**. Saat ini, fokus pengembangan API dikhususkan untuk melayani situs *customer-facing* (etalase pelanggan), memungkinkan pencarian dan transaksi produk dengan cepat dan aman.

## Struktur Project (Clean Architecture)
*   **clickbuy.Domain**: Berisi entitas inti (seperti `Product`).
*   **clickbuy.Application**: Berisi *interfaces* dan DTOs.
*   **clickbuy.Infrastructure**: Berisi konfigurasi Entity Framework Core dan implementasi Repository.
*   **clickbuy.api**: *Entry point* aplikasi (Controllers dan konfigurasi Dependency Injection).

## Tech Stack
*   .NET Core / C#
*   Entity Framework Core
*   SQL Server (via EF Migrations)
*   Swagger (Dokumentasi API)

## Project Scope & Roadmap
API ini difokuskan pada fitur *customer-facing* (etalase pelanggan) untuk mempercepat pengalaman belanja pengguna. Untuk fase MVP (*Minimum Viable Product*) saat ini, pengembangan difokuskan pada:

- [x] Setup Clean Architecture & Database
- [x] Product Catalog API (GET Endpoints)
- [ ] Shopping Cart & Checkout API
- [ ] Payment Gateway Integration

*(Catatan: Modul sistem Admin tidak disertakan dalam fase pengembangan ini).*