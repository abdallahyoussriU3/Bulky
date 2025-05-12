
# 🚀 Bulky Book – ASP.NET Core Web Application

A complete **e-commerce platform** built using **ASP.NET Core**, showcasing real-world use of modern .NET technologies with best practices in architecture, authentication, and third-party integrations.

---

## 📌 Project Overview

**Bulky Book** is a fully featured online shopping web application. It provides:

- 🛒 A smooth shopping experience for customers  
- 🧑‍💼 An intuitive dashboard for administrators  
- 🔐 Secure authentication and authorization  
- 📦 End-to-end order processing  
- 📈 A scalable backend using the **Repository Pattern** and **N-Tier Architecture**

This project highlights solid application design using **ASP.NET Core MVC**, **Entity Framework Core**, and external API integrations like **Stripe**.

---

## ✨ Features

### 🛍️ Customer Features
- Browse and search for products
- Add items to the cart
- Checkout using **Stripe** payment
- View order history & status
- Receive email notifications

### 🔑 Authentication & Security
- Authentication & authorization using **ASP.NET Identity**
- Support for **Google & Facebook OAuth**
- Role-based access: Admin, Customer, Guest
- Secure password storage & token-based authentication

### 🛠️ Admin Dashboard
- Manage products with full CRUD functionality
- Process and update order statuses
- View sales analytics and reports
- Manage user roles and permissions

---

## 🏗️ Tech Stack

| Technology             | Description                                     |
|------------------------|-------------------------------------------------|
| **ASP.NET Core MVC**   | Backend framework for building the application |
| **Entity Framework**   | ORM for database operations                     |
| **SQL Server**         | Relational database system                      |
| **Identity Framework** | Authentication and user management              |
| **Stripe API**         | Secure payment processing                       |
| **Bootstrap**          | Frontend styling and responsiveness             |
| **Azure**              | Deployment and hosting                          |

---

## 🚀 Getting Started

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/abdallahyoussriU3/BulkyBook.git
cd BulkyBook
```

### 2️⃣ Configure Database

Update your `appsettings.json` with a valid SQL Server connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=BulkyBook;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### 3️⃣ Apply Migrations

```bash
Update-Database
```

### 4️⃣ Run the Project

Start the application via Visual Studio or using the .NET CLI:

```bash
dotnet run
```

---

## 🧑‍💼 Why Bulky Book?

This project is a solid portfolio piece demonstrating:

- Real-world ASP.NET Core MVC practices
- Proper use of design patterns like **Repository + Unit of Work**
- Secure authentication and payment integration
- Role-based systems and clean UI

