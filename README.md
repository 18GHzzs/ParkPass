<div align="center">

#  ParkPass

**A campus parking automation system that replaces manual notebook logging with fast, reliable digital records.**

![Language](https://img.shields.io/badge/language-C%23-239120?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/status-in%20development-yellow)

Built for **Mapúa Malayan Colleges Laguna (MMCL)**

</div>

---

##  Table of Contents

- [About](#-about)
- [The Problem](#-the-problem)
- [Features](#-features)
- [Data Structures & Algorithms](#-data-structures--algorithms)
- [Tech Stack](#-tech-stack)
- [Getting Started](#-getting-started)
- [Usage](#-usage)
- [Project Structure](#-project-structure)
- [Screenshots](#-screenshots)
- [Roadmap](#-roadmap)
- [Team](#-team)

---

##  About

**ParkPass** is a campus parking automation system designed for the **students and security guards of Mapúa Malayan Colleges Laguna**. It replaces the paper notebooks currently used at parking entrances with a fast digital workflow for vehicle entry, verification, and record keeping.

The project is also a practical application of core **data structures and algorithms** (lists, stacks, trees, and graphs) implemented from the ground up in **C#**.

##  The Problem

Manual notebook logging at campus parking entrances leads to:

| Issue | Impact |
|---|---|
| Slow entry verification | Guards must search through handwritten pages |
| Long vehicle queues | Congestion builds up during peak campus hours |
| Lost or damaged records | Paper logs are easily misplaced, damaged, or illegible |

ParkPass addresses each of these by digitizing the entire process.

##  Features

- **Fast vehicle check-in / check-out** to reduce queue times at entrances
- **Quick verification** of registered vehicles and users
- **Persistent digital records** that replace paper logs
- **Entry history tracking** for review and auditing
- **Designed for two user roles:** students and guards

>  *Edit this list to match what your system actually does.*

##  Data Structures & Algorithms

This project applies the following data structures to solve real parking-management problems:

| Data Structure | Application in ParkPass |
|---|---|
| **List** | Storing registered vehicles and entry/exit logs |
| **Stack** | Tracking recent entries and supporting undo of the latest action |
| **Tree** | Organizing and searching vehicle records efficiently |
| **Graph** | Modeling parking areas and the paths between them |

>  *Adjust the "Application" column to reflect exactly how you used each structure.*

##  Tech Stack

- **Language:** C#
- **Framework:** .NET *(specify version, e.g. .NET 8)*
- **IDE:** Visual Studio / VS Code

##  Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed
- Git

### Installation

```bash
# Clone the repository
git clone https://github.com/<your-username>/ParkPass.git

# Move into the project folder
cd ParkPass

# Build the project
dotnet build
```

### Running the Application

```bash
dotnet run
```

##  Usage

1. Launch the application.
2. Choose your role (**Guard** or **Student**).
3. Guards can log vehicle entry and exit and verify registered vehicles.
4. Students can view their parking information.

>  *Replace these steps with your actual menu flow or UI instructions.*

##  Project Structure

```
ParkPass/
├── Models/            # Vehicle, User, and log classes
├── DataStructures/    # Custom List, Stack, Tree, and Graph implementations
├── Services/          # Core parking logic
├── Program.cs         # Application entry point
└── README.md
```

>  *Update this to match your real folder layout.*


##  Roadmap

- [x] Core data structure implementations
- [x] Vehicle entry and exit logging
- [ ] Persistent file or database storage
- [ ] Graphical user interface
- [ ] Plate recognition or QR-based check-in
- [ ] Reports and analytics for peak hours

##  Team

| Name | Role |
|---|---|
| *Your Name* | *Role* |
| *Teammate* | *Role* |

Developed at **Mapúa Malayan Colleges Laguna**.

---

<div align="center">
Made with ☕ and C# at MMCL
</div>
