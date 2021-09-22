# dotnet-bakery

This is the starting point for teaching an intro to .NET Core WebAPI project. The models and controllers are stubbed out but empty.

![](https://cdn-blog.adafruit.com/uploads/2010/11/gingerbread03.jpg)

---


## Entity Framework

Entity Framework is an ORM

ORM === "Object Relational Mapper"
aka "A really fancy way to talk to your database"

No more SQL!

Models (data objects) are "mapped" to database tables
    Baker.cs Model <--> Baker DB Table

baker = new Baker {
    name = "Edan"
    skillLevel = 1000
}
db.Save(baker);     // Auto-magically run SQL INSERT queries


## 