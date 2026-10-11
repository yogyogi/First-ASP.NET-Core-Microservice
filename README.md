# First ASP.NET Core Microservice with Web API CRUD Operations on a MongoDB Database

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/First-ASP-NET-Core-Microservice.png" alt="First ASP.NET Core Microservice"  title="First ASP.NET Core Microservice">

In this tutorial we will build our first Microservice in ASP.NET Core which will perform CRUD operations on a MongoDB database. The CRUD operations will be performed though a Web API method. This Microservice will form a part of a drone pizza delivery application.

**This repository is updated to .NET 10.0**

# Tutorial Contents

1. Drone Pizza Delivery Application in Microservices Architecture
2. What is a Microservice
3. Monolith Architecture
4. Creating First ASP.NET Core Microservice
5. Entities and Data Transfer objects
6. MongoDB Connection String, Configuration, Repository and Settings
7. Creating Web API to Perform CRUD operations
8. Blazor Web APP: User Interface of Microservice
9. Adding CommandCenter, CCUI, and MongoDB to Docker Compose
10. Testing Microservices Operations with CCUI (Blazor Web App)
11. Testing CRUD Operations with Swagger
10. Create an Order
11. Get all Orders
12. Get Order by it’s Id
13. Update an Order
14. Delete an Order

## How to run the app

You need to have Docker installed on your PC. Then in command prompt navigate to the directory of `docker-compose.yml` file and run the following 2 commands:

```
docker-compose build
```

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/docker-compose-build.png" alt="Docker Compose Build command" title="Docker Compose Build command" class="img-fluid">

```
docker-compose up -d
```

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/docker-compose-up.png" alt="Docker Compose Up Command" title="Docker Compose Up Command" class="img-fluid">

Now access the CCUI project on the browser. It’s url being – `https://localhost:9001/`

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/create-order-ccui.png" alt="Create Order CCUI" title="Create Order CCUI" class="img-fluid">

Also access the Web API with Swagger. It's url being - `https://localhost:8001/swagger`

<img src="https://www.yogihosting.com/wp-content/uploads/2026/10/swagger.png" alt="Swagger" title="Swagger" class="img-fluid">

For any confusion, read the entire article here - https://www.yogihosting.com/aspnet-core-microservice/


## Want to support me ?

Your support of every $5 will be a great reward for me to carry on my work. Thank you!

<a href="https://www.buymeacoffee.com/YogYogi" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" width="200"  style="height: 60px !important;width: 200px !important;" ></a>
<a href="https://www.paypal.com/paypalme/yogihosting" target="_blank"><img src="https://raw.githubusercontent.com/yogyogi/yogyogi/main/paypal.png" alt="Paypal Me" width="300"></a>

