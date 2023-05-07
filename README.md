[![GitHub release](https://img.shields.io/github/release/SamuelSVD/QuickDBAccess.svg)](../../releases/latest)
[![GitHub release](https://img.shields.io/github/downloads/SamuelSVD/QuickDBAccess/total)](../../releases/latest)

# QuickDBAccess
QuickDBAccess is a configurable program that works as a quick front end for a database.

## Download Quick DB Access

Download directly from GitHub in the latest release folder:

[http://github.com/samuelSVD/QuickDBAccess/releases/latest](http://github.com/SamuelSVD/QuickDBAccess/releases/latest)

# Usage

This program works as an easily editable front-end application for your database. To start, open the application then press the edit button on the menu bar. This will open up the program editor.

The program editor is made up of three main components: Connections, Data Sources, and Table Views

## Connections

The Connections tab is used to configure a database connection. Here is where you would configure the connection settings and authentication for connecting to the database. Verify your database is set up for mixed authentication prior to working with this application.

![image](https://user-images.githubusercontent.com/36249705/236113646-c1120142-9166-41e4-9bcb-bff7571346bd.png)

## Data Sources

The Data Sources tab contains any queries that are used to get data from the database.

![image](https://user-images.githubusercontent.com/36249705/236113892-9a3d0231-9052-48fe-875a-9514748960ad.png)

Data sources can be configured as depending on data from one another. A data source configured with parameters will get its data from the input. Parent parameters will grab data from the "parent of the table view". This will be relevant later. This would be configured as follows:

![image](https://user-images.githubusercontent.com/36249705/236113857-6c7baf26-bc3b-4995-867b-80dc7e7f5416.png)

## Table Views

Table views are configured to be a grid view of a data source. Table views can also be configured to have "sub-table views". This means that when a record in the table view is selected, the data for the sub-table views will be refreshed according to the row selected in the parent table.

![image](https://user-images.githubusercontent.com/36249705/236114473-d538f8d4-758d-483b-8211-8d30b24271a5.png)

![image](https://user-images.githubusercontent.com/36249705/236114498-7bf8dd73-fc4f-42df-bb3e-7d6e866a11d1.png)

### Buttons

Table views can also be assigned button actions. These are data sources that will execute when a button action is pressed. In this example, we have assigned the button action for the Employees table view to edit some data. The data source for that button would look as follows:

![image](https://user-images.githubusercontent.com/36249705/236114723-52771a1f-42f6-424e-b349-03f8fba31e1e.png)


# All Together Now

Once it is all configured and the changes applied, the application will refresh the main screen and show different tabs for all the different table views.

![image](https://user-images.githubusercontent.com/36249705/236114838-bc34242d-d805-4237-98dd-754278623772.png)

# Contributions

I am open to receiving suggestions for improving Quick DB Access! Have an idea that you think would make this app even more useful for you, let me know by creating an issue!

[Create New Issue](https://github.com/SamuelSVD/QuickDBAccess/issues/new)
