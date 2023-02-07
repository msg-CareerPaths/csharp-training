## 2. Database access
__Goals:__
a) Understanding the need and advantages of databases compared to the file system.
b) Principles of databases.
c) Understanding, comparing, contrasting, using and integrating different database frameworks into a web application.
e) Choosing and using relational and non-relational databases.

__Why databases?__
* You can query data in a database (ask it questions).
* You can look up data from a database relatively rapidly.
* You can relate data from two different tables together using JOINs.
* You can create meaningful reports from data in a database.
* Your data has a built-in structure to it.
* Information of a given type is always stored only once.
* Databases are ACID.
* Databases are fault-tolerant.
* Databases can handle very large data sets.
* Databases are concurrent; multiple users can use them at the same time without corrupting the data.
* Databases scale well.

Required reading: [File System vs. Database](https://dzone.com/articles/which-is-better-saving-files-in-database-or-in-fil)

Products App: 
Ask yourself the following questions: what happens if you want to update a numeric quantity into a very large products/orders data file that stores online shop information? What happens if during the time spent with reading/searching a large file, other simultaneous requests come for writing or modifying or deleting the same quantities or entries and what happens if during that exact time there is a power shortage? Can databases address some of these problems?

Further reading: [Why use a database instead of saving data to disk?](https://arstechnica.com/information-technology/2013/05/why-use-a-database-instead-of-just-saving-your-data-to-disk/)