# Premier League Ticket System

## Overview
This application is a comprehensive ticket booking system for Premier League football matches, allowing fans to purchase tickets to their favorite teams' games. Built using C# and Jupyter Notebook, the system provides an intuitive interface for match selection, seat category choices, and ticket management.

## Features

### User Authentication
- Secure login system for fans
- User account management

### Match Selection
- Browse available Premier League matches
- Filter matches by team (Manchester United, Everton, Brighton, Burnley, Westham, Brentford, etc.)
- View match details including:
  - Venue/Stadium
  - Match date
  - Competing teams

### Ticket Booking
- Book tickets for specific matches
- Select from different seating categories (CAT 1, CAT 2, CAT 3)
- Confirm booking details before purchase
- Receive electronic tickets

### Ticket Management
- View all your booked tickets
- Access ticket details including:
  - Match information (teams, venue, date)
  - Ticket category
  - Unique ticket identifier

## Technical Implementation
- **Frontend**: Windows Forms application built with C#
- **Backend**: Data Access Layer (DAL) for database operations
- **Database**: SQL-based storage for match, team, and ticket information

## Project Structure
- **User Interface**: Multiple forms for navigation and interaction
- **Data Access**: Specialized DAL classes for tickets, teams, rounds, and user authentication
- **Business Logic**: Processing match selection and ticket booking workflow

## Future Enhancements
- Mobile application support
- Online payment integration
- Ticket cancellation and transfer capabilities
- Season ticket packages

## Getting Started
1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run the application
4. Create a user account or log in with existing credentials
5. Start browsing available matches and book tickets

## Technologies Used
- C# (.NET Framework)
- Windows Forms
- SQL Database
- Jupyter Notebook (for data analysis and management)
