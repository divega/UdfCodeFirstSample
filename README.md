UDF Code First Sample
===

This sample shows how scalar user defined functions defined in the database can be used in a LINQ query with an Entity Framework Code First model. 

Although UDFs (or any other function that is not mapped to CREATE/UPDATE/DELETE operations) are still not supported out of the box in EF, it is possible to leverage some of the extensibility points available, e.g. model conventions and DbFunctionAttribute, SQL execution in migrations, to make this work.

For other function support, including TVFs and stored procedures in Code First you can take a look at the extension described at http://blog.3d-logic.com/2014/04/09/support-for-store-functions-tvfs-and-stored-procs-in-entity-framework-6-1/
