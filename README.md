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

## 🏗️ **N-Tier Architecture**

The **Restaurant Management System** is designed using an **N-Tier Architecture** to ensure modularity, maintainability, and scalability. This architecture divides the application into distinct layers, each responsible for a specific function:

### 1. **Presentation Layer (PL)**  
   **Purpose**: The user-facing layer responsible for UI and user interactions.  

   **Key Responsibilities**:
   - Displays data to users via Razor Views.
   - Captures and validates user inputs.
   - Communicates with the **Business Logic Layer** to retrieve and display data.

   **Components**:
   - **Controllers** (e.g., `HomeController`, `Admin/TeamController`).
   - **Views** (e.g., Razor templates for displaying data).

---

### 2. **Business Logic Layer (BLL)**  
   **Purpose**: Contains the core logic and rules of the application.  

   **Key Responsibilities**:
   - Processes data from the **Presentation Layer**.
   - Enforces business rules and validation.
   - Communicates with the **Data Access Layer** for database operations.

   **Components**:
   - **Services** (e.g., `TeamService`, `TestimonialService`).

---

### 3. **Data Access Layer (DAL)**  
   **Purpose**: Manages all interactions with the database.  

   **Key Responsibilities**:
   - Executes CRUD operations on the database.
   - Maps database entities to domain models using **Entity Framework Core**.

   **Components**:
   - **DbContext** (e.g., `RestaurantDbContext` for managing database connections).
   - **Repositories** (optional for abstracting data access logic).

---

### 4. **Database Layer (DB)**  
   **Purpose**: Stores application data persistently.  

   **Key Responsibilities**:
   - Organizes data in tables.
   - Enforces data integrity with constraints and keys.
   - Provides data to the **Data Access Layer**.

   **Technology**:
   - SQL Server.

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
│       │   └── Position/           # Views for Position Management
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

---

## 📥 **Installation Guide**

### **Prerequisites**  
1. **.NET 8.0 SDK** ([Download](https://dotnet.microsoft.com/))  
2. **SQL Server** (Any edition)  
3. **Visual Studio 2022** or later  

### **Steps**  

1. **Clone the Repository**  
   ```bash  
   git clone https://github.com/mammadlihamid/restaurantappmanager.git  
   cd restaurantappmanager  
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
![Admin Dashboard Placeholder](/RestaurantProject/wwwroot/images/adminDashboard.jpg)  

### **Restaurant Showcase**  
![Restaurant Showcase Placeholder](/RestaurantProject/wwwroot/images/RestaurantShowcase.jpg)  

### **Team Management**  
![Team Management Placeholder](/RestaurantProject/wwwroot/images/Team.jpg)  

### **Menu Showcase**  
![Menu Showcase Placeholder](/RestaurantProject/wwwroot/images/menu.jpg)  

### **Testimonials**  
![Testimonials Placeholder](/RestaurantProject/wwwroot/images/testimonial.jpg)  

---

## 📜 **License**  
This project is licensed under the **MIT License**. Check the `LICENSE` file for more details.  

---

## ✉️ **Contact**  

👤 **Name**: Hamid Mammadli  

📧 **Email**: hemid359@gmail.com  

🔗 **GitHub**: [github.com/mammadlihamid](https://github.com/mammadlihamid)  
