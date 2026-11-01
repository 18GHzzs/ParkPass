<div align="center">

# ParkPass

**A campus parking automation system that replaces manual notebook logging with fast, reliable digital records.**

![Language](https://img.shields.io/badge/language-C%23-239120?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/status-in%20development-yellow)

Developed for **Mapúa Malayan Colleges Laguna (MMCL)**

</div>

---

## Table of Contents

- [Overview](#overview)
- [Problem Statement](#problem-statement)
- [Objectives](#objectives)
- [Features](#features)
- [Data Structures](#data-structures)
- [Algorithms](#algorithms)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Screenshots](#screenshots)
- [Team](#team)

---

## Overview

ParkPass is a campus parking automation system that replaces the paper notebooks used at parking entrances. It serves campus security guards, student and faculty drivers, and parking administrators.

Vehicles are checked in and out digitally by indexing plate numbers, student names, and academic programs. The system tracks available slot capacity in real time, manages entry waiting lines during peak arrival times, organizes campus parking zones hierarchically, and routes drivers to the nearest open parking area.

The project applies core data structures and algorithms (Lists, Stacks, Queues, Trees, and Graphs) in C#.

## Problem Statement

Manual notebook logging at campus parking entrances causes the following issues:

| Issue | Impact |
|---|---|
| Slow entry verification | Guards must search through handwritten pages |
| Long vehicle queues | Congestion builds up during peak campus hours |
| Lost records | Paper logs are easily misplaced, damaged, or illegible |

## Objectives

1. Replace manual notebook vehicle logging with a digital check-in system to eliminate entry bottlenecks and speed up vehicle flow.
2. Implement Lists, Stacks, Queues, Trees, and Graphs to store vehicle profiles, manage gate queues, and provide suggested vacant hours and peak parking hours.
3. Apply search, sort, and traversal algorithms to enable instant plate lookups, sort daily vehicle entries, and direct drivers to the nearest available parking space.

## Features

**Vehicle Check-In and Check-Out**
Registers incoming and outgoing vehicles by plate number, student name, and course, with real-time timestamps.

**Gate Entry Waiting Queue**
Queues incoming vehicles in order (FIFO) at entry checkpoints when parking bays reach temporary capacity.

**Peak Traffic and Hourly Analytics**
Evaluates hourly vehicle volume to identify rush hours, calculate hourly averages, and suggest the best arrival times. Generates separate traffic profiles for Thursday lab days and regular lecture days.

**Hierarchical Parking Zone Tracking**
Organizes campus parking as Parking Lot, Vehicle Section (Car or Motorcycle), and Individual Slot to monitor real-time availability.

**Nearest Parking Routing**
Models the campus road network to direct drivers from the gate to the nearest parking area with vacancies.

## Data Structures

| Data Structure | Application |
|---|---|
| List | Master registry of authorized student and faculty vehicles, plus active daily check-in records |
| Stack | Traffic stack (LIFO) that processes sequential hourly vehicle counts to track peak congestion windows and compute daily averages for schedule-based reports |
| Queue | Vehicle arrival line (FIFO) at the campus entrance gates during peak rush hours |
| Tree | Hierarchical layout of parking spaces (Left/Right Parking Lot, Vehicle Type, Slot Number) |
| Graph | Campus road layout: gate checkpoints, intersections, and parking lots are vertices; connecting driveways are weighted edges used to find the nearest lot with vacancies |

## Algorithms

| Algorithm | Purpose | Complexity |
|---|---|---|
| Quick Sort | Sorts daily log records by arrival time, student course, or plate number for end-of-day reporting | O(n log n) average |
| Binary Search | Searches sorted plate numbers or student IDs for instant gate entry verification | O(log n) |
| Breadth-First Search (BFS) | Traverses the driveway network to find the shortest path from the gate to an open parking section | O(V + E) |
| Depth-First Search (DFS) | Traverses the roads near campus to find a route to the nearest open parking area | O(V + E) |

## Tech Stack

- **Language:** C#
- **Framework:** .NET (specify version)
- **IDE:** Visual Studio / Visual Studio Code

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- Git

### Installation

```bash
# Clone the repository
git clone https://github.com/<your-username>/ParkPass.git

# Navigate to the project directory
cd ParkPass

# Build the project
dotnet build
```

### Running the Application

```bash
dotnet run
```

## Project Structure

```
ParkPass/
├── Models/            # Vehicle, User, and log classes
├── DataStructures/    # List, Stack, Queue, Tree, and Graph implementations
├── Algorithms/        # Quick Sort, Binary Search, BFS, DFS
├── Services/          # Check-in/out, analytics, and routing logic
├── Program.cs         # Application entry point
└── README.md
```

## Screenshots

Screenshots of the application will be added here.

```md
![ParkPass Demo](docs/demo.gif)
```

## Team

**Group 8**

| Name | Role |
|---|---|
| Aivin John Catangay | Project Leader / Developer |
| Ferdinand Mark Bartolome | Developer |
| Tristan Bien Canlas | Developer |
| Joshua Evan Delos Santos | Developer |
| Derek Dwyane Ibanga | Developer |

Mapúa Malayan Colleges Laguna
