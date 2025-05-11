# Community Announcement Board Web Application

## 📌 Project Summary

**Community Announcement Board** is a full-stack web application that allows users to create, view, edit, and delete classified ads. It supports hierarchical categories, a clean interface, and is built with a focus on modularity and deployment readiness.

This project demonstrates:
- ASP.NET Core Web API (Backend)
- ASP.NET MVC (Frontend UI)
- MS SQL Server with Stored Procedures (Database)
- Azure App Service Deployment

---

## 🛠️ Technologies Used

- **Backend**: ASP.NET Core Web API (.NET 6+)
- **Frontend**: ASP.NET MVC (Razor Views)
- **Database**: Microsoft SQL Server
- **Deployment**: Azure App Services
- **UI Styling**: Bootstrap 5

---

## 🔧 Features

### ✅ Functional Requirements

- Users can **Create**, **Read**, **Update**, and **Delete** (CRUD) announcements
- Each announcement includes:
  - Title
  - Description
  - Creation date
  - Status (Active/Inactive)
  - Category and Subcategory

## 🗃️ Database Structure

### Stored Procedures

- CreateAnnouncements
- DeleteCreateAnnouncements
- UpdateAnnouncement
- GetAnnouncements
- GetAnnouncementById
- GetAllCategories
- GetCategoryById
- GetAllSubCategries
- GetSubCategoryById
  
These procedures handle all database interactions via the API.

---

## 🧪 Running Locally

### Prerequisites

- .NET 8 SDK
- SQL Server (LocalDB or remote)
- Visual Studio 2022 or VS Code

### Steps

1. Clone the repo
2. Run SQL scripts to create table + stored procedures
3. Update connection strings in both API and MVC projects
4. Run API project (`dotnet run` or via Visual Studio)
5. Run MVC project and navigate to `https://localhost:{port}/Announcements`

---


