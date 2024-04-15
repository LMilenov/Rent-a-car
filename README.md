# Rent-a-car
How to use the app:
1. Download the zip
2. Open the solution
3. Delete the migrations folder
4. Open the package manager console and run
- Add-Migration InitialMigration -OutputDir Migrations  -Project RentACar.Data -StartupProject RentACar.Web
- Update-Database -Project RentACar.Data -StartupProject RentACar.Web
5. Enjoy the app!
