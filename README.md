# Local Business Lookup Api

#### By Brandon Spear

#### Brief Description of Application

Application Allows Users to find Businesses around them. 


## Technologies Used

- _C#_
- _Entity Framework Core_
- _MySQL_
- _ASP.NET Core MVC_
- _Swagger_

## Description

This is an application that allows the user to make Get, Post, Put, Delete requests to the BusinessApi in order to find local stores. One may be able to find a specific store with the unique id of the business and they may also filter the amount of store they would like to see at a given time.

## Setup/Installation Requirements

- Clone this repository to your desktop:

```
    $ git clone https://github.com/TheEPICturkey/Buisness.API.V2.git
```

- Navigate to the Business.API.V2 directory on your desktop and open the cloned directory with your favorite text editor (Visual Studio Code was used when setting this project up).

- Navigate into the Business Api production directory and run the code:

```
    $ dotnet restore
```

- Within the production directory, create a new file called `appsettings.json`.

- Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL Workbench. Please install MySQL Workbench if not already installed on your local machine.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_NAME];uid=[YOUR_ID];pwd=[YOUR_PASSWORD];"
  }
}
```

- To launch the API, run the following codes in the production directory:

```
    $ dotnet build
```

```
    $ dotnet watch run
```

## Re-creating the Database

1. Launch MySQL Workbench and open your local instance.
2. Then follow [this link](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/introduction-to-mysql-workbench-creating-a-database) with instructions to create a database, based on the data from the `Models` directory.
3. You may also use migrations to create and update your database without having to manually create them yourself. Follow [this link](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations) for instructions to install the right tools.
4. There should only be one table called `Businesses`.

## API Documentation/Endpoints

Base URL: `https://localhost:5001`

#### HTTP Request Structure

```
GET /api/[controller]
POST /api/[controller]
GET /api/[controller]/{id}
PUT /api/[controller]/{id}
DELETE /api/[controller]/{id}
```

### Note on Request Structure

The [controller] for the BusinessApi is Businesses.

```
GET /api/Businesses
POST /api/Businesses
GET /api/Businesses/{id}
PUT /api/Businesses/{id}
DELETE /api/Businesses/{id}
```

### Note on Different Responses

200: Success<br>
201: Created (New local business was successfully created)<br>
400: Error: Bad Request<br>
404: Error: Not Found (Entered a non-existent id)<br>

#### Parameters

| Name        | Type   |
| ----------- | ------ |
| name        | string |
| address     | string |
| description | string |
| rating      | double |
| review      | string |

#### Example Query

```
https://localhost:5001/api/Businesses/5
```

#### Sample JSON Response

```
{
  "businessId": 5,
  "name": "James J. Jameson's Treats",
  "address": "1234 Fifth Street WA",
  "description": "Dessert Shop",
  "rating": 0.5,
  "review": "Wouldnt give me a free treat:("
}
```

#### Example Query With Pagination Parameters

```
https://localhost:5001/api/Businesses?Page=1&ItemsPerPage=3
```

#### Sample JSON Response

```
[
  {
    BusinessId = 1,
    Address = "1234 Fifth Street WA",
    Description = "Bakery",
    Name = "Pierres Bakery",
    Rating = 4.7999999999999998,
    Review = "Very tastey!"
  },
  new
  {
    BusinessId = 2,
    Address = "1234 Fifth Street WA",
    Description = "Factory",
     Name = "Silly String Factory",
     Rating = 2.2000000000000002,
      Review = "Too much work"
  },
  new    
  {
     BusinessId = 3,
     Address = "1234 Fifth Street WA",
     Description = "Hair Salon",
     Name = "Hair Salon",
     Rating = 3.3999999999999999,
     Review = "I got an awesome mullet!"
  },
  new
  {
     BusinessId = 4,
     Address = "1234 Fifth Street WA",
     Description = "Pizza Parlor",
     Name = "Goodboy's Pizza Parlor",
     Rating = 5.0,
     Review = "Best Pizza In The World!"
  },
  new
  {
     BusinessId = 5,
     Address = "1234 Fifth Street WA",
      Description = "Dessert Shop",
     Name = "James J. Jameson's Treats",
     Rating = 0.5,
     Review = "Wouldnt give me a   treat:("
  }
]
```

### Note on Pagination Parameters

Both the page query parameter and items per page query parameters are optional. The BusinessApi will return a default of 5 results per page at a time, and up to a maximum of 5. If the page query parameter is left blank, it will return page 1 as default.

## Known Bugs

- _No known bugs as of now_

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _2023_ _Brandon Spear_
