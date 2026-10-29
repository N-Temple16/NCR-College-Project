# NCR Creation/Modification Application Overview
This MVC application was developed as a team project during my Computer Programming studies at Niagara College, specifically for the [Community Sponsored Project](https://www.niagaracollege.ca/courses/PROG/1440/term/1281/plan/P0411/). We worked with Haver and Boecker Niagara to create a mock application for their NCR (Non-Conformance Report) creation process. The project was created to speed up their, at the time, current slow manual process to a streamlined digital version. In the end, our application was chosen #1 out of all the groups competing and would go on to be implemented into the business.

## Features
As mentioned, this application's main purpose is to assist in the NCR creation and tracking process. This process involves 5 major roles with those being Quality, Engineer, Operations, Procurement and Admin each with unique accessibility specific to their job in the workflow. Other features include the ability to upload, create, view and edit supplier and item records whenever needed, user account management, functionality that allows for an NCR to become archived or voided, downloadable PDF files of NCRs and supplier reports, and finally a KPI dashboard that details a large majority of sections for an Admin role to view. An email feature was implemented as well in order to notify the next role in the process that an NCR needed their attention, but I have removed that feature to protect sensitive information.

## Technologies
- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- ASP.NET Core Identity
- Razor Views
- HTML, CSS, Javascript

## My Contribution
The primary areas of the application I contributed to were the reinspection functionality as well as the ability to upload an inspect uploaded images during the NCR process. Within the system, the reinspection process takes place at the end of the NCR creation period and allows a user with the quality role to review the entirety of the NCR process and either deem it acceptable or not. If the report is not acceptable, a notes section appears so the reasoning can be explained and then the NCR is closed with a new one being created right after to remake that specific report from the start. I added the functionality for uploading and viewing images so a user of any role could include additional information in terms of specific defects or measurements to the report for the next user or management to see. 

I also contributed to other areas of the application as needed, including assisting with additional sections as the team progressed. As this project was complete some time ago, I cannot reliably attribute every individual feature to myself. This repository represents the broader team's work rather than a project developed independently.

## Screenshots
Most Screenshots used in this section were taken from the perspective of the Admin role as they are able to see all sections and features of the application unless otherwise specified.
Once logged in, the home screen of the application is displayed
![]()


This is an example of the Quality role home screen just to show the variations of interfaces depending on the users given role.
![]()

screenshots should most likely come from the admin perspective so all the features can be shown
![]()

screenshots should most likely come from the admin perspective so all the features can be shown
![]()

### Prerequisites
- Visual Studio with the ASP.NET and web development workload.
- The .NET SDK version required by the project

## Setup Instructions
- Clone this repository.
- open application
- allow NuGet to restore dependencies
- build solution and run the application
- Log in using the provided roles to see how each view changes.


Password is the same for each account: ```Pa55w@rd```
- ```Admin```: admin@example.com
- ```Quality```: quality@example.com
- ```Engineer```: engineer@example.com
- ```Operations```: operations@example.com
- ```Procurement```: procurement@example.com
