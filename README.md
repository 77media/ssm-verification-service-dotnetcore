# ssm-verification-service-dotnetcore
Sample user verification service that will either return a formatted user object or false.

#### request
A POST is preferred to a GET because more fields can be sent and data is not logged in the url like in a GET.

In production the route should always be secured with SSL encryption via https.

HTTP POST
http://localhost:5000/api/verify

```javascript
{  
    LastName: "Doe",  
    ConfirmationNumber: "4567"  
}  
```

#### result

```javascript
{  
  "id": 1,
  "isValid": true,
  "firstName": "John",
  "lastName": "Doe",
  "email": null,
  "dateOfBirth": "0001-01-01T00:00:00",
  "country": null,
  "region": null,
  "address": null,
  "address2": null,
  "city": null,
  "postal": null,
  "gender": null,
  "position": null,
  "membershipId": "12345",
  "membershipExpiration": "2020-01-01T00:00:00" 
}
```

## invalid verification


HTTP POST
http://localhost:5000/api/verify

```javascript
{ 
    LastName: "SDFSDF",
    ConfirmationNumber: "12324", 
    ScanCode: ""
}
```

## sample result

400 Bad Request

## Process Overview

1. Your organization would direct all of your members to register on the SafeSport portal using a special link. This link would be specific to your organization only and would automatically open a dialog box with your organization auto-selected. All your members would have to enter would be their member identifier.

2. Your members would enter their member identifier. This identifier would then be passed to your organization’s web service. Your system would then determine whether or not the identifier is valid.

3. If the identifier is valid, your organization passes back that it is valid as well as the user’s information to complete the SafeSport registration form. You can pass back as many or as few as fields as you wish. For any field not passed back, users must enter the information themselves.

4. If the identifier is NOT valid, then your organization passes back that it is invalid. The user then has the opportunity to re-enter or contact your organization for help.

## Organization Registration Fields
The following fields are required in the user registration process. Any field not passed to the platform in the service must be manually filled out by your members.
```javascript
    isValid: DataTypes.BOOLEAN,  
    firstName: DataTypes.STRING, 
    lastName: DataTypes.STRING,
    email: { type: DataTypes.STRING, unique: true},
    dateOfBirth: DataTypes.DATE,
    country: DataTypes.STRING,
    region: DataTypes.STRING,
    address: DataTypes.STRING,  
    address2: DataTypes.STRING,
    city: DataTypes.STRING,
    postal: DataTypes.STRING,
    gender: DataTypes.STRING,
    position: DataTypes.STRING // (Administrator, Athlete, Coach, Official, Other, Parent, Volunteer)  

```

Membership expiration can be used if you want to require your members to verify again after their membership has expired. Post expiration, your members will not be able to complete courses on the platform until after they have re-verified their membership.

```javascript
    membershipExpiration: DataTypes.DATE
```

## This application consists of:

*   Sample pages using ASP.NET Core MVC
*   [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

## How to

*   [Add a Controller and View](https://go.microsoft.com/fwlink/?LinkID=398600)
*   [Add an appsetting in config and access it in app.](https://go.microsoft.com/fwlink/?LinkID=699562)
*   [Manage User Secrets using Secret Manager.](https://go.microsoft.com/fwlink/?LinkId=699315)
*   [Use logging to log a message.](https://go.microsoft.com/fwlink/?LinkId=699316)
*   [Add packages using NuGet.](https://go.microsoft.com/fwlink/?LinkId=699317)
*   [Add client packages using Bower.](https://go.microsoft.com/fwlink/?LinkId=699318)
*   [Target development, staging or production environment.](https://go.microsoft.com/fwlink/?LinkId=699319)

## Overview

*   [Conceptual overview of what is ASP.NET Core](https://go.microsoft.com/fwlink/?LinkId=518008)
*   [Fundamentals of ASP.NET Core such as Startup and middleware.](https://go.microsoft.com/fwlink/?LinkId=699320)
*   [Working with Data](https://go.microsoft.com/fwlink/?LinkId=398602)
*   [Security](https://go.microsoft.com/fwlink/?LinkId=398603)
*   [Client side development](https://go.microsoft.com/fwlink/?LinkID=699321)
*   [Develop on different platforms](https://go.microsoft.com/fwlink/?LinkID=699322)
*   [Read more on the documentation site](https://go.microsoft.com/fwlink/?LinkID=699323)

## Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)

