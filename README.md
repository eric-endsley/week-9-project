# Pierre's Bakery Order Database

#### A website for Pierre's Bakery to store information about Vendors and their Orders

#### By Eric Endsley

## Description

This is a simple MVC website meant for a bakery or similar company to enter and store information regarding vendors and their orders. The website features a simple splash page with the title and a link to a view the list of vendors stored on the site. All pages on this website include two small links at the top to return to the homepage, or to the vendor directory. If there are no vendors listed the page will display a messages saying so, otherwise the page will provide a list of vendors whose names are hyperlinks to detail pages about those vendors. The vendor page also contains a link to add a new vendor, which displays a form where the user may enter the vendors name and description. This vendors name will then be displayed in the vendor list.

Within the details page is a similar list of orders for the vendor. Once again, if there are no orders the page will state so, otherwise there will be a list of order titles. These titles themselves are hyperlinks to order detail pages which include the date, price and description for each order, as well as a link back to the vendors detail page. The vendor detail page also contains a link to add new orders. This form contains 4 input fields corresponding to the information displayed on the order's detail pages.

## Setup

#### Install .NET Core

1. This program is written in C# and requires the .NET Core to run. For PC users click [this link](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) and follow the installation instructions. For Mac users click [this link](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) and follow the installation instructions.

2. Install dotnet script by entering the following command in your terminal: "dotnet tool install -g dotnet-script"

#### Clone and Open Locally

1.  Open the [Pierre's Bakery Order Database website](https://github.com/eric-endsley/week-9-project.git) by clicking the link or copy/pasting "https://github.com/eric-endsley/week-9-project.git" in the navigator bar of a web browser application.

2.  Click the green Code button in the upper-right part of the window and then EITHER:

3.  a. Copy the HTTPS URL for the repo and use it in the git clone command in git-bash or another git terminal by inputting: "git clone https://github.com/eric-endsley/week-9-project.git"<br>
    OR b. Click "Download Zip" and unzip the file to an accessible location on your machine.

4.  Right click on the project directory and open it with VS Code or another code editor.

5.  In your terminal, navigate to the subdirectory /VendorOrders within VendorOrders.Solution and run the commands "dotnet restore" and then "dotnet run" in order to begin locally hosting the webpage.

6.  If your browser does not automatically open the page, open your preferred browser and enter "http://localhost:5000" in the navigation bar. If this does not work, look for the phrase "Now listening on:" written in your terminal a few lines after your "dotnet run" command. Navigate to the url written there.

## Technologies Used

C#, .NET Core 2.2, ASP.NET Core MVC, Bootstrap, Razor, VS Code

## Known Bugs

None

## Contact Information

To ask questions or report a bug, contact [Eric Endsley](mailto:eric.endsley4@gmail.com)

## Legal

This software is licensed under the MIT license.
