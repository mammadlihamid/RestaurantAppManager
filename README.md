# 🍽️ **Restaurant Management System**

## 📖 **Introduction**  
Welcome to the **Restaurant Management System** built with **.NET 8.0**! This platform offers a seamless experience to manage your restaurant's operations, including team members, testimonials, and menu management, all from an intuitive admin panel.

---

## 🌟 **Features**

### 🔑 **Admin Panel**  
- **Manage Teams** 👨‍🍳👩‍🍳  
  Effortlessly add, update, and remove team members.  
   
- **Manage Testimonials** ✍️  
  Display customer feedback dynamically.  

- **Food Menu Management** 🍔🍕  
  Create and organize your menu with images, prices, and tags.  

- **Dashboard** 📊  
  One-stop for monitoring all sections.  

### 💻 **User Interface**  
- **About Section** 🏠  
  Tell your restaurant's story in style.  

- **Menu Showcase** 📜  
  Present your delectable dishes with rich visuals.  

- **Testimonials Carousel** 🌟  
  Interactive customer reviews section.  

- **Contact Form with Google Maps** 📍  
  Help your customers connect and locate you easily.  

### 🚀 **Other Key Features**  
- **CRUD Operations** for all entities.  
- **Rich Text Editing** powered by **ClassicEditor**.  
- **DataTables Integration** 📊 for interactive data.  
- **Alert Popups** 🚨 using **SweetAlert2**.  
- **Image Handling** 📸 for teams and menu items.  

---

## 🛠️ **Technology Stack**

- **Framework**: ASP.NET Core **8.0**  
- **Database**: SQL Server  
- **ORM**: Entity Framework Core  
- **Frontend**: HTML, CSS, JavaScript  
- **Libraries**:  
  - **Bootstrap 5.3** 🎨  
  - **jQuery** 💡  
  - **SweetAlert2** 🚨  
  - **Owl Carousel** 🦉  
  - **DataTables** 📊  
  - **Magnific Popup** 🖼️  

---

## 📂 **Application Structure**  

### 🗂️ **Project Root Directory**  

```plaintext
RestaurantProject/
├── Areas/                          # Admin Panel Specific Modules
│   └── Admin/
│       ├── Controllers/            # Controllers for Admin-specific routes
│       ├── Views/                  # Views for Admin UI
│       │   ├── Team/               # Views for Team Management
│       │   ├── Testimonial/        # Views for Testimonial Management
│       │   ├── Food/               # Views for Food Menu Management
│       │   ├── About/              # Views for About Section
│       │   └── Position/           # Views for Positions (roles)
│       └── wwwroot/                # Static files for Admin Panel (CSS, JS, images)
│
├── Controllers/                    # Public-facing controllers
│   ├── HomeController.cs           # Main website logic
│   └── ErrorController.cs          # Error handling
│
├── Models/                         # Models for data representation
│   ├── HomeViewModel.cs            # View model for Home page
│   └── ErrorViewModel.cs           # View model for errors
│
├── Views/                          # Views for public-facing UI
│   ├── Shared/                     # Shared layout views
│   │   └── _Layout.cshtml          # Main layout for public pages
│   ├── Home/                       # Views for Home Controller
│   │   ├── Index.cshtml            # Homepage view
│   │   └── Privacy.cshtml          # Privacy policy view
│   └── Error/                      # Error views
│
├── wwwroot/                        # Public static files (accessible via browser)
│   ├── css/                        # Stylesheets
│   ├── js/                         # JavaScript files
│   ├── images/                     # Public images (e.g., logos, icons)
│   └── lib/                        # External libraries (e.g., jQuery, Bootstrap)
│
├── appsettings.json                # Application configuration
├── Program.cs                      # Entry point for the application
└── Startup.cs                      # Configures services and middleware
```

### 🔍 **Detailed Breakdown of Important Directories**  

#### **Areas/Admin/**  
This folder contains all files related to the admin panel.  

- **Controllers/**: Handles business logic for different sections like Team, Food, and Testimonials.  
- **Views/**: Contains Razor Views for each admin section.  
- **wwwroot/**: Admin-specific static files.  

#### **Controllers/**  
These are public-facing controllers that manage requests for the main website.  

#### **Models/**  
Contains classes for data structures and view models for passing data between controllers and views.  

#### **Views/**  
Organized into controller-specific folders. This folder also contains shared layouts and partial views.  

#### **wwwroot/**  
Houses all the static files, including JavaScript, CSS, and images. This directory ensures easy access to client-side resources.

---

## 📥 **Installation Guide**

### **Prerequisites** 🔍  
1. **.NET 8.0 SDK** ([Download](https://dotnet.microsoft.com/))  
2. **SQL Server** (Any edition)  
3. **Visual Studio 2022** or later  

### **Steps** 🚶‍♂️  

1. **Clone the Repository**  
   ```bash  
   git clone https://github.com/mammadlihamid/restaurantappmanager.git  
   cd restaurant-management  
   ```  

2. **Open the Project**  
   Open `RestaurantProject.sln` in Visual Studio.  

3. **Configure Database**  
   Update the connection string in `appsettings.json`:  
   ```json  
   "ConnectionStrings": {  
     "DefaultConnection": "Server=your_server_name;Database=RestaurantDB;Trusted_Connection=True;MultipleActiveResultSets=true"  
   }  
   ```  

4. **Apply Migrations**  
   Run the following command in **Package Manager Console**:  
   ```bash  
   update-database  
   ```  

5. **Run the Application**  
   Press `F5` to start. Access the app at `https://localhost:{port}/`.  

---

## 📸 **Screenshots**

### **Admin Dashboard**  
![Admin Dashboard Placeholder](assets/screenshots/admin-dashboard.png)  

### **About Management**  
![Team Management Placeholder](assets/screenshots/team-management.png)  

### **Team Management**  
![Team Management Placeholder](assets/screenshots/team-management.png)  

### **Team Management**  
![Team Management Placeholder](assets/screenshots/team-management.png)  

### **Menu Showcase**  
![Menu Showcase Placeholder](assets/screenshots/menu-showcase.png)  

### **Testimonials**  
![Testimonials Placeholder](assets/screenshots/testimonials.png)  

---

## 📜 **License**  
This project is licensed under the **MIT License**. Check the `LICENSE` file for more details.  

---

## ✉️ **Contact**  

For any questions or feedback:  

**👤 Name**: Hamid Mammadli
**📧 Email**: hemid359@gmail.com 
**🔗 GitHub**: [github.com/mammadlihamid](https://github.com/mammadlihamid)  