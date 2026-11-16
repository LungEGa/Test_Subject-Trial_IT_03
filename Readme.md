# &lt;&lt;&lt; README for Trail Test IT-03 &gt;&gt;&gt;

This code is not finished due to time-constraint in 16 hours, so I did what I could in this timeframe. \
Furthermore, this code solely purpose to share for reviewing as a part of Job Application, simplified for testing question. \
❌❌❌ <span style="font-weight: bold; color: red;">DO NOT ATTEMPT TO COPY OR EDIT FOR YOUR OWN WITHOUT PERMISSION!!!</span> ❌❌❌

Signed ©️ : LungEGa 🐺 (Supanat Semachai)   2026-11-16T18:18:32+07:00


### 🔧 Pre-requisite and Configuration ...

In this program, I used Visual Studio project with Windows Application in C#.Net (Framework version 4.7.2) along with MSSQL Server version 17.0.1000.7, Standard Developer Edition (64-bit).

As for the application configuration, please see in the "App.config" file. Under "appSettings" component tag, please feel free to edit "access_name", "access_credentials", "server_name" and "database_name", which involved in database connection, to your own database access.

As for the database part, please take a look and carefully execute "sql_db_env_test.sql" file, since this one contain database and table scripts needed for this program along with some scripts on pending progress, which is not need to be executed. \
⚠️ For distinquision, I put tag [Required] upon needed scripts.

### ✅ What I have already done ...

- Main form with Data Grid View and Approval buttons, all Button events for new pop-up form is ready.
- Preliminary established configurations.
- Testing data table along with the sample data.

### ‼️ What I have staggered ...

Due to I failed to create a database credential for testing properly, most features for this application is not implemented.

- "DBConn" module for database connection, and query retrival is not finished yet.
- DataGridView in Main form could not finished, due to lack on scripting towards database connection.
- Checkbox for each record inside DataGridView.
- Submit button to interact as updating data to the database.

### 🚏 What I plan on TO-DO list (if continue) ...

- Prepare and "DBConn" module for database connection, and query retrival.
- Initiate dataset to DataGridView for presentation.
- Checkbox integrated for each record, along with handling script depening on request status.
- Replace Request's ID with UUID-7 instead of usual Integer, unique value with timestamp. Also, replacing field to handle UUID-7 value, and UUID-7 generating function within the application itself.