UDF Code First Sample
===

This sample shows how database scalar user defined functions can be used in a LINQ query with an Entity Framework Code First model. 

Although user defined functions (or any other function that is not for mapping of CREATE/UPDATE/DELETE operations) are  still not supported out of the box in EF, it is possible to leverage some of the extensibility points available, e.g. model conventions and DbFunctionAttribute, to make this work.
