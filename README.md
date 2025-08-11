# SpendSmart - Personal Expense Tracker

A simple and intuitive web application built with ASP.NET Core MVC for tracking personal expenses. Manage your daily expenses with easy-to-use CRUD operations.

## 🚀 Features

- ✅ **Add New Expenses** - Create expense records with amount and description
- ✅ **View All Expenses** - Display expenses in a clean table format
- ✅ **Edit Expenses** - Modify existing expense records
- ✅ **Delete Expenses** - Remove unwanted expense entries
- ✅ **Total Calculation** - Automatic sum of all expenses
- ✅ **Responsive Design** - Bootstrap-powered UI for all devices

## 🛠 Technology Stack

- **Framework**: ASP.NET Core 8.0 MVC
- **Database**: Entity Framework Core with In-Memory Database
- **Frontend**: Razor Views with Bootstrap CSS
- **Language**: C# with .NET 8.0
- **ORM**: Entity Framework Core 9.0.8

## 📁 Project Structure

```
SpendSmart/
├── Controllers/
│   └── HomeController.cs           # Main application logic & CRUD operations
├── Models/
│   ├── Expense.cs                  # Expense entity model
│   ├── SpendSmartDbContent.cs      # Entity Framework DbContext
│   └── ErrorViewModel.cs           # Error handling model
├── Views/
│   └── Home/
│       ├── Index.cshtml            # Landing page
│       ├── Expenses.cshtml         # Expense list view
│       ├── CreateEditExpense.cshtml # Add/Edit expense form
│       └── Privacy.cshtml          # Privacy page
├── Program.cs                      # Application configuration & DI setup
├── SpendSmart.csproj              # Project dependencies
└── README.md                      # Project documentation
```

## 💾 Database Schema

### Expense Entity
| Field       | Type     | Constraints           | Description                    |
|-------------|----------|-----------------------|--------------------------------|
| Id          | int      | Primary Key, Identity | Auto-incrementing unique ID    |
| Value       | decimal  | Required              | Expense amount                 |
| Description | string   | Required              | Expense description            |

## 🔧 Installation & Setup

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio Code (recommended) or Visual Studio

### Quick Start
1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd SpendSmart
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Build the application**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access the application**
   - HTTPS: `https://localhost:5001`
   - HTTP: `http://localhost:5000`

## 📖 Usage Guide

### Adding a New Expense
1. Navigate to the home page
2. Click "Create New Expense" or go to `/Home/CreateEditExpense`
3. Enter the expense amount and description
4. Click "Ok" to save

### Viewing All Expenses
1. Click "Expenses" in the navigation menu
2. View all expenses in a table format
3. See the total amount calculated automatically

### Editing an Expense
1. Go to the Expenses page (`/Home/Expenses`)
2. Click "Edit" next to the expense you want to modify
3. Update the values in the form
4. Click "Ok" to save changes

### Deleting an Expense
1. Go to the Expenses page
2. Click "Delete" next to the expense you want to remove
3. The expense will be permanently deleted (no confirmation prompt)

## 🔀 API Endpoints

| Method | Endpoint                          | Description                    |
|--------|-----------------------------------|--------------------------------|
| GET    | `/`                              | Home/Landing page              |
| GET    | `/Home/Expenses`                 | View all expenses with total   |
| GET    | `/Home/CreateEditExpense`        | New expense form (Create mode) |
| GET    | `/Home/CreateEditExpense/{id}`   | Edit expense form (Edit mode)  |
| POST   | `/Home/CreateEditExpenseForm`    | Save/Update expense            |
| GET    | `/Home/DeleteExpense/{id}`       | Delete expense by ID           |
| GET    | `/Home/Privacy`                  | Privacy policy page            |

## 🏗 Architecture Overview

### MVC Pattern
- **Models**: `Expense` entity and `SpendSmartDbContent` context
- **Views**: Razor pages for user interface rendering
- **Controllers**: `HomeController` handles all CRUD operations

### Key Components

#### HomeController Methods
- `Index()` - Landing page
- `Expenses()` - Display all expenses with total
- `CreateEditExpense(int? id)` - Form display (Create/Edit mode)
- `CreateEditExpenseForm(Expense model)` - Form submission handler
- `DeleteExpense(int id)` - Delete expense by ID

#### Database Context
- `SpendSmartDbContent` - Entity Framework DbContext
- In-Memory database for development/testing
- Auto-migration and seed data support

#### Data Flow
```
User Input → Controller → Model → Database → Controller → View → User
```

## 🔍 Development Notes

### Entity Framework Features
- **Convention-based mapping**: `Id` property automatically becomes Primary Key
- **Auto-increment**: Database generates unique IDs automatically
- **Change tracking**: EF Core tracks entity modifications
- **LINQ support**: Fluent query syntax for data operations

### Form Handling
- **Model binding**: Automatic mapping between form data and C# objects
- **Tag helpers**: `asp-for`, `asp-action`, `asp-controller` for clean HTML
- **Validation**: Data annotations for client and server-side validation

### In-Memory Database
- Data persists only during application runtime
- Perfect for development and testing
- No external database dependencies required

## 🚨 Troubleshooting

### Common Issues

1. **Application won't start**
   ```bash
   dotnet clean
   dotnet restore
   dotnet build
   dotnet run
   ```

2. **Null reference warnings**
   - The application handles potential null values safely
   - Delete operations check for existence before removal

3. **Port conflicts**
   ```bash
   dotnet run --urls "https://localhost:5002;http://localhost:5003"
   ```

### Development Commands

```bash
# Clean and rebuild
dotnet clean && dotnet build

# Run with detailed logging
dotnet run --verbosity detailed

# Run in development mode
dotnet run --environment Development

# Watch for file changes (hot reload)
dotnet watch run
```

## 🔮 Future Enhancements

- [ ] Add expense categories and tags
- [ ] Implement date filtering and search
- [ ] Add expense charts and analytics
- [ ] Export functionality (CSV, PDF)
- [ ] User authentication and authorization
- [ ] Persistent database (SQL Server, PostgreSQL)
- [ ] REST API for mobile app support
- [ ] Expense budget tracking
- [ ] Multi-currency support

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

---

**Note**: This application uses an in-memory database. All data will be lost when the application stops. For production use, configure a persistent database provider.
