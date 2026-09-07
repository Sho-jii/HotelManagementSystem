# 🏨 Hotel Management System

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23%20WinForms-239120?style=flat-square&logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server%20%2F%20LocalDB-CC292B?style=flat-square&logo=microsoftsqlserver)](https://www.microsoft.com/en-us/sql-server/)
[![UI Library](https://img.shields.io/badge/UI-Guna2%20UI-0078D7?style=flat-square)](https://gunai.net/)
[![Project Type](https://img.shields.io/badge/Project-Commissioned%20Freelance%20(1st%20Year)-success?style=flat-square)](#about-this-project)

A desktop **Hotel Front-Desk Management System** built with **C# Windows Forms**, **Guna2 UI**, and **Microsoft SQL Server (LocalDB)**. Designed to automate room inventory, guest allocation, check-in registration, check-out billing, guest records, and staff access control.

---

## 📌 About This Project

> **Freelance / Commission Context**: This application was originally created during my **1st year of college** as a paid freelance commissioned project for fellow students to meet their course and subject requirements. It marked one of my earliest experiences delivering custom desktop software solutions for paying clients, gathering requirements, and building end-to-end database-backed applications.

---

## ✨ Key Features

### 🛏️ 1. Room Inventory & Pricing (`AddRooms`)
- Add, update, and manage hotel rooms with custom room numbers, room types (e.g., Single, Double, Deluxe), bed configurations, and daily rates.
- Automatic booking status tracking (`booked = 'NO'` / `'YES'`) to ensure rooms cannot be double-booked.

### 📝 2. Guest Registration & Room Allocation (`CustomerRegistration`)
- Step-by-step guest intake capturing full name, contact number, nationality, gender, date of birth, ID proof, address, and check-in date.
- Dynamic room selection dropdowns that automatically filter only currently available (unbooked) rooms matching selected bed and room type.
- Atomic room allocation that links customer records to the assigned room and updates room status.

### 💳 3. Guest Check-Out & Billing (`CustomerCheckout`)
- Real-time search by guest name to locate active, currently-staying customers.
- Instant check-out calculation and timestamp recording, immediately releasing the room back into available inventory.

### 🔍 4. Guest Directory & Records (`ViewCustomerDetails` & `EditCustomerDetails`)
- Filterable customer directory:
  - **All Customers** (complete guest history)
  - **In Hotel** (currently checked-in guests)
  - **Checked Out** (historical guests)
- In-place guest information modification and contact updating.

### 👥 5. Staff & User Access Management (`AddUsers`)
- Administrative control to register, update, and remove staff user accounts with active status verification.

---

## 🛠️ Technology Stack

| Component | Technology / Library |
| :--- | :--- |
| **Language** | C# (.NET Framework 4.8) |
| **UI Framework** | Windows Forms (WinForms) |
| **UI Styling** | Guna2 UI Controls (`Guna.UI2.WinForms`) |
| **Database** | Microsoft SQL Server LocalDB (`(LocalDB)\MSSQLLocalDB`) |
| **Data Access** | ADO.NET (`System.Data.SqlClient`) with Parameterized Queries |
| **Architecture** | Dynamic LocalDB Resolver, Clean Resource Management (`using` scopes) |

---

## 🚀 Getting Started

### Prerequisites
- **Visual Studio 2019 / 2022** (with *.NET desktop development* workload)
- **.NET Framework 4.8 Developer Pack**
- **Microsoft SQL Server LocalDB** (bundled with Visual Studio)

### Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Sho-jii/HotelManagementSystem.git
   cd HotelManagementSystem
   ```

2. **Open the Solution**:
   - Double-click `HotelManagementSystem.sln` to open in Visual Studio.

3. **Database Configuration**:
   - The application automatically discovers and attaches the included database (`inventoryHotel.mdf`) at runtime on any PC.
   - To inspect or run database setup scripts manually, refer to:
     ```text
     SQLQuery1.sql
     ```

4. **Build and Run**:
   - Press **F5** or click **Start** in Visual Studio.

### Default Credentials
| Username | Password | Status |
| :--- | :--- | :--- |
| `admin` | `admin123` | Active |

---

## 📂 Project Architecture

```plaintext
HotelManagementSystem/
├── AddRooms.cs               # Room creation, rate configuration & inventory
├── CustomerRegistration.cs   # Guest check-in & automated room allocation
├── CustomerCheckout.cs       # Active guest billing & room release
├── ViewCustomerDetails.cs    # Filterable guest directory (In-hotel vs Checked-out)
├── EditCustomerDetails.cs    # Customer profile update dialog
├── AddUsers.cs               # Staff user accounts administration
├── Dashboard.cs              # Main dashboard navigation container
├── Login.cs                  # User authentication with active role checks
├── function.cs               # Dynamic LocalDB connection & parameterized helper
├── UsersData.cs              # User entity data mapper
├── inventoryHotel.mdf        # LocalDB SQL database file
├── SQLQuery1.sql             # SQL schema definitions and table queries
└── README.md                 # Project & freelance documentation
```

---

## 📄 License
This project is open-source and available under the [MIT License](LICENSE).
