# Driver and Vehicle Licensing Department (DVLD)

A comprehensive desktop application for managing driver licenses and vehicle registrations. The system handles the complete lifecycle of license issuance, renewals, replacements, and administrative operations with a secure database infrastructure.

## 🎯 Overview

The DVLD Management System provides an end-to-end solution for driving license departments to manage license applications, conduct examinations, issue licenses across multiple classes, and maintain complete administrative control. Built with enterprise-level architecture, the system ensures data integrity, security, and scalability.

## ✨ Key Features

### License Services
- **New License Issuance**: Complete application process with vision, theory, and practical tests
- **License Renewal**: Streamlined renewal process with vision test requirement
- **Lost License Replacement**: Issue replacement for lost licenses with validation
- **Damaged License Replacement**: Replace damaged licenses with proper verification
- **License Detention Release**: Release detained licenses after fine payment
- **International License**: Issue international driving permits for eligible drivers
- **Test Retake**: Schedule and manage test retakes for failed examinations

### License Classes (7 Categories)
1. **Small Motorcycle** - Age 18+, $15 fee, 5 years validity
2. **Heavy Motorcycle** - Age 21+, $30 fee, 5 years validity
3. **Ordinary Driving License (Car)** - Age 18+, $20 fee, 10 years validity
4. **Commercial License (Taxi/Limo)** - Age 21+, $200 fee, 10 years validity
5. **Agricultural Vehicles** - Age 21+, $50 fee, 10 years validity
6. **Small/Medium Buses** - Age 21+, $250 fee, 10 years validity
7. **Trucks & Heavy Vehicles** - Age 21+, $300 fee, 10 years validity

### Testing System
- **Vision Test** - $10 fee, mandatory for new licenses and renewals
- **Written Theory Test** - $20 fee, traffic laws and safety knowledge
- **Practical Driving Test** - Variable fee by license class, hands-on driving assessment
- Automated scheduling and result tracking
- Retake management with separate applications

### Administrative Features
- **User Management**: Add, edit, delete, activate/deactivate system users with role-based permissions
- **Person Management**: Centralized database of all individuals with unique national ID validation
- **Application Management**: Track all applications by status, type, and applicant
- **License Detention**: Record and manage detained licenses with fines and reasons
- **Test Type Management**: Configure test fees and parameters
- **License Class Configuration**: Adjust age requirements, validity periods, and fees
- **Audit Trail**: Complete logging of all system operations with user and timestamp

## 🏗️ Technology Stack

- **Framework**: .NET Framework 4.7.2+
- **Language**: C# 
- **UI**: Windows Forms
- **Database**: SQL Server 2016+
- **Data Access**: ADO.NET
- **Architecture**: 3-Tier Architecture

## 📐 System Architecture

The application implements a robust 3-tier architecture:

### 1. Presentation Layer (UI)
- Windows Forms interface for user interactions
- Form validation and user-friendly error handling
- Responsive design for various screen resolutions

### 2. Business Logic Layer
- Application business rules and validation
- Age verification for license classes
- Duplicate license prevention
- Test sequencing logic (Vision → Theory → Practical)
- License status management (Active, Detained, Expired)

### 3. Data Access Layer
- SQL Server database operations
- Stored procedures for complex transactions
- Connection pooling and optimization
- Data integrity constraints

This separation ensures:
- Maintainable and testable code
- Clear separation of concerns
- Easy future migration to web/mobile platforms
- Scalable architecture for growing user base

## 📋 Prerequisites

- Windows 10 or later
- .NET Framework 4.7.2 or higher
- SQL Server 2016 or higher
- 4GB RAM minimum (8GB recommended)
- 500MB free disk space
- Visual Studio 2019+ (for development)

## 🚀 Installation

### 1. Clone the Repository
```bash
git clone https://github.com/RashedKlo/driver-vehicle-licensing-system.git
cd driver-vehicle-licensing-system
```

### 2. Database Setup
1. Back up DVLD in SQL Server Management Studio


### 3. Configure Connection String
Update the connection string in `App.config`:
```xml
<connectionStrings>
    <add name="DVLD_DB" 
         connectionString="Server=YOUR_SERVER;Database=DVLD_DB;Integrated Security=true;" 
         providerName="System.Data.SqlClient"/>
</connectionStrings>
```

### 4. Build and Run
1. Open `DVLD.sln` in Visual Studio
2. Restore NuGet packages
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

### Application Rules
- Each person can have multiple applications for different services
- No duplicate pending applications of the same type
- Application fees must be paid before processing
- National ID uniqueness enforced across the system

### Test Rules
- Failed tests can be retaken with new appointments and fees
- Each test type has configurable fees
- Test results and dates are permanently recorded
- Vision test required for both new licenses and renewals

### License Status Management
- Active licenses can be detained with fine and reason
- Detained licenses cannot be renewed or replaced until released
- International licenses only for Class 3 (Ordinary Car) holders
- License expiration dates calculated from issuance based on class validity

## 📊 Database Schema Highlights

### Core Tables
- **People**: Central repository of all individuals (applicants, users)
- **Applications**: All service requests with status tracking
- **Tests**: Vision, theory, and practical test records
- **Licenses**: Issued licenses with full history
- **Users**: System users with authentication credentials
- **LicenseClasses**: Master data for 7 license categories
- **TestTypes**: Configurable test types and fees
- **DetainedLicenses**: Records of detained licenses and releases
- **InternationalLicenses**: International permit issuance tracking


## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the issues page and submit pull requests.


**Built with .NET Framework, C#, and SQL Server** | **Part of Professional Full-Stack Development Portfolio**

*This system demonstrates enterprise-level application development with proper architecture, security, and scalability considerations.*
