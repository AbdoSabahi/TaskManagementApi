# Task Management API

## Description
This repository contains:
- Task Management REST API
- Coding challenge (Remove Duplicates)
- SQL challenge (JOIN query)

---

## Tech Stack
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

---

## API Endpoints
- POST /tasks
- GET /tasks
- GET /tasks?status=pending
- DELETE /tasks/{id}

---

## Run
```powershell
add-migration InitialCreate
update-database

