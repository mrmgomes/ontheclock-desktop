# OTC - Desktop (for Windows)

OTC (On The Clock) is an open source application made by [mrmgomes](https://github.com/mrmgomes) which purpose is to manage punch in/punch out fingerprint operations and it is __currently under development__ so there are a few things missing and they WILL BE FIXED. But feel free to contribute if you feel like! :-)
 
__THIS IS NOT BEING DEVELOPED FOR COMMERCIAL PURPOSES BY ANY MEANS.__

It is composed of two modules:
* __OTC Desktop__ (this repository): A C# Desktop application for Windows which purpose is to manage staff members fingerprints and punching in/out through fingerprint reading. This module has been tested with fingerprint reader __Digital Persona© U.are.U© 4500__ 
* __[OTC Admin](https://github.com/mrmgomes/ontheclock-admin)__ : An Angular 9 Web app + a sample NodeJS API inside the `/api` folder

## Prerequisites for building and running this module
1. Visual Studio with .NET 4.5
2. Own a Digital Persona© U.are.U© 4500 fingerprint reader and install its drivers on your computer
3. Own Digital Persona SDK (put the DLL files in your project folder)
4. A Database to store staff/punch data

## Things you need to know (please read)
* This guide will walk you through the default steps to get the solution up and running AS IS. Any modifications (i.e. different fingerprint readers, different databases systems and so on) are up to you. I've put some effort on trying to leave comments codewide to make eventual adaptations easy.
* If you want to get things running quickly I suggest you use MongoDB as this desktop app was built on this.

## Getting started

### 1. Clone this project
Assuming you have all the prerequites fulfilled, you can clone this repo by either running

```bash
git clone https://github.com/mrmgomes/ontheclock-desktop.git
```
or opening __Visual Studio__ and selecting the option __Clone a repository__ shown in the splash screen.
### 2. Open the project (skip this if you cloned this repo directly from VS)
You can open __Visual Studio__ and browse for the project __Solution File__ or by double-clicking it directly from your File System.
### 3. Install packages
Project packages are usually installed by NuGet Package Manager. This feature is enabled by default on Visual Studio. If it's not (you will get some errors on VS if packages aren't found), open __Tools__ > __NuGet Package Manager__ > __Package Manager Settings__. Then under __NuGet Package Manager__ > __General__ check both:
* Manage NuGet Packages for Solution
* Restore NuGet Packages

Missing packages should start downloading.

### 4. Copy Digital Persona DLL files
Copy
* `DPFPDevNET.dll`
* `DPFPEngNET.dll`
* `DPFPGuiNET.dll`
* `DPFPShrNET.dll`
* `DPFPVerNET.dll`

to the `bin/Debug` folder

### 5. Configuration
Locate the `Config/EnvironmentSettings.xml` file and change the following values according to your database:
```xml
<database>
  <url>YOUR_DATABASE_CONNECTION_STRING</url>
  <name>YOUR_DATABASE_NAME</name>
  <punches_table_name>YOUR_PUNCHES_TABLE_NAME</punches_table_name>
  <staff_table_name>YOUR_STAFF_TABLE_NAME</staff_table_name>
  <users_table_name>YOUR_USERS_TABLE_NAME</users_table_name>
</database>
```

### 6. Start the software
Once you run the software you have two options:
* Update a staff member fingerprint (__File__ > __Staff Member__ > __Update Fingerprint__)
* Open the "clock" for staff members to punch in/out (__Punching__ > __Open__)

## Instructions
### Fingerprint update
__File__ > __Staff Member__ > __Update Fingerprint__
- Staff members must be created previously on the OTC - Admin web app;
- Staff member's document number must be provided in order to proceed with the fingerprint update process;
- If a match is found, the staff member's info is retrieved from the database and show in the app's interface;
- To start the capture process the __Fingerprint Scanning button__ must be pressed;
- Four samples of the same fingerprint will be requested before updating staff member's fingerprint;

### Punching in/out
__Punching__ > __Open__
- This form listens to the fingerprint reader events as it loads. So no further action is required to start capturing;
- Finger must be kept on the reader until staff/punch info shows on screen;

## Useful information
- Staff data is retrieved from the database and saved into the `DB/StaffRepository.xml` file once the Fingerprint update process is done;
- Fingerprint data (i.e. byte array, base64 string, images) are only saved into the `DB/StaffRepository.xml` and __IS NOT__ saved in the database as this information is only relevant locally and would impact on the app performance due to its size. The `fingerprint` flag is set to `true` on each updated record. So if you use this app on several machines I advise you to copy the `DB/StaffRepository.xml` file manually to each of them;
- Punch data is saved both locally to `DB/PunchRepository.xml` and to the database as its payload is useful for reporting (OTC - Admin Web App);

## Known issues
- After updating a member's fingerprint, opening the punching form throws an error. So the app is opened and the first form opened is the Punching one it works correctly;

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
