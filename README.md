# ⚽ RandomLeague

Welcome to **RandomLeague**  a simulation project for generating a random Premier League table and live score updates, all in-memory using C# and ASP.NET Core Web API.

This project is part of my journey to **apply Dependency Injection, Singleton lifetime management, in-memory data handling, and background task processing** in a clean, scalable API structure.

---

## 🚀 What I Was Learning
This project was built to:
- **Understand Dependency Injection** in .NET Core, with a focus on using `Singleton` services to maintain shared, in-memory state across requests.
- **Structure a clean CRUD API** following best practices, with proper layering:
  - Controllers
  - Services
  - Repositories
  - DTOs
  - Background Tasks
- **Use Background Services** to run simulations and update data on a schedule.
- **Handle in-memory data persistence** without a database.
- **Work with AutoMapper** to map domain models to DTOs efficiently.

---

## 📚 Key Takeaways
- ✅ **Singleton Dependency Injection** works perfectly for in-memory simulations and shared state, but wouldn’t be ideal for multi-user transactional data needing persistence.
- ✅ **Background Services** (`BackgroundService`) are excellent for running scheduled tasks outside HTTP requests.
- ✅ **Clean architecture and file structure** make a project scalable and easy to extend.
- ✅ **In-memory simulations** are quick and lightweight for prototyping and testing.
- ✅ **Randomized data generation** is a fun way to explore sorting, mapping, and presenting league tables.

---

## 🏗️ Project Structure
```text
/Controllers        // API Endpoints
/Models             // Domain Models (Teams, Fixtures, Standings)
/DTOs               // Data Transfer Objects
/Repositories       // In-Memory Data Management (Singleton)
/Services           // Business Logic Layer
/BackgroundTasks    // Background Match Simulation
/Mappings           // AutoMapper Profiles
Program.cs          // DI and App Configuration
