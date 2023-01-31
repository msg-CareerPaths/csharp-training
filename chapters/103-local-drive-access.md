## 1.3. Local drive access 

Goal: Understand IO Operations and JSON Serialization 

Required Reading:

 - [Serialize JSON using System.Text.Json](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0)
  
	-it is the main JSON Serialization library in .Net 6 and recommended for new projects.
 - [How to create a file or folder](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder)
 - [How to copy, delete, and move files and folders](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders)
 - [How to write to a text file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file)
 - [How to read from a text file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file)


OnlineShop: Save product information and order information on local json files on disk.

  - Every time a product is created a file must be created on disk with information about the product. 

  - When a product is modified or deleted, this must reflect in the files saved on disk.

  - Every time an order is created a file must be created containing the order information.
  
  - You will have to come up with an apropiate folder structure for this task

Further Reading:
 - [An alternative for serialization is Newtonsoft.Json](https://www.youtube.com/watch?v=hLYHE1kIOpo)

	-it is important to know about Newtonsoft.Json, as it was the main library used for JSON serialization for C#, and it can be found in older projects
 - [Comparison of System.Text.Json and Newtonsoft.Json](https://inspiration.nlogic.ca/en/a-comparison-of-newtonsoft.json-and-system.text.json)
 - [More about File system can be found here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/)
 - [File and Stream I/O](https://docs.microsoft.com/en-us/dotnet/standard/io/)