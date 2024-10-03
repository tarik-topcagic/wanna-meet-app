# Wanna Meet?

Wanna Meet? is a web application built using .NET and Angular that allows users to meet new people.

## Requirements

- Node.js
- .NET SDK (version 8.0.100)
- Angular CLI (version 17.3.0 or later)
- Visual Studio Code (or any code editor)

## Installation

Follow these steps to download and run the project:

### 1. Clone the repository
Clone the project from GitHub by running the following command in your terminal:

```bash
 git clone https://github.com/tarik-topcagic/wanna-meet-app.git
```

### 2. Open the project in Visual Studio Code
Open the project folder in Visual Studio Code or any other preferred editor.

### 3. Install dependencies
Navigate to the client folder where the Angular frontend is located and run the following command to install the necessary packages:

```bash
npm install
```

If you encounter any dependency issues, you can use the following command to bypass version conflicts:

```bash
npm install --legacy-peer-deps
```

### 4. Add the Token Key
Open the "appsettings.Development.json" file located in the API folder, and add the following key:

"TokenKey": "super secret token key super secret token key super secret token key"

### 5. Running the Backend
Navigate to the backend folder API and run the .NET application:

```bash
dotnet run
```

### 6. Running the Frontend
Navigate to the client folder (Angular frontend) and run:

```bash
ng serve
```

Now, open your browser and go to http://localhost:4200 to access the frontend.

## Login and Registration

- Registration: To register, use the registration form in the application
- Login with Test Users: If you want to test logging in, you can use following test user account:
  - Username: lisa
  - Password: Pa$$w0rd
- Login as an admin: If you want as an admin to test the role change for users, you can use following admin account:
  - Username: admin
  - Password: Pa$$w0rd

## Questions and Issues
If you have any questions or encounter any issues, please feel free to contact:
- Email: tarik.topcagic.7@gmail.com