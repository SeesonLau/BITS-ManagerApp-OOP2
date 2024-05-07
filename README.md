# Bus Integrated Ticketing System Manager App Code Documentation

CpE 262 OOP2 Project Documentation

To see the code. Go to CpE 262 Project IV


# Guide

Files are divided into 7 folders.

![Screenshot 2024-05-07 221652](https://github.com/SeesonLau/BITS-ManagerApp-OOP2/assets/145199305/10ced1af-3401-40ab-8138-8641df8df35b)

# Admin

This is where all of the admin functions are being held. 

1. Admin.cs
   
   * Form class.
   * Mother hub for the admin userControl class.

2. AdminManageAccount.cs
   
   * UserControl class.
   * Implements the Create, Read, Update, and Delete.
   * Exception Handling is implemented.
   * Manages the Passenger Accounts.
   
3. AdminManageTicketing.cs
   
   * UserControl class.
   * Implements the Create, Read, Update, and Delete.
   * Exception Handling is implemented.
   * Manages the Ticketing process.
     
4. AdminStatistics.cs

   * UserControl class.
   * Displays the necessary statistics from the ticketing.
   * Exception Handling is implemented.

   
# Desinger Class

This is where all the designs that were used in the program is compiled.

1. ColorPalette.cs
   
   * Form class.
   * Serves as the color palette used in the program.
   * Has no other purpose other than storing the hex codes.

2. RoundButton.cs
   
   * Makes the button round.
   
3. RoundPanel.cs
   
   * Makes the panel round.
     
4. RoundRadioButton.cs
   
   * Makes the radioButton round.
     
# Driver

This is where all of the driver functions are being held. 

1. Driver.cs
   
   * Form class.
   * Mother hub for the admin userControl class.
     
2. DriverHome.cs
   
   * UserControl class.
   * Displays the necessary info about the Driver Profile and other driver functions.
   * driver function code is held here.
   * Exception Handling is implemented.

# Login

This is where all of the login functions are being held. 

1. Login.cs
   
   * Form class.
   * Can create account.
   * Main login class for the program.
   * Only admin can access.

# Passenger

This is where all of the Passenger functions are being held. 

1. F3PassengerLogin.cs
   
   * Form class.
   * Can create account.
   * Login class used for both passenger and driver.
   * passenger and driver can access.

2. Passenger.cs

   * Form class.
   * Mother hub for the passenger userControl class.

3. PassengerHistory.cs

   * UserControl class.
   * Contains the history and statistics of the passenger bus trips.

4. PassengerHome.cs

   * UserControl class.
   * Cotains the code for home.
   * Displays the functions for home.
     
5. PassengerTicket.cs

   * UserControl class.
   * Cotains the code for ticket.
   * Displays the functions for ticket.

     
# Resources

This is where images and icons used in the program is held.

# Working Class

Contains the backbone code of the program. Is divided into several classes for easy navigation.

1. BusType.cs
   
   * Retrieves the busType from the database.
     
2. CallFile.cs
   
   * Retrieves the fileHandling for easy passing of data from userControl to another.

3. DatabaseAccess.cs
   
   * Contains the connectionString of the program.
     
4. DeclarationProperties.cs
   
   * Serve as backup data incase connection with the database is severed for Fare Rates.

5. Directory.cs
   
   * Retrieves the distance of the locations from the database.
     
6. DistanceProperties.cs
   
   * Serve as backup data incase connection with the database is severed for Distance.

7. FareCalculator.cs
   
   * Calculates the fare.
     
8. InitializePassDrive.cs

   * Appends the fileHandling for easy passing of data from userControl to another.
   * Implements the fileHandling for easy passing of data from userControl to another.

9. MethodPanel.cs
   
   * Makes dragging the panel possible.
     
10. MethodTextBox.cs
   
   * Makes placeholder in the textbox.

11. PassengerType.cs
   
   * Retrieves the passengerType from the database.
     
12. RandomID.cs
   
   * Generates different ID values for Admin, Driver, and Passenger.

13. TrueDistance.cs
   
   * Calculates the distance between two points.


