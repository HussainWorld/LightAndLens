# [LightAndLens Rental System](https://github.com/HussainWorld/LightAndLens.git)

## **Project Overview**  
**LightAndLens** is a rental management system designed for a camera and photography equipment store. It consists of:  

- **ASP.NET MVC Web Application** <br>
Used by customers to browse equipment and submit rental requests.
Used by admins/staff to manage users, approve rentals, and view analytics.

- **Windows Forms Application** <br>
A secure desktop interface for backend operations (e.g., inventory management, bulk approvals, or local reporting).


The system allows customers to rent equipment, while admins and staff manage user roles, approve rental requests, and view shop analytics.  

### **Technologies Used**  
- **Backend:** C#, ASP.NET MVC, Entity Framework
- **Authentication:** ASP.NET Identity
- **Frontend:** HTML, CSS, JavaScript, Bootstrap
- **Database:** SQL Server (Managed via SQL Server Management Studio - SSMS)  

---

## **Key Features**

### **Web App (ASP.NET MVC)**  
- **Role-Based Access**:  
  - **Admins**: Full control (user management, analytics, rentals).  
  - **Staff**: Approve/reject rentals, view customer requests.  
  - **Customers**: Browse gear, submit rental requests.  
- **Dashboard**: Real-time shop analytics (rentals, revenue, inventory).  
- **Identity Authentication**: Secure login/signup with password hashing.  

### **Windows Forms App (Admin/Staff Only)**  
- **Secure Access**: Requires admin/staff credentials.  
- **Backend Operations**:  
  - Bulk inventory updates.  
  - Local data processing/reporting.  
  - Sync with the web app’s database.  

---

## **Default Accounts (For Testing)**  
- **Admin**:  
  - Email: `admin@lightandlens.com`  
  - Password: `Admin@123`  
- **Staff**:  
  - Email: `staff@lightandlens.com`  
  - Password: `Staff@123`  

---

## **Additional Notes**  
- **Security**: Passwords are hashed using ASP.NET Identity.  
- **Logs**: Check `Logs/` folder.  
- **Future Improvements**:  
  - Mobile app integration.  
  - Payment gateway (e.g., BenefitPay).  
  - Email notifications for rentals.  

---

## **Developed By**  
- [Hussain AlShaikh - Talal Alhawaj - Ali AlArab - Isa Alansari]  
- **Course**: IT8118 - Bahrain Polytechnic  

---

Take a shot ! 📷
