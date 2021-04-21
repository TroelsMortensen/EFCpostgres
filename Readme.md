LocalDB:

I had to manually create a database in my postgres installation, outside of EFC. I called it "LocalAuthor". I used datagrip to create it. Once that was created, I could create migration and update the database, which would then create the two tables for Author and Book.


Cloud DB:

It's hosted on www.elephantsql.com.
Under the details view, you can see info about your database:

![alt text](https://github.com/TroelsMortensen/EFCpostgres/blob/master/Img/ElephantSQLDbInfo.png?raw=true "Logo Title Text 1")

 This must be used in the DbContext class.
