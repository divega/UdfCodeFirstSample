UDF Code First Sample
===

This sample shows how scalar user defined functions defined in the database can be used in a LINQ query with an Entity Framework Code First model. 

Although UDFs (or any other function that is not mapped to CREATE/UPDATE/DELETE operations) are still not supported out of the box in EF, it is possible to leverage some of the extensibility points available, e.g. model conventions and DbFunctionAttribute, SQL execution in migrations, to make this work.
