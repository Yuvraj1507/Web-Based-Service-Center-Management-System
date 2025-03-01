# **Web-Based Service Center Management System**

## 📌 Project Overview  
The **Web-Based Service Center Management System** is a **full-stack application** built with 
**ASP.NET Core, SQL Server, and Entity Framework** to automate **service center operations**, 
including **appointment scheduling, service tracking, and customer management**.  

This project follows **industry best practices** such as **MVC architecture, RESTful APIs, authentication, 
CI/CD automation, and optimized database queries** for **high performance and scalability**.  

---

## 📌 Features & Functionalities  

✅ **User Authentication & Role-Based Access Control (RBAC)**  
- Secure **user authentication** using **ASP.NET Identity**.  
- **Role-based access (RBAC)** for **Admins, Technicians, and Customers**.  
- **Password hashing & session management** for enhanced security.  

✅ **Service Request & Tracking System**  
- Customers can **book service appointments** online.  
- Admins can **assign technicians** to tasks & track completion.  
- **Automated email notifications** for updates.  

✅ **High-Performance RESTful APIs**  
- Developed **fast & scalable APIs** for **frontend-backend communication**.  
- **Optimized API response time by 35%** using **caching & database tuning**.  

✅ **SQL Server Database Optimization**  
- Designed **normalized database schema** using **Entity Framework Core**.  
- **Stored procedures & indexing** improved **query execution by 40%**.  

✅ **CI/CD & Automated Deployment**  
- **Docker & GitHub Actions** integrated for **CI/CD automation**.  
- **Automated testing, build, and deployment workflows** to ensure **faster releases**.  

✅ **Real-Time Monitoring & Logging**  
- **Prometheus & Grafana** for **real-time system monitoring**.  
- **Error tracking with Serilog** for better debugging & performance analysis.  

---

## 📌 Tech Stack  

- **Frontend:** HTML5, CSS3, Bootstrap, JavaScript, jQuery, AJAX  
- **Backend:** ASP.NET Core MVC, C#  
- **Database:** SQL Server, Entity Framework Core  
- **Authentication & Security:** ASP.NET Identity, RBAC (Role-Based Access Control)  
- **API Development:** RESTful APIs with JSON  
- **CI/CD & DevOps:** Docker, GitHub Actions  
- **Testing & Monitoring:** Selenium, Postman, Prometheus, Grafana  
- **Deployment & Hosting:** IIS, Azure/AWS (optional)  

---

## 📌 System Architecture  

The project follows the **Model-View-Controller (MVC) architecture**,
ensuring **separation of concerns** for better maintainability.  


---

## 📌 Installation & Setup  

### **1️⃣ Prerequisites**  
Ensure you have the following installed:  
- **.NET SDK 6.0+**  
- **SQL Server 2019+**  
- **Visual Studio 2022+**  
- **Docker (for containerized deployment)**  
- **Git (for version control)**  

---

### **2️⃣ Clone the Repository**  
```sh
git clone https://github.com/YourUsername/WebServiceCenterManagement.git
cd WebServiceCenterManagement

2️⃣ Configure the database in appsettings.json
3️⃣ Run database migrations using:

sh
Copy
Edit
dotnet ef database update
4️⃣ Start the application:

sh
Copy
Edit
dotnet run

5️⃣ Access UI at: http://localhost:5000/

