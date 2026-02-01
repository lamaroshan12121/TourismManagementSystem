# Tourism Management System

A comprehensive ASP.NET MVC web application for managing tourism activities, travel packages, bookings, and feedback. This platform serves travel agencies, tour guides, and tourists.

## Features

### For Travel Agencies & Tour Guides
- Create and manage profiles with agency details and licenses
- Create and manage travel packages with descriptions, prices, and durations
- Set tour dates and available seats
- Track bookings and participant numbers
- Manage payment statuses
- View and respond to tourist feedback and ratings
- Generate reports on booking activity and revenue

### For Tourists
- Browse available travel packages and tours
- View detailed descriptions, prices, and available dates
- Book tours with selected packages
- Track booking status (Pending, Confirmed, Completed)
- View booking history and past tours
- Leave feedback and rate experiences
- Manage payment information

### System Features
- Secure authentication and registration
- Role-based access control (Agency/Tourist)
- Responsive user-friendly interface
- Entity Framework Code-First database design
- Input validation and error handling
- Custom CSS styling
- Comprehensive reporting dashboard

## Technology Stack

- **Framework**: ASP.NET MVC 5
- **Language**: C#
- **Database**: SQL Server Express / LocalDB
- **ORM**: Entity Framework 6
- **Frontend**: HTML5, CSS3, Razor Views
- **Authentication**: Forms Authentication with BCrypt password hashing

## Database Design

### Entity Relationships
- **One-to-One**: User ↔ Profile
- **One-to-Many**: Agency → TourPackage → TourDate
- **One-to-Many**: Tourist → Booking
- **Many-to-Many**: Booking ↔ TourPackage (via BookingPackages)
- **One-to-One**: Booking ↔ Feedback, Booking ↔ Payment

## Installation & Setup

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2
- SQL Server Express or LocalDB

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/lamaroshan12121/TourismManagementSystem.git
   cd TourismManagementSystem
   ```

2. **Open in Visual Studio**
   - Open `TourismManagementSystem.sln`
   - Build the solution

3. **Update Database Connection**
   - Edit `Web.config` connection string:
   ```xml
   <connectionStrings>
     <add name="TourismContext" connectionString="Server=(localdb)\mssqllocaldb;Database=TourismDB;Integrated Security=true;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Enable Migrations**
   - Open Package Manager Console
   - Run: `Enable-Migrations`
   - Run: `Add-Migration Initial`
   - Run: `Update-Database`

5. **Run the Application**
   - Press F5 or click Run
   - Navigate to `https://localhost:44XXX`

## Project Structure

```
TourismManagementSystem/
├── Models/
│   ├── User.cs
│   ├── Profile.cs
│   ├── Agency.cs
│   ├── Tourist.cs
│   ├── TourPackage.cs
│   ├── TourDate.cs
│   ├── Booking.cs
│   ├── Feedback.cs
│   ├── Payment.cs
│   └── ApplicationDbContext.cs
├── Controllers/
│   ├── HomeController.cs
│   ├── AccountController.cs
│   ├── AgencyController.cs
│   └── TouristController.cs
├── Views/
│   ├── Home/
│   ├── Account/
│   ├── Agency/
│   ├── Tourist/
│   └── Shared/
├── Content/
│   └── Site.css
└── Web.config
```

## Usage

### Agency Workflow
1. Register as Agency
2. Create and manage travel packages
3. Set tour dates and availability
4. Monitor bookings
5. Review tourist feedback
6. Generate revenue reports

### Tourist Workflow
1. Register as Tourist
2. Browse available packages
3. Book desired tours
4. Make payment
5. Track booking status
6. Leave feedback after tour

## Default Test Accounts

After database initialization, test accounts are available:
- **Agency Account**: agency@test.com / password123
- **Tourist Account**: tourist@test.com / password123

## Features in Detail

### Dashboard
- Real-time booking statistics
- Revenue tracking
- Upcoming tours
- Recent bookings

### Reporting
- Booking activity reports
- Revenue analysis
- Tourist feedback summary
- Occupancy rates

## Security
- Password hashing using BCrypt
- SQL injection prevention via Entity Framework
- XSS protection in Razor views
- CSRF tokens on forms
- Role-based authorization

## Team Members
- Student ID: 12300492 - Roshan Lama
## License

This project is licensed under the MIT License - see LICENSE file for details.

## Support

For issues and questions, please create an issue in the GitHub repository.

## Future Enhancements

- Email notifications for bookings
- Payment gateway integration (Stripe/PayPal)
- Advanced search and filtering
- Rating system with average scores
- Image upload functionality
- Multi-language support
- Mobile app version
- Real-time chat support
