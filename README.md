Hospital Management System
A modern, user-friendly web application for managing hospital patient records, built with ASP.NET Core MVC.

Overview
The Hospital Management System is a comprehensive solution designed to streamline patient record management in healthcare facilities. It provides an intuitive interface for registering new patients, viewing patient lists, and managing medical information efficiently.

Features
1. Patient Registration - Easy-to-use form for registering new patients with complete information
2. Patient Records Management - View and manage all patient records in a centralized system
3. Modern UI Design - Clean, professional interface with green medical theme
4. Responsive Layout - Works seamlessly on desktop, tablet, and mobile devices
5. Real-time Validation - Form validation with visual feedback for better user experience
6. Secure Data Storage - Patient information stored securely with proper validation

Prerequisites
- Visual Studio 2019 or later
- .NET Core SDK 6.0 or later
- ASP.NET Core Runtime

Hospital_Management_System/
├── Controllers/
│   ├── HomeController.cs
│   └── PatientController.cs
├── Models/
│   └── ErrorViewModel.cs
│   └── Patient.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Patient/
│   │   ├── PatientRegister.cshtml
│   │   ├── PatientList.cshtml
│   │   └── PatientDetails.cshtml
│   └── Shared/
│       └── _Layout.cshtml
│       └── _Validation.cshtml
├── wwwroot/
│   └── css/
│       └── site.css
└── Program.cs
