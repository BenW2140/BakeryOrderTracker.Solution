# _Order Tracking_

#### _Tracks orders made with a vendor, July 24, 2020_

#### By _**Ben White**_

## Description

_This website allows a user to track orders made with a vendor by letting them enter information about the order_

## Setup/Installation Requirements

Software Requirements:

1. This program utilizes .NET version 2.2, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK version 2.2 or
      greater patch version, but do not upgrade to a higher minor version number.

2. Clone this repository onto your computer: https://github.com/...

3. In your preferred terminal window, navigate into BakeryOrderTracker.Solution/BakeryOrderTracker using cd (i.e. cd
   desktop/BakeryOrderTracker.Solution/BakeryOrderTracker) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore

5. To initiate this terminal program, run the command: $ dotnet run

6. To run the test suite included with this project, within the terminal navigate into BakeryOrderTracker.Tests and run the following commands:
  * $ dotnet restore
  * $ dotnet test

## Specs

Behavior|Input|Output
------|------|------
This program will allow the user to view all vendors|View Vendors|List of current Vendors: ...
This program will allow the user to add a vendor|Suzie's Cafe|List of current Vendors: Suzie's Cafe
This program will allow the user to view all orders from a vendor|Suzie's Cafe|Orders from Suzie's Cafe: ...
This program will allow the user to add an order from a vendor|Order1|Orders from Suzie's Cafe: Order1
This program will allow the user to remove all ~~orders~~ vendors ~~from a vendor~~|Remove orders from Suzie's Cafe| Orders from Suzie's Cafe: No orders


## Known Bugs

_No known bugs at this time_

## Support and contact details

_Ben White: bwhite2140@outlook.com_

## Technologies Used

_C#, .Net, MVC, ASP.NET_

### License

*MIT License*

Copyright (c) 2020 **_Ben White_**